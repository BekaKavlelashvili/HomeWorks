/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [PersonsID]
      ,[Lastname]
      ,[Firstname]
      ,[DoB]
      ,[PrivateId]
      ,[Email]
      ,[Phone]
      ,[WorkPlace]
      ,[Country]
      ,[City]
      ,[Salary]
      ,[PINcode]
  FROM [HomeWorkWeek15].[dbo].[Persons]

  
  --1
  select * from Persons
  select * from Persons where PrivateId like '161%'

  --2
  select * from Persons
  select * from Persons where LASTname = City

  --3
    select * from Persons
select * from persons where country in('canada', 'monaco')

--4  
 select * from Persons
 select firstname, lastname, privateId from persons where Email is null

 --5
 select * from Persons
 select * from persons where country in('spain', 'switzerland') and salary between 1000 and 3000


 --6  
  select * from Persons
  select workplace from persons where 
  WorkPlace like  '%llc%' 
  or WorkPlace like '%pc%' 
   or WorkPlace like '%llp%'


  --7
    select * from Persons		
	select
	email, iif((len(email)-len(replace(email, '.', ''))) > 2, 'more than 2 dots', 'less than 2 dots')
	as CountDots
	from persons 


     --8
    select * from Persons
	select * from persons where PINcode like '%51'

	 --9
    select * from Persons
	select country,  avg(salary) as avarageOfSalary from persons group by country 