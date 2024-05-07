CREATE TABLE EmpLog (
	LogID int IDENTITY(1,1) NOT NULL,
	EmpID int NOT NULL,
	Operation nvarchar(10) NOT NULL,
	UpdatedDate Datetime NOT NULL	
)

alter TRIGGER dbo.trgEmployeeDelete
ON dbo.Employees
for  Delete
AS
    INSERT INTO dbo.EmpLog(EmpID, Operation, UpdatedDate)
    SELECT EmployeeID ,'DELETE',GETDATE() FROM deleted


	Insert into Employees(LastName,FirstName)
	Values('Ali','Agayev')

	Select * from EmpLog

	Select * from Employees
	Update Employees
	Set LastName = 'Ageyev', FirstName = 'Ali'
	Where EmployeeID = 10

	DElete from Employees
	Where EmployeeID = 11


DECLARE @mySalary INT = 5000,
        @avgSalary int = 4000;

IF @mySalary > @avgSalary
	PRINT 'My Salary is above the average salary.';
ELSE
	PRINT 'My Salary is less than the average salary.';


	DECLARE @i INT = 10;
 
WHILE @i <= 30
	BEGIN
		PRINT (@i);
		SET @i = @i + 10;
	END;