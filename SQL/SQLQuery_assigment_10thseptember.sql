-- Creating the table part 1 of task 1
--  book order user table
CREATE TABLE usersss (
    user_id INT PRIMARY KEY,
    user_name VARCHAR(100) NOT NULL
);

CREATE TABLE booksss(
    book_id INT PRIMARY KEY,
    title VARCHAR(100) NOT NULL,
    price DECIMAL(10, 2) NOT NULL
);


CREATE TABLE ordersss (
    order_id INT PRIMARY KEY,
    user_id INT NOT NULL,
    book_id INT NOT NULL,
    order_date DATE NOT NULL,
    FOREIGN KEY (user_id) REFERENCES usersss(user_id),
    FOREIGN KEY (book_id) REFERENCES booksss(book_id)
);

INSERT INTO usersss (user_id, user_name) VALUES
(1, 'RAM'),
(2, 'Shyam'),
(3, 'ghanshayam');

INSERT INTO booksss (book_id, title, price) VALUES
(101, 'The Catcher in the Rye', 15.50),
(102, 'The Great Gatsby', 20.00),
(103, 'To Kill a Mockingbird', 18.75),
(104, '1984', 12.00)


INSERT INTO ordersss (order_id, user_id, book_id, order_date) VALUES
(3, 1, 102, '2023-01-20'), 
(7, 3, 101, '2023-03-01'), 
(8, 3, 104, '2023-03-05')

select * from ordersss

select * from booksss

select * from usersss

-- second part of task 1
-- row number
--rank

SELECT
        u.user_id,
        u.user_name,
        b.book_id,
        b.title,
        b.price,
        o.order_date,
        ROW_NUMBER() OVER (PARTITION BY u.user_id ORDER BY b.price DESC) AS rn,
        RANK() OVER (PARTITION BY u.user_id ORDER BY b.price DESC) AS rnk,
        DENSE_RANK() OVER (PARTITION BY u.user_id ORDER BY b.price DESC) AS drnk
    FROM
        usersss u
    JOIN
        ordersss o ON u.user_id = o.user_id
    JOIN
        booksss b ON o.book_id = b.book_id
	ORDER BY
    user_id, price DESC;

-- ASSIGNMENT 2
--user spent in total
--Sum(price)
--PARTITION BY user id

WITH UserSpending AS (
    SELECT
        u.user_id,
        u.user_name,
        SUM(b.price) AS total_spending,
        RANK() OVER (ORDER BY SUM(b.price) DESC) AS rnk,
        DENSE_RANK() OVER (ORDER BY SUM(b.price) DESC) AS drnk
    FROM
        usersss u
    JOIN
        ordersss o ON u.user_id = o.user_id
    JOIN
        booksss b ON o.book_id = b.book_id
    GROUP BY
        u.user_id, u.user_name
)
SELECT
    user_id,
    user_name,
    total_spending,
    rnk,
    drnk
FROM
    UserSpending
ORDER BY
    total_spending DESC;


