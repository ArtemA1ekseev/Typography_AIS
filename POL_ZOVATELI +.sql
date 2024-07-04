--В MS SQL Server Management Studio(SSMS) напишем процедуру для добавления пользователей.
USE [Typography]
go
CREATE PROCEDURE addlogin
@login char(15), @passwordl char(15)
AS
exec sp_addlogin @login,@passwordl, 'Typography'
exec sp_adduser @login,@login
GO
--Для привилегирования пользователей напишем процедуру.
USE [Typography]
go
CREATE PROCEDURE grantlogin 
@textl char(250) AS
declare @SQLString nvarchar(250)
SET @SQLString = CAST( @textl AS NVARCHAR(250)) EXECUTE sp_executesql @SQLString
GO

USE [Typography]
go
CREATE PROCEDURE dellogin11 
@login char(15)
AS
exec sp_dropuser  @login
go
