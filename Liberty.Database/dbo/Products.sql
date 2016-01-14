CREATE TABLE [dbo].[Products]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [BrandId] INT NOT NULL, 
    [ProductTypeId] INT NOT NULL, 
    [Name] NVARCHAR(128) NOT NULL, 
    [Price] DECIMAL NOT NULL, 
    [Quantity] DECIMAL NOT NULL, 
    [Description] NVARCHAR(MAX) NULL, 
    [CreatedDate] DATETIME NULL, 
    [LastUpdatedDate] DATETIME NULL, 
    CONSTRAINT [FK_Products_ToBrands] FOREIGN KEY ([BrandId]) REFERENCES [Brands]([Id]),
	CONSTRAINT [FK_Products_ToProductTypes] FOREIGN KEY ([ProductTypeId]) REFERENCES [ProductTypes]([Id])
)
