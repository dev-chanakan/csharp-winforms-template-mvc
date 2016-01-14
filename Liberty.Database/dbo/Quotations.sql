CREATE TABLE [dbo].[Quotations]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Code] NVARCHAR(50) NOT NULL, 
    [Date] DATETIME NOT NULL, 
    [Title] NVARCHAR(MAX) NOT NULL, 
    [Credit] NVARCHAR(50) NULL, 
    [BrandName] NVARCHAR(50) NOT NULL, 
    [CustomerId] INT NOT NULL, 
    [EmployeeId] UNIQUEIDENTIFIER NOT NULL, 
    [Revised] BIT NOT NULL, 
    [VAT] DECIMAL NULL, 
    [Discount] DECIMAL NULL, 
    [CreatedByUserCode] NVARCHAR(50) NOT NULL, 
    [CreatedDate] DATETIME NOT NULL, 
    [LastUpdatedDate] DATETIME NULL, 
    CONSTRAINT [FK_Quotations_ToCustomers] FOREIGN KEY ([CustomerId]) REFERENCES [Customers]([Id]), 
    CONSTRAINT [FK_Quotations_ToEmployees] FOREIGN KEY ([EmployeeId]) REFERENCES [Employees]([Id])
)
