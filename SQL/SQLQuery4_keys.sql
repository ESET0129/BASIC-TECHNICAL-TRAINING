use abc12
create table student(id int primary key, name varchar(10))
select * from student

insert into student values (2,'b',0123);

alter table student
add number int unique


create table techers(id int, names varchar(10), foreign key(id) references student(id))

insert into techers values(1, 'math')
select * from student
select * from techers

delete from techers where id=1
delete from student where id=1

insert into student values(3,'b',53465)

insert into techers values(3,'b')


