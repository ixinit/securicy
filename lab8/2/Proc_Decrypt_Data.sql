CREATE PROCEDURE [dbo].[decrypt_Data] 
/* �������������� � ����������*/
AS
OPEN SYMMETRIC KEY SSN_Key 
DECRYPTION BY PASSWORD = '123';
select Id AS'�����', CONVERT(varchar(100), DecryptByKey(Name) ) 
		AS '���', CONVERT(varchar(80), DecryptByKey(Invest) ) 
		AS '����������'  
		from Users