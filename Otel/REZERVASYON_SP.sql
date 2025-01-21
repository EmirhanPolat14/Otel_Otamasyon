ALTER PROC REZERVASYON
@ISIM AS VARCHAR(500),
@SOYISIM AS VARCHAR(500),
@TCNO AS VARCHAR(500),
@DOGUM_TARIH VARCHAR(500),
@CINSIYET VARCHAR(500),
@TELEFON AS VARCHAR(200),
@MAIL AS VARCHAR(100)=NULL,
@ODA_NO AS TINYINT=NULL,
@TARIH AS DATETIME=NULL,
@BASLANGICTARIHI AS DATE,
@BITISTARIHI AS DATE,
@KISI AS TINYINT,
@EK_YATAK AS TINYINT = 0
AS

DECLARE @ODA_KISI AS TINYINT
DECLARE @ODA_DURUM AS BIT
SELECT @ODA_KISI=Kisi_Sayisi, @ODA_DURUM=Oda_Durumu FROM Odalar WHERE Oda_No = @ODA_NO 
-- @ODA_KISI ile birlikte bir odada birden fazla kiþi kalacksa ayrý bir þekilde kayýt iþleminin gerçekleþebilmesi için bunun kontrolü,
--  MUSAITODA fonksiyonu ile odanýn müsaitlik durumu ve en sonunda da ayný tarihler arasýnda odaya baþka bir rezervasyon olup olmadýðýnýn kontrolü yapýlýr.
IF ( ( @ODA_KISI = 0 AND EXISTS(SELECT * FROM dbo.MUSAITODA(@KISI, @BASLANGICTARIHI, @BITISTARIHI, @EK_YATAK))))
BEGIN
	-- Birden fazla kiþinin kalacak olmasý ihtimaline karþý bu kiþilerin önemli bilgileri ayrý ayrý müþteriler tablosuna kaydedilirken tek bir rezervasyon oluþuyor
	CREATE TABLE #ISIM(ID INT IDENTITY(1,1),DEGER VARCHAR(50))
	CREATE TABLE #SOYISIM(ID INT IDENTITY(1,1),DEGER VARCHAR(50))
	CREATE TABLE #TCNO(ID INT IDENTITY(1,1),DEGER CHAR(11))
	CREATE TABLE #DOGUM(ID INT IDENTITY(1,1),DEGER DATE)
	CREATE TABLE #CINSIYET(ID INT IDENTITY(1,1),DEGER BIT)
	CREATE TABLE #TEL(ID INT IDENTITY(1,1), DEGER CHAR(13))
	
	INSERT INTO #ISIM(DEGER) SELECT VALUE FROM string_split(@ISIM,',')
	INSERT INTO #SOYISIM(DEGER) SELECT VALUE FROM string_split(@SOYISIM,',')
	INSERT INTO #TCNO(DEGER) SELECT CONVERT(CHAR(11),VALUE) FROM string_split(@TCNO,',')
	INSERT INTO #DOGUM(DEGER) SELECT CONVERT(DATE,VALUE) FROM string_split(@DOGUM_TARIH,',')
	INSERT INTO #CINSIYET(DEGER) SELECT CONVERT(BIT,VALUE) FROM string_split(@CINSIYET,',')
	INSERT INTO #TEL(DEGER) SELECT CONVERT(CHAR(13), VALUE) FROM string_split(@TELEFON,',')

	DECLARE @I AS INT = 0
	WHILE @I < @KISI
	BEGIN	
		-- Müsteri tablosuna kayýtlarýn eklenmesi
		INSERT INTO Musteri(Tc_No, Isim, Soyisim,  Dogum_Tarihi, Cinsiyet, Telefon, E_mail,  Oda_No)
		SELECT  
			(SELECT DEGER FROM #TCNO WHERE ID = @I +1),
			(SELECT DEGER FROM #ISIM WHERE ID = @I +1),
			(SELECT DEGER FROM #SOYISIM WHERE ID = @I +1),
			(SELECT DEGER FROM #DOGUM WHERE ID = @I +1),
			(SELECT DEGER FROM #CINSIYET WHERE ID = @I +1),
			(SELECT DEGER FROM #TEL WHERE ID = @I + 1),
			@MAIL,@ODA_NO
		-- Rezervasyon kaydý için müþteri ýd alýnmasý
		DECLARE @MUSTERID AS INT 
		SET @MUSTERID = SCOPE_IDENTITY()
		-- ilk, yani rezervasyonu yapan müsteri üstünden rezervasyon kaydýnýn oluþturulmasý
		IF @I = 0 
		BEGIN
			SET @TARIH = GETDATE()
			-- @TUTAR deðiþkeni ucret fonksiyonunda hesaplanan ödeme tutarýný tutar.
			DECLARE @TUTAR AS FLOAT 
			SET @TUTAR = (SELECT dbo.UCRET(@ODA_NO, DATEDIFF(DAY,@BASLANGICTARIHI,@BITISTARIHI), @EK_YATAK))
			-- rezervasyon kaydo oluþturuluyor
			INSERT INTO Rezervasyonlar(Musterý_Id,Oda_No,Rez_baslangic,Rez_bitis,Kisi_Sayisi,Rez_tarih)
			VALUES (@MUSTERID, @ODA_NO,@BASLANGICTARIHI,@BITISTARIHI,@KISI,@TARIH)
			DECLARE @REZID AS INT 
			SET @REZID = SCOPE_IDENTITY()
			-- ödeme tablosuna ödeme kaydý oluþturuluyor
			INSERT INTO ODEMELER(MUSTERI_ID, TUTAR)
			VALUES (@MUSTERID,@TUTAR)
			-- EK YATAÐIN MÜÞTERÝ HÝZMET TABLOSUNA KAYDI
			INSERT INTO MusteriHizmet(Musteri_id, Oda_No, Hizmetid, Adet)
			VALUES(@MUSTERID, @ODA_NO, 1, @EK_YATAK)
		END

		SET @I = @I + 1
	END
	-- tutar ve rezervasyon numarasýnýn müþteriye bildirilmesi
	PRINT CONCAT_WS(' ', 'ÖDENECEK TUTAR', @TUTAR, 'TL')
	PRINT CONCAT_WS(' ',@BASLANGICTARIHI, 'ile', @BITISTARIHI, 'tarihleri arasýndaki rezervasyonunuz baþarýyla oluþturuldu.')
	PRINT CONCAT_WS(' ', 'Rezervasyon numarasý:', @REZID, 'LÜTFEN BU NUMARAYI SAKLAYINIZ!')

END

ELSE
BEGIN
	-- Odanýn dolu olmasý veya belirtilen tarihlerde odaya farklý bir rezervasyon bulunmasý durumunda verilecek hata
	RAISERROR('Belirtilen oda dolu veya oda kapasitesi aþýldý!',16,1)
END




