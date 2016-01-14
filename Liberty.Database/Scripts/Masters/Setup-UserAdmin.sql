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