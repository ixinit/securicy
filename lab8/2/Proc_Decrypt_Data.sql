CREATE PROCEDURE [dbo].[decrypt_Data] 
/* расшифровывает и показывает*/
AS
OPEN SYMMETRIC KEY SSN_Key 
DECRYPTION BY PASSWORD = '123';
select Id AS'Номер', CONVERT(varchar(100), DecryptByKey(Name) ) 
		AS 'Имя', CONVERT(varchar(80), DecryptByKey(Invest) ) 
		AS 'Инвестиции'  
		from Users