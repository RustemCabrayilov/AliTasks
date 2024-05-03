
insert into Groups
Values ('D324','Dizainer'),('EL324','English'),('HR268','Human Resource')


insert into Students(Name,Surname,Address)
Values('Ekber','Elizade','Xirdalan')


Select * from Students  as st -- Aliases
Where st.Name = 'Ali'


Select * from Students
full join Groups
On Students.GroupID = Groups.Id


Select st.Name ,st.Surname,g.Name  from Students as st
inner join Groups as g
on  st.GroupID = g.Id



Select *  from Students as st
left join Groups as g
on  st.GroupID = g.Id
Where st.GroupID is not  null