-- Create books table
create table books (
    id INT PRIMARY KEY,
    title VARCHAR(50),
    author VARCHAR(50),
    isbn VARCHAR(20) UNIQUE,
    published_date DATETIME
);
 
-- Insert data into books table
insert into books values
    (1, 'My First SQL book', 'Mary Parker', '981483029127', '2012-02-22 12:08:17'),
    (2, 'My Second SQL book', 'John Mayer', '857300923713', '1972-07-03 09:22:45'),
    (3, 'My Third SQL book', 'Cary Flint', '523120967812', '2015-10-18 14:05:44');
 
 select * from books;

-- Create reviews table
create table reviews (
    id INT PRIMARY KEY,
    book_id INT,
    reviewer_name VARCHAR(50),
    content VARCHAR(255),
    rating INT,
    published_date DATETIME,
    FOREIGN KEY (book_id) REFERENCES books(id)
);
 
-- Insert data into reviews table
insert into reviews values
    (1, 1, 'John Smith', 'My first review', 4, '2017-12-10 05:50:11.1'),
    (2, 2, 'John Smith', 'My second review', 5, '2017-10-13 15:05:12.6'),
    (3, 2, 'Alice Walker', 'Another review', 1, '2017-10-22 23:47:10');
 
 select * from reviews


--Fetch details of the books written by authors whose name ends with "er"
select * from books where author LIKE '%er';

--Display the Title, Author, and ReviewerName for all the books
select b.title, b.author, r.reviewer_name
from books b
JOIN reviews r on b.id = r.book_id;

--Display the reviewer name who reviewed more than one book
select reviewer_name from reviews
group by reviewer_name
having COUNT(DISTINCT book_id) > 1;
 

--create table Customer 
create table Customer (
    id INT PRIMARY KEY,
    name VARCHAR(50),
	age INT,
    address VARCHAR(100),
    salary FLOAT
)
 
 --insert data into Customer table
insert into Customer values 
    (1, 'RAMESH', 32,'AHMEDABAD', 2000.00),
    (2, 'KHILAN', 25, 'DELHI', 1500.00),
    (3, 'KAUSHIK', 23,'KOTA', 2000.00),
	(4,'CHAITALI',25,'MUMBAI',6500.00),
	(5,'HARDIK',27,'BHOPAL',8500.00),
	(6,'KOMAL',22,'MP',4500.00),
	(7,'MUFFY',24,'INDORE',10000.00)
 
select * from Customer
 
--Display the Name for the customer from above customer table  who live in same address which has character o anywhere in address
select name
from Customer
where address LIKE '%o%'
 
create table Orders (
    O_ID INT PRIMARY KEY,
    O_DATE DATETIME,
    CUSTOMER_ID INT,
    AMOUNT FLOAT,
   )
 
insert into Orders values 
	   (102, '2009-10-08 00:00:00', 3, 3000),
       (100, '2009-10-08 00:00:00', 3, 1500),
       (101, '2008-05-20 00:00:00',2, 1560),
	   (103, '2008-05-20 00:00:00',4, 2060);
 
 select * from Orders


--Write a query to display the   Date,Total no of customer  placed order on same Date
select o_date, COUNT(DISTINCT customer_id) as TotalCustomers
from ORDERS
group by o_date
 
 
create table Employee (
    id INT PRIMARY KEY,
    name VARCHAR(50),
	age INT,
    address VARCHAR(100),
    salary FLOAT
)
 
 
insert into Employee values 
    (1, 'RAMESH', 32, 'AHMEDABAD',  2000.00),
    (2, 'KHILAN', 25, 'DELHI', 1500.00),
    (3, 'KAUSHIK', 23, 'KOTA', 2000.00),
	(4,'CHAITALI',25,'MUMBAI',6500.00),
	(5,'HARDIK',27,'BHOPAL',8500.00),
	(6,'KOMAL',22,'MP',NULL),
	(7,'MUFFY',24,'INDORE',NULL)
 
 select * from Employee
 
--Display the Names of the Employee in lower case, whose salary is null 
select LOWER(name) as LowercaseName
from Employee
where salary IS NULL
 
 
 
create table Students (
    reg INT PRIMARY KEY,
    name VARCHAR(100),
    age INT,
    qualification VARCHAR(100),
    mobile_no VARCHAR(15),
    mail_id VARCHAR(100),
    location VARCHAR(255),
    gender CHAR(1)
)
 
 
insert into Students values 
    (2, 'SAI', 22, 'BE', '9952836777', 'SAI@GMAIL.COM', 'CHENNAI', 'M'),
    (3, 'KUMAR', 20, 'BSC', '7890125648', 'KUMAR@GMAIL.COM', 'MADURAI', 'M'),
    (4, 'SELVI',  22, 'B  TECH', '8904567342', 'SELVI@GMAIL.COM', 'SELAM', 'F'),
	(5, 'NISHA',  25, 'ME', '7834672310', 'NISHA@GMAIL.COM', 'THENI', 'F'),
    (6, 'SAISARAN',  21, 'BA', '7890345678', 'SARAN@GMAIL.COM', 'MADURAI', 'F'),
    (7, 'TOM',  23, 'BCA', '8901234675', 'TOM@GMAIL.COM', 'PUNE', 'M');
 
 select * from Students

--Write a sql server query to display the Gender,Total no of male and female from the above relation.
 
select gender, COUNT(*) as TotalEmployees
from Students
group by gender



