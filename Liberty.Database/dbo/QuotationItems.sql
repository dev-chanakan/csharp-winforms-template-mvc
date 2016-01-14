CREATE TABLE [dbo].[QuotationItems]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [QuotationId] INT NOT NULL, 
    [ProductName] NVARCHAR(MAX) NOT NULL, 
    [Description] NVARCHAR(MAX) NULL, 
    [OfferPrice] DECIMAL NOT NULL, 
    [OfferQuantity] DECIMAL NOT NULL, 
    [ProductTypeId] INT NOT NULL, 
    [ImagePath] NVARCHAR(MAX) NULL, 
    CONSTRAINT [FK_QuotationItems_ToQuotations] FOREIGN KEY ([QuotationId]) REFERENCES [Quotations]([Id]) on delete Cascade
)
