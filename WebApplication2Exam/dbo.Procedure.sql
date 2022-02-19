CREATE PROCEDURE [dbo].[Procedure]
	
AS
	create table PProducts(int "@ProductId" ,varchar(50) "@ProductName", Decimal(18,2) "@Rate Decimal", varchar(50) "@Description", varchar(50) "@CategoryName");
RETURN 0
