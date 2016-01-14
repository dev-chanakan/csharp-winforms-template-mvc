﻿/*
Deployment script for Liberty

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "Liberty"
:setvar DefaultFilePrefix "Liberty"
:setvar DefaultDataPath "c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\"
:setvar DefaultLogPath "c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Rename refactoring operation with key 32116aa9-cd86-400a-9041-42170c89baf5, 5b9cb4bb-9049-47dd-8fb9-95108580795c is skipped, element [dbo].[Quotations].[Employee] (SqlSimpleColumn) will not be renamed to EmployeeId';


GO
PRINT N'Rename refactoring operation with key 7e4a0b30-5524-495f-bbbd-9131eb6a05d8 is skipped, element [dbo].[Quotations].[IsVAT] (SqlSimpleColumn) will not be renamed to VAT';


GO
PRINT N'Rename refactoring operation with key 2de94b80-334c-47db-a0a3-b8e77328a250 is skipped, element [dbo].[Quotations].[ExpireDate] (SqlSimpleColumn) will not be renamed to ExpiredDate';


GO
PRINT N'Altering [dbo].[Customers]...';


GO
ALTER TABLE [dbo].[Customers] ALTER COLUMN [Email] NVARCHAR (50) NULL;


GO
PRINT N'Altering [dbo].[Employees]...';


GO
ALTER TABLE [dbo].[Employees]
    ADD [IsDeleted] BIT NULL;


GO
PRINT N'Creating [dbo].[Quotations]...';


GO
CREATE TABLE [dbo].[Quotations] (
    [Id]              INT              IDENTITY (1, 1) NOT NULL,
    [Code]            NVARCHAR (50)    NOT NULL,
    [Date]            DATETIME         NOT NULL,
    [Title]           TEXT             NOT NULL,
    [Credit]          NVARCHAR (50)    NULL,
    [BrandName]       NVARCHAR (50)    NOT NULL,
    [CustomerId]      INT              NOT NULL,
    [EmployeeId]      UNIQUEIDENTIFIER NOT NULL,
    [Revised]         BIT              NOT NULL,
    [VAT]             DECIMAL (18)     NULL,
    [Discount]        DECIMAL (18)     NULL,
    [ExpiredDate]     DATETIME         NOT NULL,
    [CreatedBy]       NVARCHAR (50)    NOT NULL,
    [CreatedDate]     DATETIME         NOT NULL,
    [LastUpdatedDate] DATETIME         NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating FK_Quotations_ToCustomers...';


GO
ALTER TABLE [dbo].[Quotations] WITH NOCHECK
    ADD CONSTRAINT [FK_Quotations_ToCustomers] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customers] ([Id]);


GO
PRINT N'Creating FK_Quotations_ToEmployees...';


GO
ALTER TABLE [dbo].[Quotations] WITH NOCHECK
    ADD CONSTRAINT [FK_Quotations_ToEmployees] FOREIGN KEY ([EmployeeId]) REFERENCES [dbo].[Employees] ([Id]);


GO
-- Refactoring step to update target server with deployed transaction logs
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '32116aa9-cd86-400a-9041-42170c89baf5')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('32116aa9-cd86-400a-9041-42170c89baf5')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '7e4a0b30-5524-495f-bbbd-9131eb6a05d8')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('7e4a0b30-5524-495f-bbbd-9131eb6a05d8')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '2de94b80-334c-47db-a0a3-b8e77328a250')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('2de94b80-334c-47db-a0a3-b8e77328a250')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '5b9cb4bb-9049-47dd-8fb9-95108580795c')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('5b9cb4bb-9049-47dd-8fb9-95108580795c')

GO

GO
/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
if not exists (select * from dbo.Departments)
begin
	insert into dbo.Departments(Name) VALUES ('พนักงานขาย') 
end
if not exists (select * from dbo.Roles)
begin
	insert into dbo.Roles([Name]) VALUES ('ใบเสนอราคา') 
	insert into dbo.Roles([Name]) VALUES ('ข้อมูลสินค้า') 
	insert into dbo.Roles([Name]) VALUES ('ข้อมูลลูกค้า') 
	insert into dbo.Roles([Name]) VALUES ('ข้อมูลผู้ใช้ระบบ') 
	insert into dbo.Roles([Name]) VALUES ('ระบบรายงานผล') 
	insert into dbo.Roles([Name]) VALUES ('ข้อมูลพนักงาน') 
	insert into dbo.Roles([Name]) VALUES ('ตั้งค่าเอกสาร') 
end

if not exists (select * from dbo.Users where Id = 'd1a89a7d-c79f-4388-a65b-0eae28e38031')
begin
	insert into dbo.Users([Id], [Username], [Password], [LastLogin], [DisplayName], [FirstName], [LastName], [Address], [Telephone], [Email], [UserCode]) 
	VALUES ('d1a89a7d-c79f-4388-a65b-0eae28e38031', 'admin', 'G3g/AJS/F10=', null, 'admin', 'admin', 'admin', null, null, null, 'AD001') 
end

if not exists (select * from dbo.UsersInRoles where UserId = 'd1a89a7d-c79f-4388-a65b-0eae28e38031')
begin
	insert into dbo.UsersInRoles([Id], [UserId], [RoleId]) 
	VALUES ('198ccbcc-01bc-4198-86c8-07b8507c456c', 'd1a89a7d-c79f-4388-a65b-0eae28e38031', (select top 1 Id from dbo.Roles where Name = N'ใบเสนอราคา'))
	insert into dbo.UsersInRoles([Id], [UserId], [RoleId]) 
	VALUES ('4ef93feb-e501-4edd-8fcc-115839b163f1', 'd1a89a7d-c79f-4388-a65b-0eae28e38031', (select top 1 Id from dbo.Roles where Name = N'ข้อมูลสินค้า')) 
	insert into dbo.UsersInRoles([Id], [UserId], [RoleId]) 
	VALUES ('1468d03f-af52-457c-80e0-2ad049f84c89', 'd1a89a7d-c79f-4388-a65b-0eae28e38031', (select top 1 Id from dbo.Roles where Name = N'ข้อมูลลูกค้า')) 
	insert into dbo.UsersInRoles([Id], [UserId], [RoleId]) 
	VALUES ('2a640368-1f86-40e6-8fba-332fb3bd42b3', 'd1a89a7d-c79f-4388-a65b-0eae28e38031', (select top 1 Id from dbo.Roles where Name = N'ข้อมูลผู้ใช้ระบบ')) 
	insert into dbo.UsersInRoles([Id], [UserId], [RoleId]) 
	VALUES ('ece9e3d3-5325-406d-9148-527c4e2d68b3', 'd1a89a7d-c79f-4388-a65b-0eae28e38031', (select top 1 Id from dbo.Roles where Name = N'ระบบรายงานผล')) 
	insert into dbo.UsersInRoles([Id], [UserId], [RoleId]) 
	VALUES ('265a2c9d-41e2-4323-ba89-9aec353ed29d', 'd1a89a7d-c79f-4388-a65b-0eae28e38031', (select top 1 Id from dbo.Roles where Name = N'ข้อมูลพนักงาน')) 
	insert into dbo.UsersInRoles([Id], [UserId], [RoleId]) 
	VALUES ('73324a41-81e3-4be9-9a7b-c68007e08af7', 'd1a89a7d-c79f-4388-a65b-0eae28e38031', (select top 1 Id from dbo.Roles where Name = N'ตั้งค่าเอกสาร')) 
end
GO

GO
PRINT N'Checking existing data against newly created constraints';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[Quotations] WITH CHECK CHECK CONSTRAINT [FK_Quotations_ToCustomers];

ALTER TABLE [dbo].[Quotations] WITH CHECK CHECK CONSTRAINT [FK_Quotations_ToEmployees];


GO
PRINT N'Update complete.';


GO