select * from Employee

SELECT * FROM Employee ORDER BY Salary;

Select first_name,last_name,salary,ROW_NUMBER()over (partition by sex order by salary desc)as popularity,
rank()over(partition by sex order by salary desc)as popularity_rank,
dense_rank()over(partition by sex order by salary desc)as popularity_dense_rank
 from EMPLOYEE

insert into Employee values (115,'ron','williams','1988-01-31','M',62000,NULL,NULL)




