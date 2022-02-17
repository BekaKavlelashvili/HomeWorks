/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [ManufacturerId]
      ,[Name]
  FROM [Hardware].[dbo].[Manufacturers]
  use Hardware
  select * from dbo.Manufacturers
  select * from dbo.products
  ----------------------SUBQUERY--HARDWARE----------------
  --1
  select NAME, PRICE from dbo.products where manufacturerid in(
	select manufacturerid from dbo.Manufacturers where name = 'Hewlett-packard'
  )

  --2
  SELECT NAME, PRICE FROM dbo.products where manufacturerid in(
	select manufacturerid from dbo.Manufacturers where name<>'FUJITSU'
  )

  --3
    SELECT NAME, PRICE, manufacturerid FROM dbo.products where manufacturerid in(
	select  manufacturerid from dbo.Manufacturers where name IN( 'SONY', 'FUJITSU', 'IBM', 'INTEL')
  )

  --4
  SELECT NAME FROM dbo.Manufacturers WHERE MANUFACTURERID IN(
	SELECT MANUFACTURERID FROM dbo.products WHERE PRICE > 200
  )

  --5
  SELECT NAME, PRICE FROM dbo.products WHERE MANUFACTURERID IN(
	select MANUFACTURERID from dbo.Manufacturers where name <>'genius' and name<>'dell'
  )

  --6
  select count(name) from dbo.Manufacturers where MANUFACTURERID in(
	select MANUFACTURERID from dbo.products where name like '%drive%'
  )

  --7
  select count(name) from dbo.Products where price > (
	select avg(price) from dbo.Products ) and ManufacturerId in(
		select ManufacturerId from dbo.Manufacturers where NAME =  'INTEL'
	)
  

  

	
