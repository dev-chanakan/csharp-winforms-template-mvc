if not exists (select * from dbo.Roles)
begin
	insert into dbo.Roles([Name], [Name_En]) VALUES ('ใบเสนอราคา', 'Quotations') 
	insert into dbo.Roles([Name], [Name_En]) VALUES ('ข้อมูลสินค้า', 'Product Info') 
	insert into dbo.Roles([Name], [Name_En]) VALUES ('ข้อมูลลูกค้า', 'Customer Info') 
	insert into dbo.Roles([Name], [Name_En]) VALUES ('ข้อมูลผู้ใช้ระบบ', 'User Info') 
	insert into dbo.Roles([Name], [Name_En]) VALUES ('ระบบรายงานผล', 'Reports') 
	insert into dbo.Roles([Name], [Name_En]) VALUES ('ข้อมูลพนักงาน', 'Employee Info') 
	insert into dbo.Roles([Name], [Name_En]) VALUES ('ตั้งค่าเอกสาร', 'Document Settings') 
end
