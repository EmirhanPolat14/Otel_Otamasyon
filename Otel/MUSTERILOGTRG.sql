ALTER TRIGGER TRG_CHECKOUT
ON Musteri
AFTER DELETE
AS 
BEGIN
	DECLARE @TUTAR AS FLOAT
	DECLARE @MUSTERID AS INT

	SELECT @MUSTERID=Muster�_Id FROM deleted
	SET @TUTAR = (SELECT TUTAR FROM ODEMELER WHERE MUSTERI_ID=@MUSTERID)

	INSERT INTO 
	Musteri_LOG(Muster�_Id, Tc_No, Isim, Soyisim, Dogum_Tarihi, Cinsiyet, Telefon, E_mail, Oda_No, Giris_Tarihi, Cikis_Tarihi, Ek_Yatak, Odenen)
	SELECT Muster�_Id, Tc_No, Isim, Soyisim, Dogum_Tarihi, Cinsiyet, Telefon, E_mail, Oda_No, Giris_Tarihi, ISNULL(Cikis_Tarihi,GETDATE()), Ek_Yatak, @TUTAR
	FROM deleted

END