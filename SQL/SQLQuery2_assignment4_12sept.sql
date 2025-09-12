

CREATE TABLE Students2024 (ID INT, Name VARCHAR(50));
CREATE TABLE Students2025 (ID INT, Name VARCHAR(50));
INSERT INTO Students2024 VALUES
(1,'Ravi'),(2,'Asha'),(3,'John'),(4,'Meera'),(5,'Kiran'),
(6,'Divya'),(7,'Lokesh'),(8,'Anita'),(9,'Rahul'),(10,'Sneha');

INSERT INTO Students2025 VALUES
(2,'Asha'),(4,'Meera'),(5,'Kiran'),(11,'Prakash'),(12,'Vidya'),
(13,'Neha'),(14,'Manoj'),(15,'Ramesh'),(16,'Lata'),(17,'Akash');

CREATE TABLE Employees (EmpID INT, Name VARCHAR(50), Department VARCHAR(20));

INSERT INTO Employees VALUES 
(1,'Ananya','HR'),(2,'Ravi','IT'),(3,'Meera','Finance'),
(4,'John','IT'),(5,'Divya','Marketing'),(6,'Sneha','Finance'),
(7,'Lokesh','HR'),(8,'Asha','IT'),(9,'Kiran','Finance'),(10,'Rahul','Sales');


CREATE TABLE Projects (ProjectID INT, Name VARCHAR(50), StartDate DATE, EndDate DATE);
INSERT INTO Projects VALUES 
(1,'Bank App','2025-01-01','2025-03-15'),
(2,'E-Commerce','2025-02-10','2025-05-20');





CREATE TABLE Contacts (ID INT, Name VARCHAR(50), Email VARCHAR(50), Phone VARCHAR(20));
INSERT INTO Contacts VALUES
(1,'Ravi','ravi@gmail.com',NULL),
(2,'Asha',NULL,'9876543210'),
(3,'John',NULL,NULL);

--task 1
--union
--unique
SELECT DISTINCT Name FROM Students2024;
SELECT DISTINCT Name FROM Students2025;
--duplicate
SELECT Name FROM Students2024;

--Display employee names in UPPERCASE and LOWERCASE.
SELECT Name, UPPER(Name) AS UpperCaseName, LOWER(Name) AS LowerCaseName
FROM Employees;

--Find the length of each employee’s name.
SELECT Name, LEN(Name) AS NameLength
FROM Employees;

--Show only the first 3 letters of each name.
SELECT Name, LEFT(Name, 3) AS FirstThreeLetters, RIGHT(Name, 3) AS LastThreeLetters
FROM Employees;

--Replace Finance department with Accounts.
UPDATE Employees
SET Department = 'Accounts'
WHERE Department = 'Finance';

--Create a new column showing "Name - Department" using CONCAT.
SELECT Name,Department,CONCAT(Name, ' - ', Department) AS NameAndDepartment
FROM Employees;

--Show today’s date using GETDATE().

SELECT GETDATE() AS TodayDate;

--Find the duration (in days) of each project using DATEDIFF.

SELECT Name, DATEDIFF(day, StartDate, EndDate) AS ProjectDurationDays
FROM Projects;
--Add 10 days to each project’s EndDate using DATEADD.

SELECT Name,EndDate,DATEADD(day, 10, EndDate) AS NewEndDate
FROM Projects;

--Find how many days are left until each project ends. (Hint: Use DATEDIFF with GETDATE())

SELECT Name, DATEDIFF(day, GETDATE(), EndDate) AS DaysRemaining
FROM Projects;
-- Add 10 days to each project’s EndDate

--Convert today’s date into DD/MM/YYYY format using CONVERT.

SELECT CONVERT(varchar, GETDATE(), 103) AS FormattedDate;
--Convert a float 123.456 into an integer using CAST.

SELECT CAST(123.456 AS int) AS ConvertedInteger;
--For employees (from Employees table above), categorize them:
--If Dept = IT → show Tech Team
--If Dept = HR → show Human Resources
---Else → Other

SELECT Name,Department,
CASE WHEN Department = 'IT' 
	THEN 'Tech Team' 
	WHEN Department = 'HR' 
	THEN 'Human Resources'
    ELSE 'Other'
    END AS DepartmentCategory FROM Employees;













