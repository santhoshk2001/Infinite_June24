use AssessmentDB

create table EMP (
    EMPNO INT PRIMARY KEY,
    ENAME VARCHAR(20),
    JOB VARCHAR(20),
    MGR_ID INT,
    HIREDATE DATE,
    SAL DECIMAL(7, 2),
    COMM DECIMAL(7, 2),
    DEPTNO INT,
    FOREIGN KEY (DEPTNO) REFERENCES DEPT(DEPTNO)
);

-- Insert data into EMP
insert into EMP values
(7369, 'SMITH', 'CLERK', 7902, '1980-12-17', 800, NULL, 20),
(7499, 'ALLEN', 'SALESMAN', 7698, '1981-02-20', 1600, 300, 30),
(7521, 'WARD', 'SALESMAN', 7698, '1981-02-22', 1250, 500, 30),
(7566, 'JONES', 'MANAGER', 7839, '1981-04-02', 2975, NULL, 20),
(7654, 'MARTIN', 'SALESMAN', 7698, '1981-09-28', 1250, 1400, 30),
(7698, 'BLAKE', 'MANAGER', 7839, '1981-05-01', 2850, NULL, 30),
(7782, 'CLARK', 'MANAGER', 7839, '1981-06-09', 2450, NULL, 10),
(7788, 'SCOTT', 'ANALYST', 7566, '1987-04-19', 3000, NULL, 20),
(7839, 'KING', 'PRESIDENT', NULL, '1981-11-17', 5000, NULL, 10),
(7844, 'TURNER', 'SALESMAN', 7698, '1981-09-08', 1500, 0, 30),
(7876, 'ADAMS', 'CLERK', 7788, '1987-05-23', 1100, NULL, 20),
(7900, 'JAMES', 'CLERK', 7698, '1981-12-03', 950, NULL, 30),
(7902, 'FORD', 'ANALYST', 7566, '1981-12-03', 3000, NULL, 20),
(7934, 'MILLER', 'CLERK', 7782, '1982-01-23', 1300, NULL, 10);

select * from EMP;

-- Create DEPT Table
create table DEPT (
    DEPTNO INT PRIMARY KEY,
    DNAME VARCHAR(20),
    LOC VARCHAR(20)
);

-- Insert data into DEPT
insert into DEPT values
(10, 'ACCOUNTING', 'NEW YORK'),
(20, 'RESEARCH', 'DALLAS'),
(30, 'SALES', 'CHICAGO'),
(40, 'OPERATIONS', 'BOSTON');

select * from DEPT;


-- 1.Write a query to display your birthday( day of week)
select datename(weekday, '2001-09-11') as BirthdayDayOfWeek;

-- 2.Write a query to display your age in days
select datediff(day, '2001-09-11', getdate()) as AgeInDays;

-- 3.	Write a query to display all employees information those who joined before 5 years in the current month
--(Hint : If required update some HireDates in your EMP table of the assignment)
select * from EMP
where datediff(year, HireDate, getdate()) >= 5
and month(HireDate) = month(getdate());

-- Updating
update EMP set HireDate = '2018-06-11' where EMPNO = 7369;

update EMP set HireDate = '2015-07-10' where EMPNO = 7566;

update EMP set HireDate = '2012-07-22' where EMPNO = 7654;

select * from EMP


/* 4.Create table Employee with empno, ename, sal, doj columns and perform the following operations in a single transaction
	a. First insert 3 rows 
	b. Update the second row sal with 15% increment  
        c. Delete first row.
After completing above all actions how to recall the deleted row without losing increment of second row.*/


select * from EMP
 
 -- a. Insert 3 rows into the Employee table 
   insert into EMP(empno, ename, sal, hiredate)
values 
    (8001, 'Bharath', 5000, '2020-01-15'),
    (8002, 'Srinivas', 6000, '2019-03-22'),
    (8003, 'Vinay', 5500, '2021-05-11');

-- b.Update the second row salary with a 15% increment
update EMP
set sal = sal * 1.15
where empno = 8002;
 
select * from EMP
 
-- c.Delete the first row
BEGIN TRANSACTION;
 
delete from EMP
where empno = 8001;
 
rollback;
 
select * from EMP


/*5.Create a user defined function calculate Bonus for all employees of a  given job using 	following conditions
	a.     For Deptno 10 employees 15% of sal as bonus.
	b.     For Deptno 20 employees  20% of sal as bonus
	c      For Others employees 5%of sal as bonus*/

-- Create the function to calculate bonus
create function CalculateBonus (@Deptno int, @Salary decimal(10, 2))
returns decimal(10, 2)
as
begin
    declare @Bonus decimal(10, 2);
    
    -- Determine the bonus based on the department number
    if @Deptno = 10
    begin
        set @Bonus = @Salary * 0.15;
    end
    else if @Deptno = 20
    begin
        set @Bonus = @Salary * 0.20;
    end
    else
    begin
        set @Bonus = @Salary * 0.05;
    end
    
    -- Return the calculated bonus
    return @Bonus;
end;
go


select empno,ename,sal,deptno,
    dbo.CalculateBonus(deptno, sal) as Bonus
from EMP;

