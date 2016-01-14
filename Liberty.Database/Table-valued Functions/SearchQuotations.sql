CREATE FUNCTION [dbo].[SearchQuotations]
(
	@qtCode nvarchar(100) = null,
	@companyName nvarchar(255) = null,
	@saleCode nvarchar(50) = null,
	@startDate DateTime = null,
	@endDate DateTime = null
)
RETURNS TABLE
AS
RETURN
(
	select _quot.*, row_number() Over 
				(
					order by _quot.Date asc
				) as RowNumber	
	from [dbo].Quotations as _quot
	inner join dbo.Customers as _cust
	on _cust.Id = _quot.CustomerId
	inner join dbo.Employees as _emp
	on _emp.Id = _quot.EmployeeId
	where
	(
		(
			LOWER(_quot.Code) like LOWER(@qtCode) + '%'
		)		
		or
		(
			@qtCode is null
		)	
	)
	and 
	(
		(@startDate is null)
		or
		(_quot.Date >= @startDate)
	)
	and 
	(
		(@endDate is null)
		or
		(_quot.Date <= @endDate)
	)
	and 
	(
		(@companyName is null)
		or
		(_cust.CompanyName like @companyName + '%')
	)
	and 
	(
		(@saleCode is null)
		or
		(_emp.Code like @saleCode + '%')
	)
)
	
