USE emp;

/*Create users table*/
CREATE TABLE users (users_id INT PRIMARY KEY,email VARCHAR(50),names VARCHAR(50));

-- Insert sample users
INSERT INTO users VALUES (5, 'mano@money.com', 'Mano');
INSERT INTO users VALUES (7, 'namaZ@gmail.com', 'Shreyansh');

-- Create books table
CREATE TABLE books (product_id INT PRIMARY KEYtitle VARCHAR(50)price INT);

-- Insert sample book
INSERT INTO books VALUES (15, 'Manusmrithi', 50);
INSERT INTO books VALUES (16, 'How to quit smoking?', 6000);
INSERT INTO books VALUES (17, 'Bhagwat Gita', 1800);

-- Create orders table with foreign keys
CREATE TABLE orders (
    order_no INT PRIMARY KEY,
    users_id INT,
    product_id INT,
    FOREIGN KEY(users_id) REFERENCES users(users_id),
    FOREIGN KEY(product_id) REFERENCES books(product_id)
); 

-- Insert valid orders (product_id must exist in books, users_id must exist in users)
INSERT INTO orders VALUES (102, 1, 13);
INSERT INTO orders VALUES (104, 6, 16);
INSERT INTO orders VALUES (105, 5, 15);
INSERT INTO orders VALUES (106, 7, 17);

-- Check all tables
SELECT * FROM books;
SELECT * FROM users;
SELECT * FROM orders;

----------------------------------------------------------
-- Employee table queries
----------------------------------------------------------

-- View Employee table details
EXEC sp_help Employee;

-- Employees with ID <= 3
SELECT * FROM Employee WHERE emp_ID <= 3;

-- Employees with non-null salary
SELECT * FROM Employee WHERE salary IS NOT NULL;

-- Employees where name contains 'h' but not ending with 'h'
SELECT * FROM Employee WHERE emp_name LIKE '%h%' AND emp_name NOT LIKE '%h';

-- Employee(s) with max salary
SELECT * FROM Employee 
WHERE salary = (SELECT MAX(salary) FROM Employee);

-- Employees with salary between 150000 and 300000
SELECT * FROM Employee 
WHERE salary IN (SELECT salary FROM Employee WHERE salary BETWEEN 150000 AND 300000);

-- Maximum salary
SELECT MAX(salary) AS max_salary FROM Employee;

-- Count of employees with salary = 100000
SELECT COUNT(*) AS employee_with_one_lakh FROM Employee WHERE salary = 100000;

-- Order employees by salary (descending)
SELECT * FROM Employee ORDER BY salary DESC;


--------------------------------------------------
select * from users as A
select * from orders as B
select * from books as C
select * from users A INNER JOIN orders B on A.users_id = B.users_id
select * from users A FULL OUTER JOIN orders B on A.users_id = B.users_id
select * from users A LEFT JOIN orders B on A.users_id = B.users_id
select * from users A RIGHT JOIN orders B on A.users_id = B.users_id
select * from users A CROSS JOIN orders B
select * from users A INNER JOIN orders B on A.users_id = B.users_id INNER JOIN books C on B.product_id = C.product_id where C.price =1500
select * from users A INNER JOIN orders B on A.users_id = B.users_id FULL OUTER JOIN books C on B.product_id = C.product_id where C.price =1500
select * from users A LEFT JOIN orders B on A.users_id = B.users_id RIGHT JOIN books C on B.product_id = C.product_id where C.price =1500