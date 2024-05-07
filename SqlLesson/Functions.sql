select* from Products


create function GetProductStockByCategoryId(@CategoryId int)
returns int
as 
Begin
Declare @sum int = 0;
Select @sum = Sum(UnitsInStock) from Products
Where CategoryID = @CategoryId
return @sum
End

Select dbo.GetProductStockByCategoryId(2) as 'Stock Count'

print  dbo.GetProductStockByCategoryId(2)


Select Sum(UnitsInStock) from Products
Where CategoryID = 2


Select * from Customers

create function  GetCustomersByCountryName(@CountryName nvarchar(15))
returns table
as
return Select * from Customers
Where Country = @CountryName


Select * from  GetCustomersByCountryName('Germany')
