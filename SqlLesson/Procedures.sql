
--Create view GStartedProducts as 
--Select * from Products
--Where ProductName like 'g%'


Select * from GStartedProducts


Create view BrUSACustomers as
Select * from Customers
Where Country = 'Brazil' or Country = 'USA'


select * from BrUSACustomers
Order by ContactName

select * from [Product Sales for 1997]


Select distinct City from Customers


Select Country from Customers
Union
Select Country from Employees


select * from Products


Alter Procedure RangeProducts(
  @BeginVal float ,
  @LastValue float 
)
As 
Begin 
Select * from Products
Where UnitPrice > @BeginVal and UnitPrice < @LastValue
Order by UnitPrice

End;


Create Procedure RangeProductsStock(
  @BeginVal float ,
  @LastValue float ,
  @CountStock int out
)
As 
Begin 
Select @CountStock = SUM(UnitsInStock) from Products
Where UnitPrice > @BeginVal and UnitPrice < @LastValue
End;


declare @Count int;

Exec RangeProductsStock
   @BeginVal = 15,
   @LastValue = 55,
   @CountStock = @Count out



   print @Count;

   Select @Count as 'Stock Count';
   