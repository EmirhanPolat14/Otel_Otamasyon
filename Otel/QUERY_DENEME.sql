TRUNCATE TABLE REZERVASYONLAR
SELECT * FROM Rezervasyonlar

DELETE ODEMELER  WHERE Musterý_Id IN(16,17)

UPDATE Odalar
SET Oda_Durumu= 1, Kisi_Sayisi=0 
SELECT * FROM Odalar

SELECT * FROM Musteri 
TRUNCATE TABLE Musteri

TRUNCATE TABLE MusteriHizmet
SELECT * FROM MusteriHizmet

TRUNCATE TABLE Odemeler
SELECT * FROM Odemeler

TRUNCATE TABLE Uyeler
SELECT * FROM Uyeler


SELECT M.Isim AS AD, M.Soyisim AS SOYAD ,R.Rez_baslangic AS [Baþlangýç Tarihi],R.Rez_bitis AS [Bitiþ Tarihi], 
M.Oda_No AS [Kalýnan Oda], DATEDIFF(DAY, M.Giris_Tarihi, M.Cikis_Tarihi) AS [Kalýnan Gün],O.TUTAR AS [Ödenen Ücret] 
FROM Rezervasyonlar R
JOIN Musteri M ON M.Musterý_Id = R.Musterý_Id
JOIN ODEMELER O ON O.MUSTERI_ID = M.Musterý_Id
WHERE M.E_mail = 'emiaskdjajh@gmail.com'
ORDER BY M.Musterý_Id DESC

SELECT * FROM Rezervasyonlar R JOIN Musteri M ON M.Musterý_Id = R.Musterý_Id WHERE E_mail = 'emiaskdjajh@gmail.com'

INSERT INTO Rezervasyonlar([Musterý_Id], [Rez_baslangic], [Rez_bitis], [Oda_No], [Kisi_Sayisi], [Rez_tarih] )
VALUES
(17, '2025-01-31','2025-02-05', 4, 3,'2024-12-10') 

INSERT INTO ODEMELER([MUSTERI_ID], [TUTAR])
VALUES (16, dbo.UCRET(0, 4, DATEDIFF(DAY, '2024-12-12', '2024-12-24'), 0))

INSERT INTO Musteri( [Tc_No], [Isim], [Soyisim], [E_mail], [Dogum_Tarihi], [Cinsiyet], [Telefon], [Oda_No], [Giris_Tarihi], [Cikis_Tarihi], [Aktif])
VALUES ('15123264654', 'Mert', 'Atay', 'emiaskdjajh@gmail.com', '2000-01-24', 1, '(545) 412-1233', 4, '2025-01-31', '2025-02-05', 0)

SELECT dbo.UCRET(0, 5, DATEDIFF(DAY, '2024-12-12', '2024-12-24'), 0)

UPDATE ODEMELER SET TUTAR = 42000 WHERE ID=4


DECLARE @EKYATAK AS TINYINT
SELECT @EKYATAK=Adet FROM MusteriHizmet 
WHERE Oda_No = 1 AND Hizmetid = 1
declare @h as float
DECLARE @TUTAR AS FLOAT
set @h = (SELECT SUM(H.Birim_tutar * M.Adet)
		FROM MusteriHizmet M 
		JOIN Hizmetler H ON H.Hizmetid = M.Hizmetid  
		WHERE Musteri_id = 7)
SET @TUTAR = (SELECT dbo.UCRET(0,1, DATEDIFF(DAY,'2025-02-04 14:58:34.177', GETDATE()),@EKYATAK)) + IIF(@h IS NULL,0,@h)

PRINT CONCAT_WS(' ', 'ODENECEK TUTAR', @TUTAR, 'TL')

SELECT TOP 1 Musterý_Id FROM Musteri WHERE Oda_No=1 AND DATEDIFF(YEAR,Dogum_Tarihi,GETDATE()) >= 18 AND Aktif = 1