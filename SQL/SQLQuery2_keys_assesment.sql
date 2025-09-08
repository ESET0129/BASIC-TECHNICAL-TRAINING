use abc12

create table users(users_id int primary key, email varchar(10) unique, names varchar(10))
select * from users

insert into users values (2,'a@bc','b'),(3,'b@cd','c'),(4,'c@de','d'),(5,'d@ef','e');




create table book(product_id int primary key, title varchar(10) unique, price float)
select * from book

insert into book values (10,'z',25.56),((15,'y',200),(20,'x',155.6),(30,'w',26);


create table orders(order_no int primary key,users_id int,product_id int,foreign key (users_id) references users(users_id),foreign key(product_id) references book(product_id))
/*
foreign key(product_id) references book(product_id)
*/
select * from users
select * from book

select * from orders



/*
alter table student
add number int unique


create table techers(id int, names varchar(10), foreign key(id) references student(id), )

insert into techers values(1, 'math')
select * from student
select * from techers

delete from techers where id=1
delete from student where id=1

insert into student values(3,'b',53465)

insert into techers values(3,'b')

*/
