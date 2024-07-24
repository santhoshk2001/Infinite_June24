create database Employeemanagement

use Employeemanagement

create table Employee_Details (
    Empno INT PRIMARY KEY,
    EmpName VARCHAR(50) NOT NULL,
    Empsal INT CHECK (Empsal >= 25000),
    Emptype CHAR(1) CHECK (Emptype IN ('F', 'P'))
);


create procedure InsertEmployee
    @EmpName VARCHAR(50),
    @EmpSal INT,
    @EmpType CHAR(1)
as
begin
    declare @NewEmpNo INT;

    select @NewEmpNo = COALESCE(MAX(EmpNo), 0) + 1 from Employee_Details;
 
    insert into Employee_Details (EmpNo, EmpName, EmpSal, EmpType)
    values (@NewEmpNo, @EmpName, @EmpSal, @EmpType);

    select @NewEmpNo as NewEmpNo;
end;

EXEC InsertEmployee 'Santhosh', 30000, 'F';
EXEC InsertEmployee 'Bharath', 28000, 'P';

select * from Employee_Details