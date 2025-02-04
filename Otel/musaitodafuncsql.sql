ALTER FUNCTION [dbo].[MUSAITODA](
@KISI SMALLINT,
@BASLANGIC DATE,
@BITIS DATE,
@EK_YATAK SMALLINT = 0)
RETURNS @TBL TABLE (
		ODANO TINYINT
)
AS 
BEGIN
		
		INSERT INTO @TBL(ODANO)
		SELECT O.Oda_No  
		FROM Odalar O
		WHERE @KISI <= O.Max_Kapasite 
		-- kiþi sayýsý maksimum kapasiteyi aþmamalý
		AND @KISI <= Max_Kapasite
		-- odanýn ek yatak kapasitesi (makskapasite - mevcut kapasite) aþýlmamalý
		AND (O.Max_Kapasite - O.Mevcut_Kapasite) >= @EK_YATAK
		-- ek yataklar gittiðinde kalan kiþi sayýsý mevcut kapasiteden küçük olmalý
		AND @KISI - @EK_YATAK <= Mevcut_Kapasite
		AND Oda_Durumu = 1 
		-- AYNI TARÝHLERDE REZ BULUNUP BULUNMAMA
		AND NOT EXISTS (SELECT 1 
						FROM Rezervasyonlar R 
						WHERE R.Oda_No = O.Oda_No
						AND (
						@BASLANGIC BETWEEN R.Rez_baslangic AND R.Rez_bitis
						OR @BITIS BETWEEN R.Rez_baslangic AND R.Rez_bitis
						OR (@BASLANGIC <= R.Rez_baslangic AND @BITIS >= R.Rez_bitis)))			
		RETURN			
END

-- BUNU DATA GRÝDE UYGULAMAYA ÇALIÞCAN
SELECT * FROM Odalar
WHERE Oda_no IN (SELECT ODANO FROM DBO.MUSAITODA(8,GETDATE(),'2025-02-11',4))

select * from Rezervasyonlar


