
                ----------------- WORLD EVENTS---------------------
use WorldEvents
select * from dbo.Category
select * from dbo.Continent
select * from dbo.Event
select * from dbo.Country
select * from dbo.sysdiagrams

--1
select count(Eventname) from dbo.event where countryid in(
	select CountryID from dbo.country where ContinentID in(
		select ContinentID from Continent where ContinentName = 'europe'
	)
)

--2
select min(eventdate) as oldestEvent from dbo.event where countryid in(
	select CountryID from dbo.Country where ContinentID in(
		select ContinentID from Continent where continentname = 'africa'
		)
) 

--3
select count(countryname) from dbo.Country where continentid in(

SELECT ContinentID FROM DBO.Continent WHERE CONTINENTNAME IN('NORTH AMERICA', 'SOUTH AMERICA')
)


--4
SELECT count(EVENTDATE) FROM DBO.EVENT WHERE month(eventdate)=1 and day(EventDate) = 1 and CategoryID in(
	SELECT CategoryID FROM DBO.Category WHERE categoryname = 'economy'
)

--5

select *,
(select countryname from Country where CountryID=Event.CountryID) 

from Event where CategoryID in
(
select CategoryID from Category where CategoryName='Sports'
)
and 
CountryID in (
SELECT CountryID  
FROM Country where ContinentID in 
(
SELECT ContinentID  
FROM Continent where ContinentName = 'Europe'
)
)
order by EventDate desc
