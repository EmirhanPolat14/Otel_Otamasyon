ALTER PROC CHECK_IN
@REZ_ID AS INT =  NULL,
@ISIM AS VARCHAR(50) = NULL,
@SOYISIM AS VARCHAR(50) = NULL,
@TCNO AS CHAR(11),
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
	-- @REZ_ODANO Rezervasyonda belirtilen oda numarasýný ifade ediyor
	DECLARE @REZ_ODANO AS TINYINT = (SELECT Oda_No FROM Rezervasyonlar WHERE Rez_Id=@REZ_ID)
	-- Oda durumu kontrol ediliyor
	IF (SELECT Oda_Durumu FROM Odalar WHERE Oda_No=@REZ_ODANO) = 1
		BEGIN
		-- Rezervasyonlu kiþilerin giriþ tarihleri alýnýp müþteriler tablosundaki giris tarihi kolonuna güncelleme yapýlýyor.
		-- Ayný rezervasyona sahip birden fazla kiþi ayrý zamanlarda odaya giriþ yapabileceði için ayrýca tcno ile de iliþkilendirildi.
		UPDATE Musteri 
		SET Giris_Tarihi=GETDATE()
		WHERE Oda_No = @REZ_ODANO AND Tc_No = @TCNO
		-- Odadaki kisi sayýsý güncelleniyor
		UPDATE Odalar
		SET Kisi_Sayisi = Kisi_Sayisi + 1
		WHERE Oda_No = @REZ_ODANO
		-- @REZ_KISI rezervasyonda belirtilen kiþi sayýsýný, @ODA_KISI odada güncel olarak bulunan kiþi sayýsýný ifade ediyor.
		DECLARE @REZ_KISI AS TINYINT
		DECLARE @ODA_KISI AS TINYINT
		SELECT @REZ_KISI=R.Kisi_Sayisi,@ODA_KISI=O.Kisi_Sayisi FROM Odalar O JOIN Rezervasyonlar R ON R.Oda_No = O.Oda_No WHERE R.Rez_Id=@REZ_ID
		-- eðer bu iki deðer birbirine eþitlenmiþse odanýn durumu 0 (müsait deðil) olarak güncelleniyor
		IF ( @ODA_KISI = @REZ_KISI )
		BEGIN
			UPDATE Odalar
			SET Oda_Durumu = 0
			WHERE Oda_No = (SELECT Oda_No FROM Rezervasyonlar WHERE @REZ_ID = Rez_Id)
		END
	END
	ELSE 
		BEGIN
			RAISERROR('Oda dolu!',16,1)
		END
END

ELSE
-- Rezervasyonu olmayan müþetirinin kontrolleri
BEGIN
	-- oda durumu ve giriþ yapýlmaya çalýþýlan tarihte rezervasyon var mý diye bakýlýyor.
	IF ( (SELECT Oda_Durumu FROM Odalar WHERE Oda_No = @ODA_NO) = 1 AND
	NOT EXISTS(SELECT Oda_No FROM Rezervasyonlar WHERE GETDATE() BETWEEN Rez_baslangic AND Rez_bitis AND @ODA_NO = Oda_No) )
	BEGIN
		-- Yine ayrý ayrý kayýtlar veya giriþler yapabilmek için @KISI ile odanýn durumu kontrol ediliyor
		-- Ýlk girenden sonrakiler kiþi sayýsýný tekrar belirtmek zorunda olmasýn diye ilk girenin belirttiði kiþi sayýsý baz alýnýyor
		IF @KISI IS NULL
		BEGIN
			SET @KISI = (SELECT Kisi_sayisi FROM Musteri WHERE Oda_No=@ODA_NO)
		END
		-- Müþteri tablosuna bilgiler ekleniyor
		INSERT INTO Musteri(Tc_No, Isim, Soyisim, Dogum_Tarihi, Cinsiyet, Telefon, E_mail , Oda_No, Giris_Tarihi, Ek_Yatak, Kisi_sayisi)
		VALUES(@TCNO, @ISIM, @SOYISIM,@DOGUM_TARIH, @CINSIYET, @TELEFON, @MAIL, @ODA_NO, GETDATE(), @EK_YATAK,@KISI)
		-- Odadaki kiþi sayýsý güncelleniyor
		UPDATE Odalar
		SET Kisi_Sayisi = Kisi_Sayisi + 1
		WHERE Oda_No = @ODA_NO

		SET @ODA_KISI = (SELECT Kisi_Sayisi FROM Odalar WHERE Oda_No = @ODA_NO)
		-- Odadaki kiþi ile kalan kiþi sayýsý eþitlenþnce oda durumu 0'a çevriliyor
		IF ( @ODA_KISI = @KISI )
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

