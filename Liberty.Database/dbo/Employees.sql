CREATE TABLE [dbo].[Employees]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [Sex] NVARCHAR(10) NOT NULL, 
    [DepartmentId] INT NOT NULL, 
    [Code] NVARCHAR(50) NOT NULL, 
    [Telephone] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(50) NULL, 
    [CreatedDate] DATETIME NULL, 
    [LastUpdatedDate] DATETIME NULL, 
    [IsDeleted] BIT NULL, 
    CONSTRAINT [FK_Employees_ToDepartments] FOREIGN KEY ([DepartmentId]) REFERENCES [Departments]([Id])
)
