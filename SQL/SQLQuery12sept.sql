create table employee3 (emp_id int,name varchar(50),dept_id varchar(10),salary float)
insert into employee3 values (1,'shyam','it',15000)
insert into employee3 values (2,'ram','hr',5000),(3,'ghanshyam','management',25000),(4,'gopal','marketting',15000),(5,'radhemohan','sales',5000)

select * from employee3

--unnion And unionALL

--uppercase nd lower case
select UPPER ('employee3') AS UpperCase;
select UPPER ('sql server') from employee3;

select LOWER ('employee3') AS LowerCase;
--length
select len('employee3') from employee3
--substring and Reverse
SELECT SUBSTRING('employee3', 1, 3) as ExactString;

SELECT REVERSE('employee3') as ExactString;

--Replace

SELECT REPLACE('ram works with shyam', 'shyam', 'ghanshyam')as shyam;

--concate

select concat ('ram',' ','like tea') as addict;

-- cast
select cast (emp_id as float) from employee as ID

select GETDATE()















