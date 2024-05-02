Update Categories
Set CategoryName = 'Seafood'
Where CategoryID=8

Delete from Categories
Where CategoryID = 9

Select * from Customers

Select CustomerID,ContactName,Address from Customers


Select distinct City from Customers



Select * from Customers
Where ContactTitle ='Owner'

Select * from Customers
Where Country = 'Germany' and ContactTitle = 'Sales Representative' 


Select * from Customers
Where City = 'Berlin' or City ='Madrid'

Select * from Products
Where UnitPrice <100


Select * from Products
Where UnitPrice >50 and UnitPrice<100

Select * from Products
Where (UnitPrice between 50 and 100 ) and CategoryID > 6
Order by UnitPrice


Select * from Products
Order by UnitPrice 

Select * from Products
Order by UnitPrice desc


Select * from Customers
Order by ContactName


Select * from Products
Order by UnitPrice,UnitsInStock


Select * from Suppliers
Where  Country !='USA'

Select * from Suppliers
Where not Country ='USA'

Select * from Products 
Where UnitPrice <> 22

Select * from Customers
Where ContactTitle like '%Sales%'

Select * from Customers
Where Country like 'A%'

Select * from Customers
Where Country like '%A'

Select * from Customers
Where Country like 'F__land'

Select * from Customers
Where City like 'P_ris'

Select * from Customers
Where ContactName like '[pra]%' 
 
Select * from Customers
Where ContactName like '[a-c]%' 

Select * from Customers
Where City not in ('berlin','london')


Select * from Customers
where ContactName = 'Ali Agayev'

Insert into Customers
Values('COAC','Code Academy','Ali Agayev','Marketing Manager','Digah','Baku','Null',
'72830','Azerbaijan','212 12 12','212 12 12')

Update Customers
Set Region = null
Where CustomerID = 'COAC'

Select * from Customers
Where Region is not null


Select Top 10 * from Customers 


Select * from Products
Order by UnitPrice
OFFSET 10 ROWS FETCH FIRST 5 ROWS ONLY


/*SQL Aggregate Functions
SQL Min and Max
SQL Count
SQL Sum
SQL Avg */

Select Max(UnitPrice) as 'En bahali mal' from Products

Select Min(UnitPrice) as 'En ucuz mal' from Products


Select Top 1 * from Products
Order by UnitPrice desc


Select Top 1 * from Products
Order by UnitPrice 

Select Sum(UnitsInStock) from Products --Stockda olan umumi mallarin sayi

Select Count(*) from Employees

Select Avg(UnitPrice) from Products
