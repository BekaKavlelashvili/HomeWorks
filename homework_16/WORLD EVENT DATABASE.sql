
                ----------------- WORLD EVENTS---------------------
use WorldEvents
select * from dbo.Category
select * from dbo.Continent
select * from dbo.Event
select * from dbo.Country
select * from dbo.sysdiagrams

--1
select count(Eventname) from dbo.event where countryid in(
	select continentid from dbo.Continent where ContinentName = 'europe'
)

--2
select min(eventdate) as oldestEvent from dbo.event where countryid in(
	select continentid from dbo.Continent where continentname = 'africa'
)

--3
select count(countryname) from dbo.Country where continentid in(
SELECT ContinentID FROM DBO.Continent WHERE CONTINENTNAME IN('NORTH AMERICA', 'SOUTH AMERICA')
)


--4
SELECT count(EVENTDATE) FROM DBO.EVENT WHERE eventdate like '%12-31%' and CategoryID in(
	SELECT CategoryID FROM DBO.Category WHERE categoryname = 'economy'
)

--5
--sportze evropashi ar iyo msgavsi eventi da magito shevcvale tvalsachinoebistvis.
select max(eventdate) as latestEvent from dbo.event where categoryid in(	
	select categoryid from dbo.Category where categoryname = 'War and conflict' and countryid in(
		select continentid from dbo.continent where ContinentName = 'Antarctic'
	)
)
