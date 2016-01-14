CREATE TABLE [dbo].[Customers]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CompanyName] TEXT NOT NULL, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Carbon_Copy_Name] TEXT NULL, 
    [Email] NVARCHAR(50) NULL, 
    [Carbon_Copy_Email] TEXT NULL, 
    [Telephone] NVARCHAR(50) NULL, 
    [Fax] NVARCHAR(50) NULL, 
    [CreatedDate] DATETIME NULL, 
    [LastUpdatedDate] DATETIME NULL
)
