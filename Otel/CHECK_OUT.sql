ALTER PROC CHECK_OUT
@ODA_NO AS TINYINT
AS
-- rezervasyonlular, rezervasyon sýrasýnda ödeme yaptýðý için ceheck-out sýrasýnda ödeme gerekmþyor. 
DECLARE @MUSTERI_ID AS INT
SET @MUSTERI_ID = (SELECT TOP 1 Musterý_Id FROM Musteri WHERE Oda_No=@ODA_NO)
-- if sorgusunda çýkýþ yapacak kiþinin ödeme yapýp yapmadýðý kontrol ediliyor
IF NOT EXISTS( SELECT * FROM ODEMELER WHERE MUSTERI_ID = @MUSTERI_ID)
BEGIN
	DECLARE @TUTAR AS FLOAT
	DECLARE @GIRIS AS DATETIME
	DECLARE @CIKIS AS DATETIME
	DECLARE @EKYATAK AS TINYINT
	-- musteri tablosundan ücret hesaplamak için gerekli olan alanlar alýnýyor ve çýkýþ tarihi giriliyor.
	SELECT @GIRIS=Giris_Tarihi, @EKYATAK=Ek_Yatak FROM Musteri
	WHERE Musterý_Id = @MUSTERI_ID

	SET @CIKIS = GETDATE()
	-- fonksiyon aracýlýðýyla ücret hesaplanýyor
	SET @TUTAR = (SELECT dbo.UCRET(@ODA_NO, DATEDIFF(DAY,@GIRIS, @CIKIS), @EKYATAK))
	-- ödemeler tablosuna ödeme yapýldýðýna dair kayýt giriliyor.
	INSERT INTO ODEMELER(MUSTERI_ID,TUTAR)
	VALUES (@MUSTERI_ID, @TUTAR)
	PRINT CONCAT_WS(' ', 'ODENECEK TUTAR', @TUTAR, 'TL')
END
-- müsteri tablosundan odadaki müþteriler siliniyor
DELETE FROM Musteri
WHERE Oda_No = @ODA_NO
-- oda durumu güncelleniyor
UPDATE Odalar
SET Oda_Durumu=1, Kisi_Sayisi = 0
WHERE Oda_No=@ODA_NO

