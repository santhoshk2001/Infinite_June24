use AssignmentDB

create procedure GeneratePayslip
    @EmpNo INT
as
begin
    declare @Salary DECIMAL(7, 2), 
            @HRA DECIMAL(7, 2), 
            @DA DECIMAL(7, 2), 
            @PF DECIMAL(7, 2), 
            @IT DECIMAL(7, 2), 
            @Deductions DECIMAL(7, 2), 
            @GrossSalary DECIMAL(7, 2), 
            @NetSalary DECIMAL(7, 2),
            @EName VARCHAR(20), 
            @Job VARCHAR(20), 
            @DeptNo INT;

    -- Retrieve employee details
    select @EName = ENAME, @Job = JOB, @Salary = SAL, @DeptNo = DEPTNO
    from EMP
    where EMPNO = @EmpNo;

    -- Calculate components
    SET @HRA = @Salary * 0.10;
    SET @DA = @Salary * 0.20;
    SET @PF = @Salary * 0.08;
    SET @IT = @Salary * 0.05;
    SET @Deductions = @PF + @IT;
    SET @GrossSalary = @Salary + @HRA + @DA;
    SET @NetSalary = @GrossSalary - @Deductions;

    -- Print payslip
    PRINT 'Payslip for Employee No: ' + CAST(@EmpNo AS VARCHAR);
    PRINT '---------------------------------------------';
    PRINT 'Name: ' + @EName;
    PRINT 'Job: ' + @Job;
    PRINT 'Department No: ' + CAST(@DeptNo AS VARCHAR);
    PRINT '---------------------------------------------';
    PRINT 'Basic Salary: ' + CAST(@Salary AS VARCHAR);
    PRINT 'HRA (10%): ' + CAST(@HRA AS VARCHAR);
    PRINT 'DA (20%): ' + CAST(@DA AS VARCHAR);
    PRINT '---------------------------------------------';
    PRINT 'Gross Salary: ' + CAST(@GrossSalary AS VARCHAR);
    PRINT '---------------------------------------------';
    PRINT 'PF (8%): ' + CAST(@PF AS VARCHAR);
    PRINT 'IT (5%): ' + CAST(@IT AS VARCHAR);
    PRINT '---------------------------------------------';
    PRINT 'Deductions: ' + CAST(@Deductions AS VARCHAR);
    PRINT '---------------------------------------------';
    PRINT 'Net Salary: ' + CAST(@NetSalary AS VARCHAR);
end;

EXEC GeneratePayslip @EmpNo = 101;


select * from EMP
