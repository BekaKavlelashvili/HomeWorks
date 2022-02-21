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
join sales.Orders b on b.empid = a.empid where freight > 50 and a.title = 'sales manager'

--4
select a.orderdate, b.contactname, a.shipcity, a.shipaddress from sales.orders a
join sales.Customers b on a.custid = b.custid where year(orderdate)=2007 and b.country = 'usa'

--5 
select distinct a.shipcity, b.lastname from sales.orders a
join hr.Employees b on a.empid = b.empid where b.lastname = 'cameron'
 
 --6
 select sales.orders.orderid, sales.orders.shipcountry, sales.orders.shipcity from sales.orders
 where sales.orders.shipcountry in('german', 'austria')

 --7
 select * from  Production.Products a
 join sales.OrderDetails b on a.productid = b.productid
 join Production.Suppliers c on a.supplierid = c.supplierid 
 where c.city = 'tokyo'and b.discount > 0

 --8 
 select c.categoryname, a.productname  from Production.Products a
 join Production.Suppliers b on a.supplierid = b.supplierid 
 join production.Categories c on a.categoryid = c.categoryid
 where b.country = 'japan' and c.categoryname in('Beverages', 'seafood')
 
 --9
 select hr.firstname, hr.lastname, a.companyname from hr.Employees hr
 join sales.orders b on hr.empid = b.empid 
 join sales.Shippers a on b.shipperid = a.shipperid 
 where hr.firstname in('maria','sara') and  hr.lastname in('cameron','davis') 
 and b.shippeddate like '%2007%'

 --10 
 select b.productname, a.categoryname from Production.Categories a
 join Production.Products b on a.categoryid = b.categoryid 
 join Production.Suppliers c on c.supplierid = b.supplierid
 where c.country = 'usa'and a.categoryname <> 'Beverages' 
 and a.categoryname <> 'seafood'

 --11 
select b.orderid, a.lastname as employeeLastName, a.firstname as employeeFirstName, 
a.city as commonCity, c.contactname as customerName from hr.Employees a
join sales.orders b  on  b.empid = a.empid
join sales.Customers c on b.custid = c.custid
where c.city= a.city

--12
select distinct contactname from sales.orders a
join sales.Customers b on a.custid = b.custid
join sales.OrderDetails c on a.orderid = c.orderid
join Production.Products d on d.productid = c.productid
join Production.Categories e on e.categoryid = d.categoryid
where e.categoryname in('Beverages', 'dairy products')
