ALTER FUNCTION ENYAKINREZ(@ODANO AS TINYINT)
RETURNS TINYINT
AS
BEGIN
    DECLARE @RESULT AS TINYINT;

    -- En yakýn rezervasyon tarihi hesapla
    SELECT TOP 1 @RESULT = DATEDIFF(DAY, GETDATE(), Rez_baslangic) 
    FROM Rezervasyonlar  
    WHERE Oda_No = @ODANO 
    AND DATEDIFF(DAY, GETDATE(), Rez_baslangic) BETWEEN 0 AND 30
    ORDER BY Rez_baslangic ASC;

    -- Eðer @RESULT NULL ise 31 döndür
    RETURN IIF(@RESULT IS NULL, 31, @RESULT);
END;

SELECT DBO.ENYAKINREZ(4)

SELECT * FROM Rezervasyonlar

UPDATE Rezervasyonlar SET Rez_baslangic = '2025-02-11' WHERE Rez_Id= 17