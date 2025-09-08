use abc12

create table employee(names char, emp_id int primary key, salary float, dept char);


SELECT * FROM employee;
insert into employee(names, emp_id, salary, dept)  values('a',1258,123000,'x'),('b',2856,234000,'y'),('c',3456,345000,'z'),('d',5455,535000,'u'),('e',6589,655000,'w');
/*
update salary *40/100 where years>3;
UPDATE emp SET salary = salary * 1.15 WHERE emp_id = 1;   
*/
/
update employee set salary = salary * 0.25 where names ='a';
delete from employee where salary>600000;

alter table employee
add address varchar(100)

alter table employee
alter column salary float

alter table employee
add contact varchar(10)

alter table employee
drop column address

exec sp_rename 'employee.contact', 'phone', 'column'