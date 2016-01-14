CREATE TABLE [dbo].[Users]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Username] NVARCHAR(50) NOT NULL, 
    [Password] NVARCHAR(50) NOT NULL, 
    [LastLogin] DATETIME NULL, 
    [DisplayName] NVARCHAR(50) NOT NULL, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [Address] NVARCHAR(100) NULL, 
    [Telephone] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(50) NULL, 
    [UserCode] NVARCHAR(50) NOT NULL
)
