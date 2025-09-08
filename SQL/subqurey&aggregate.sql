use abc12

create table employee1(names varchar(20), emp_id int primary key, salary float, branch char);


SELECT * FROM employee1;
insert into employee1(names, emp_id, salary, branch)  values('a',1258,123000,'x'),('b',2856,234000,'y'),('c',3456,345000,'z'),('d',5455,535000,'u'),('e',6589,655000,'w');
select * from employee1 where emp_id = 1258
select * from employee1 where emp_id != 1258

select * from employee1 where emp_id <3456

select * from employee1 where emp_id <3456

select * from employee1 where emp_id is null

select * from employee1 where emp_id is not null

select * from employee1 where names like'd%'

select * from employee1 where names like'd%e'

/* sub query */
select * from employee
select branch_id from branch where branch_name='corporate'

select * from branch where branch_name='corporate'

/*sql aggregate function

min()
max()
sum() avg() count()
*/

select * from employee where salary between 25000 and 50000
select MAX(salary) from employee

select MAX(salary) as max_sal from employee

select COUNT(*) from employee 
select COUNT(*) from employee where salary between 25000 and 50000

/*
Ascending and descending


*/
select * from employee order by emp_id

select * from employee order by salary 

select * from employee order by salary desc
select * from employee order by first_name desc







