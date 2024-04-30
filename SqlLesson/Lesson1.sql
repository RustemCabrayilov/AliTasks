create table Students(
Id int Primary key Identity,
Name nvarchar(MAX) ,
Surname nvarchar(MAX) , 
Address nvarchar(MAX),
Age int,
)

--Alter table Students
--Add Primary key (Id)

Drop table Students


Insert into Students
Values 
('Nijat','Soltanov','Zabrat',20,'nijat123@gmail.com'),
('Ali','Agayev','Digah',17,'ali123@gmail.com')


Insert into Groups
Values
('PB501','Backend'),
('PB101','Backend'),
('PF502','Frontend')


Delete from Students
where Id = 3


Update Students
set Name = 'Ali',Surname = 'Agayev'
Where Id = 2


Delete from Students


/*
CRUD - Create Read Update Delete
Create - Insert into table adi
Read - Select * from table adi   ( * onu gosterirki biz butun fieldlerin datalarin istiyirik)
Update - Update 'table adi' set 'hansi fieldleri deyismek isteyirsen) sondada sert
Delete - Delete 'table adi' sondada sert

Eger Delete ve ya Update de sonda where isletmesen elediyimiz deyisiklikler butun datalara tesir edir

*/

Select * from Students


Drop database SirketIdareEtme


alter Table Students
add Email nvarchar(MAX)


alter Table Students
add abc nvarchar(MAX)

alter table Students
drop column abc


--alter table Students
--Rename column Name to FirstName  ---- Oracle

EXEC sp_rename 'Students.FirstName',  'Name', 'COLUMN';  --MSSql

Alter table Students
alter column Email nvarchar(255) not null



