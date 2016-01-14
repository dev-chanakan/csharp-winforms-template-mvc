CREATE TABLE [dbo].[Brands]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [CreatedDate] DATETIME NULL, 
    [LastUpdatedDate] DATETIME NULL
)
