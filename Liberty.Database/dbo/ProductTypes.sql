CREATE TABLE [dbo].[ProductTypes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [UnitName] NVARCHAR(50) NOT NULL, 
    [CreatedDate] DATETIME NULL, 
    [LastUpdatedDate] DATETIME NULL
)
