ALTER PROC CHECK_IN
@REZ_ID AS INT =  NULL,
@ISIM AS VARCHAR(50) = NULL,
@SOYISIM AS VARCHAR(50) = NULL,
@TCNO AS CHAR(11) = NULL,
@DOGUM_TARIH AS DATE = NULL,
@CINSIYET AS BIT = NULL,
@TELEFON AS CHAR(11) = NULL,
@MAIL AS VARCHAR(100) = NULL,
@ODA_NO AS TINYINT = NULL,
@KISI AS TINYINT= NULL,
@EK_YATAK AS TINYINT = 0
AS
IF @REZ_ID IS NOT NULL
BEGIN
	UPDATE Musteri 
	SET Giris_Tarihi=GETDATE()
	WHERE Musterý_Id = (SELECT Musterý_Id FROM Rezervasyonlar WHERE Rez_Id=@REZ_ID)

	UPDATE Odalar
	SET Kisi_Sayisi = Kisi_Sayisi + 1
	WHERE Oda_No = (SELECT Oda_No FROM Rezervasyonlar WHERE @REZ_ID = Rez_Id)
	-- BÝRDEN ÇOK KÝÞÝ AYNI ODADA KALACAKSA KÝÞÝ SAYISI ÜZERÝNDEN BUNU TAKÝP EDÝP ODANIN DURUMU GÜNCELLENÝYOR
	IF ( (SELECT O.Kisi_Sayisi FROM Odalar O JOIN Rezervasyonlar R ON R.Oda_No = O.Oda_No WHERE R.Rez_Id=@REZ_ID) = (SELECT R.Kisi_Sayisi FROM Odalar O JOIN Rezervasyonlar R ON R.Oda_No = O.Oda_No WHERE R.Rez_Id=@REZ_ID) )
	BEGIN
		UPDATE Odalar
		SET Oda_Durumu = 0
		WHERE Oda_No = (SELECT Oda_No FROM Rezervasyonlar WHERE @REZ_ID = Rez_Id)
	END
END

ELSE
BEGIN
	IF ( (SELECT Oda_Durumu FROM Odalar WHERE Oda_No = @ODA_NO) = 1 AND
	NOT EXISTS(SELECT Oda_No FROM Rezervasyonlar WHERE GETDATE() BETWEEN Rez_baslangic AND Rez_bitis AND @ODA_NO = Oda_No) )
	BEGIN
		INSERT INTO Musteri(Tc_No, Isim, Soyisim, Dogum_Tarihi, Cinsiyet, Telefon, E_mail , Oda_No, Giris_Tarihi, Ek_Yatak)
		VALUES(@TCNO, @ISIM, @SOYISIM,@DOGUM_TARIH, @CINSIYET, @TELEFON, @MAIL, @ODA_NO, GETDATE(), @EK_YATAK)
		
		UPDATE Odalar
		SET Kisi_Sayisi = Kisi_Sayisi + 1
		WHERE Oda_No = @ODA_NO

		IF ( (SELECT Kisi_Sayisi FROM Odalar WHERE Oda_No= @ODA_NO) = @KISI )
		BEGIN
			UPDATE Odalar
			SET Oda_Durumu = 0
			WHERE @ODA_NO = Oda_No
		END
	END
	ELSE
	BEGIN
		RAISERROR('Belirtilen oda dolu!',16,1)
	END
END

