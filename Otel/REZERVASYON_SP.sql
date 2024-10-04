ALTER PROC REZERVASYON
@ISIM AS VARCHAR(50),
@SOYISIM AS VARCHAR(50),
@TCNO AS CHAR(11),
@DOGUM_TARIH AS DATE,
@CINSIYET AS BIT,
@TELEFON AS CHAR(11),
@MAIL AS VARCHAR(100),
@ODA_NO AS TINYINT,
@TARIH AS DATETIME=NULL,
@BASLANGICTARIHI AS DATE,
@BITISTARIHI AS DATE,
@KISI AS TINYINT,
@EK_YATAK AS TINYINT = 0
AS
IF ( ( (SELECT Kisi_Sayisi FROM Odalar WHERE Oda_No = @ODA_NO ) = 0 AND (SELECT Oda_Durumu FROM Odalar WHERE Oda_No = @ODA_NO) = 1) AND
NOT EXISTS(SELECT Oda_No FROM Rezervasyonlar WHERE @BASLANGICTARIHI BETWEEN Rez_baslangic AND Rez_bitis AND @ODA_NO = Oda_No) )
BEGIN
	DECLARE @TUTAR AS FLOAT 
	SET @TUTAR = (SELECT dbo.UCRET(@ODA_NO, DATEDIFF(DAY,@BASLANGICTARIHI,@BITISTARIHI), @EK_YATAK))
	SET @TARIH = GETDATE()

	INSERT INTO Musteri(Tc_No,Isim,Soyisim,Dogum_Tarihi,Cinsiyet,Telefon,E_mail,Oda_No,Ek_Yatak)
	VALUES (@TCNO, @ISIM, @SOYISIM, @DOGUM_TARIH, @CINSIYET, @TELEFON, @MAIL, @ODA_NO,@EK_YATAK)

	DECLARE @MUSTERID AS INT 
	SET @MUSTERID = SCOPE_IDENTITY()

	INSERT INTO Rezervasyonlar(Muster�_Id,Oda_No,Rez_baslangic,Rez_bitis,Kisi_Sayisi,Rez_tarih)
	VALUES (@MUSTERID, @ODA_NO,@BASLANGICTARIHI,@BITISTARIHI,@KISI,@TARIH)
	
	INSERT INTO ODEMELER(MUSTERI_ID, TUTAR)
	VALUES (@MUSTERID,@TUTAR)

	PRINT CONCAT_WS(' ', '�DENECEK TUTAR', @TUTAR, 'TL')
	PRINT CONCAT_WS(' ',@BASLANGICTARIHI, @BITISTARIHI, 'tarihleri aras�ndaki randevunuz ba�ar�yla olu�turuldu.')

END

ELSE
BEGIN
	RAISERROR('Belirtilen oda dolu!',16,1)
END








