/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [n]
  FROM [TSQL2012].[dbo].[Nums]

  use TSQL2012
  select * from dbo.Nums
  select * from hr.Employees
  select * from Production.Categories
  select * from Production.Products
  select * from Production.suppliers
  select * from sales.Customers
  select * from sales.OrderDetails
  select * from sales.orders
  select * from sales.Shippers
  select * from stats.Scores
  select * from stats.tests

--1 
select a.contactname, b.orderdate, a.city from sales.Customers a
join  sales.orders b on a.custid = b.custid and city in('london', 'madrid')

--2
select upper(a.productname) as productName, a.unitprice, b.categoryname from Production.Products a
join Production.Categories b on a.categoryid =  b.categoryid where unitprice between 20 and 40

--3
select a.lastname, a.firstname, b.orderid from hr.Employees a
join sales.Orders b on b.custid = a.empid where freight > 50

--4
select b.orderdate, a.contactname, a.city, a.address from Production.suppliers a
join sales.orders b on a.supplierid = b.custid where orderdate like '%2007%' and a.country = 'usa'

--5 
select distinct a.shipcity, b.lastname from sales.orders a
join hr.Employees b on a.custid = b.empid where b.lastname = 'cameron'
 
 --6
 select sales.orders.orderid, sales.orders.shipcountry, sales.orders.shipcity from sales.orders
 where sales.orders.shipcountry in('german', 'austria')

 --7
 select * from  Production.Products a
 join Production.Suppliers b on a.supplierid = b.supplierid where city= 'tokyo'and discontinued = 1

 --8 
 select a.categoryname, a.description  from Production.Categories a
 join Production.Suppliers b on a.categoryid = b.supplierid where country = 'japan'
 
 --9
 select hr.firstname, hr.lastname, a.companyname from hr.Employees hr
 join sales.shippers a on hr.empid = a.shipperid 
 join sales.orders b on hr.empid = b.custid 
 where hr.firstname in('maria','sara') and  hr.lastname in('cameron','davis') 
 and b.shippeddate like '%2007%'

 --10
 select c.productname, a.categoryname from Production.Categories a
 join Production.Suppliers b on a.categoryid = b.supplierid 
 join Production.Products c on c.categoryid = a.categoryid
 where b.country = 'usa'and a.categoryname <> 'Beverages' 
 and a.categoryname <> 'seafood'

 --11 
 select c.orderid, a.firstname, a.lastname, a.city,
 b.contactname from hr.Employees a
 join sales.Customers b on  a.empid = b.custid 
join sales.orders c on a.empid = c.custid 
where a.city = b.city

--12
select distinct a.contactname, b.categoryname from sales.Customers a
join Production.Categories b on a.custid = b.categoryid 
where b.categoryname in('beverages','dairy products')