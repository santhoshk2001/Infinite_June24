use AssignmentDB

select * from EMP;

select * from DEPT;

-- 1. Retrieve a list of MANAGERS. 
select DISTINCT E1.MGR_ID, E2.ENAME AS MANAGER_NAME
from EMP E1
JOIN EMP E2 ON E1.MGR_ID = E2.EMPNO
where E1.MGR_ID IS NOT NULL;

-- 2. Find out the names and salaries of all employees earning more than 1000 per month.
select ENAME, SAL from EMP where SAL > 1000;

-- 3. Display the names and salaries of all employees except JAMES. 
select ENAME, SAL from EMP where ENAME NOT IN ('JAMES');

-- 4. Find out the details of employees whose names begin with ‘S’. 
select * from EMP where ENAME LIKE 'S%';

-- 5. Find out the names of all employees that have ‘A’ anywhere in their name.
select ENAME from EMP where ENAME LIKE '%A%';

-- 6. Find out the names of all employees that have ‘L’ as their third character in their name. 
select ENAME from EMP where ENAME LIKE '__L%';

-- 7. Compute daily salary of JONES.
select ENAME, SAL/30 AS DAILY_SALARY from EMP where ENAME = 'JONES';

-- 8. Calculate the total monthly salary of all employees. 
select SUM(SAL) AS TOTAL_MONTHLY_SALARY from EMP;

-- 9. Print the average annual salary.
select AVG(SAL) * 12 AS AVG_ANNUAL_SALARY from EMP;

-- 10. Select the name, job, salary, department number of all employees except SALESMAN from department number 30.
select ENAME, JOB, SAL, DEPTNO 
from EMP 
where DEPTNO = 30 AND JOB NOT IN ('SALESMAN');

-- 11. List unique departments of the EMP table.
select DISTINCT E.DEPTNO, D.DNAME
from EMP E
JOIN DEPT D ON E.DEPTNO = D.DEPTNO;

-- 12. List the name and salary of employees who earn more than 1500 and are in department 10 or 30. Label the columns Employee and Monthly Salary respectively.
select ENAME AS Employee, SAL AS "Monthly Salary" 
from EMP 
where SAL > 1500 AND DEPTNO IN (10, 30);

-- 13. Display the name, job, and salary of all the employees whose job is MANAGER or ANALYST and their salary is not equal to 1000, 3000, or 5000. 
select ENAME, JOB, SAL 
from EMP 
where (JOB = 'MANAGER' OR JOB = 'ANALYST') AND SAL NOT IN (1000, 3000, 5000);

-- 14. Display the name, salary and commission for all employees whose commission amount is greater than their salary increased by 10%.
select ENAME, SAL, COMM 
from EMP 
where COMM > SAL * 1.0;

-- 15. Display the name of all employees who have two Ls in their name and are in department 30 or their manager is 7782.
select ENAME 
from EMP 
where (ENAME LIKE '%L%L%' AND DEPTNO = 30) OR MGR_ID = 7782;

-- 16. Display the names of employees with experience of over 30 years and under 40 yrs. Count the total number of employees.
WITH ExperiencedEmployees AS (
    select ENAME
    from EMP
    where DATEDIFF(YEAR, HIREDATE, GETDATE()) > 30 
    AND DATEDIFF(YEAR, HIREDATE, GETDATE()) < 40
)
select ENAME, (select COUNT(*) from ExperiencedEmployees) AS TOTAL_EMPLOYEES
from ExperiencedEmployees;

-- 17. Retrieve the names of departments in ascending order and their employees in descending order. 
select D.DNAME, E.ENAME 
from DEPT D 
JOIN EMP E ON D.DEPTNO = E.DEPTNO 
ORDER BY D.DNAME ASC, E.ENAME DESC;

-- 18. Find out experience of MILLER. 
select ENAME, DATEDIFF(YEAR, HIREDATE, GETDATE()) AS EXPERIENCE_YEARS 
from EMP 
where ENAME = 'MILLER';



