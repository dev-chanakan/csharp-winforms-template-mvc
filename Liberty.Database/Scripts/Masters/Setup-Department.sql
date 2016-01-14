if not exists (select * from dbo.Departments)
begin
	insert into dbo.Departments(Name) VALUES ('พนักงานขาย') 
end