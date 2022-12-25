CREATE PROCEDURE [dbo].[Encryp_Data] @P1 INT, @P2 varchar(100), @P3 varchar(80)
/* P1,P2... - Id, Name, Invest */
AS
OPEN SYMMETRIC KEY SSN_Key 
DECRYPTION BY PASSWORD = '123';
    INSERT INTO  Users VALUES (@P1, 
	EncryptByKey(Key_GUID('SSN_Key'),@P2), 
	EncryptByKey(Key_GUID('SSN_Key'),@P3))
