/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [StudentsID]
      ,[Lastname]
      ,[Firstname]
      ,[DoB]
      ,[Email]
      ,[Quiz1]
      ,[Quiz2]
      ,[MiddleTest]
      ,[FinalTest]
      ,[Country]
  FROM [HomeWorkWeek15].[dbo].[Students]


  --1 Students 
select * from Students where DoB > '1990'

--2 rame sxvaa mosafiqrebeli
select * from Students
declare @currentDate date = sysDatetime()

select  LastName, Firstname, DATEDIFF(year, dob, getdate()) as Age from Students where Country in('Georgia', 'Libya') 


--3
insert into Students 
(Lastname, Firstname, DoB, Email, Quiz1, Quiz2, MiddleTest, FinalTest, Country)
values
('Zorbuchela','Zorba', '2003-11-08', 'zorba@test.com', 9, 5, 30, 30, 'Georgia')

--4
select * from Students
select top 5 with ties firstname, MiddleTest from Students order by MiddleTest desc


--5
select * from Students
delete from Students where finaltest=19

--6
select * from Students
select 
case
	when MiddleTest = 1 then '0'
	else 'NO RULE FOR THIS ITEM'
end as ChangedScore
from Students	

