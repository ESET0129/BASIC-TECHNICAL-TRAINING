create database bookstore

use bookstore
create table book(Id INT PRIMARY KEY IDENTITY(1,1), Name varchar(50) not null, Price int, CategoryId INT, AuthorId INT)
select * from book


CREATE TABLE Categories(Id INT PRIMARY KEY,Name VARCHAR (50) NOT NULL,)
select * from Categories

 

create table Authors(Id INT PRIMARY KEY,Name VARCHAR (50) NOT NULL,)
select * from Authors

 
INSERT INTO Categories VALUES (1, 'fiction'),(2, 'romance'),(3, 'self-help'),(7, 'biography'),(8, 'autobiography'),(4, 'history'),(10,'science'),(12,'innovation'),(6, 'magzine')

INSERT INTO Authors VALUES (1, 'A'),(2, 'B'),(3, 'C'),(10, 'D'),(12, 'E')

INSERT INTO Book VALUES ('Ramayan', 100, 1, 2),('Mahabharat', 200, 2, 2),('geeta', 150, 3, 2),('2 states', 100, 3,1),('how to read a book', 200, 3,1),('story of a monk', 150, 4,1),('Nazi', 100, 5,5),('mongols', 200, 5,6),('focus', 150, 7,8)


select * from book
select * from Categories
select * from Authors

/* inner join*/
SELECT Book.CategoryId, Book.Name, Categories.Id, Categories.Name
FROM Book
INNER JOIN Categories
ON Book.CategoryId = Categories.Id



