create database smart_meter
use smart_meter
--customer table
create table customers(
customerID int primary key,
name varchar(50),
address varchar(100),
region varchar(50)
);

Insert into customers values (1,'ram','gali no 21,main road patna','north-east'),
(2,'shyam','gali no 1, pune','west'),(3,'ghanshyam','house no 21,delhi','central'),
(4,'rangaram','bijpur colony,banglore','south')

--smart meterreading
create table SmartMeterReading(
meterID int,
customerID int,
location varchar(50),
installeddate DATE,
readingdatetime DATETIME,
energyconsumed float,
PRIMARY KEY(meterID, readingdatetime),
FOREIGN KEY(customerID) REFERENCES customers(customerID)
);

Insert into SmartMeterReading values (11,1,'rooftop','2024-10-10','2024-11-11 12:10:54',20.56),
(12,2,'rooftop','2024-05-15','2024-06-18 18:50:10',15.5),
(13,3,'basement','2024-01-20','2024-03-10 09:50:15',55.89),
(14,4,'basement','2024-12-01','2025-03-05 10:45:15',65.6)

select * from customers
select * from SmartMeterReading 

--task 1
--fetch and energyconsumed between 10 and 50 kwh
--reading date time between 01-01-2024 & 31-12-2024

select meterID, readingdatetime, energyconsumed from SmartMeterReading
where energyconsumed BETWEEN 10 AND 50
AND readingdatetime BETWEEN '2024-01-01' AND '2024-12-31' AND installeddate <= '2024-06-10'


-- task 2
-- average consumption
-- max consumption

select customerID,AVG(energyconsumed) AS Avgenergyconsumed,
MAX(energyconsumed) AS Maxenergyconsumed from SmartMeterReading
where YEAR(readingdatetime) = YEAR(GETDATE())
GROUP BY customerID


--task 3 "strech goals"
-- total energy consumed during peak hours
--no. of reading
--installed before 01-01-2025


with readymeters as (
select meterID from SmartMeterReading where
installeddate < '2025-01-01'
--GROUP BY meterID having COUNT (*)> 10
)
select r.meterID,
SUM(r.energyconsumed) AS totalenergypeakhours,
COUNT(*) AS numreadings
from SmartMeterReading r
inner join readymeters rm on r.meterID = rm.meterID

where YEAR(r.readingdatetime) = YEAR(GETDATE())
  AND CAST(r.readingdatetime as TIME) BETWEEN '18:00'AND'22:00'
GROUP BY r.meterID

