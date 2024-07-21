-- 1.Write a T-SQL Program to find the factorial of a given number.
declare @Num int = 5; 
declare @Fact int = 1;
declare @Count int = @Num;

if @Num < 0
begin
    print 'Invalid input';
end
else
begin
    while @Count > 1
    begin
        set @Fact = @Fact * @Count;
        set @Count = @Count - 1;
    end

    print 'The factorial of ' + cast(@Num as varchar(10)) + ' is ' + cast(@Fact as varchar(20));
end



-- 2.Create a stored procedure to generate multiplication tables up to a given number.
-- multiplication tables for a given number up to a specified stopping row
create procedure MultiplicationTable
    @TableNumber int,
    @StopRow int
as
begin
    declare @i int = 1;
    declare @Result varchar(50);

    -- Check if numbers are valid
    if @TableNumber < 1 OR @StopRow < 1
    begin
        print 'Invalid input';
        return;
    end

    -- multiplication table for @TableNumber up to @StopRow
    print 'Multiplication Table for ' + cast(@TableNumber as varchar(10)) + ' up to ' + cast(@StopRow as varchar(10)) + ' rows:';

    while @i <= @StopRow
    begin
        set @Result = cast(@TableNumber as varchar(10)) + ' x ' + cast(@i as varchar(10)) + ' = ' + cast(@TableNumber * @i as varchar(10));
        print @Result;
        set @i = @i + 1;
    end
end


exec MultiplicationTable @TableNumber = 3, @StopRow = 5;


/*3.Create a trigger to restrict data manipulation on EMP table during General holidays. Display the error message like “Due to Independence day you cannot manipulate data” or "Due To Diwali", you cannot manipulate" etc
Note: Create holiday table as (holiday_date,Holiday_name) store at least 4 holiday details. try to match and stop manipulation */


-- Create a table to store holiday details
CREATE TABLE Holidays (
    Holiday_Date DATE PRIMARY KEY,
    Holiday_Name VARCHAR(50) NOT NULL
);

-- Insert some holiday details
INSERT INTO Holidays (Holiday_Date, Holiday_Name)
VALUES 
    ('2024-07-21', 'Independence Day'),
    ('2024-11-12', 'Diwali'),
    ('2024-12-25', 'Ugadi'),
    ('2025-01-01', 'New Year');

-- Verify the holidays are correctly inserted
SELECT * FROM Holidays;


CREATE OR ALTER TRIGGER RestrictDataManipulationOnHolidays
ON Emp
INSTEAD OF INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @IsHoliday BIT
 
    SELECT @IsHoliday = CASE 
                            WHEN EXISTS (SELECT 1 FROM Holidays WHERE holiday_date = CONVERT(DATE, GETDATE())) THEN 1 
                            ELSE 0 
                       END
 
    IF @IsHoliday = 1
    BEGIN
        DECLARE @HolidayName VARCHAR(100)
        SELECT @HolidayName = holiday_name FROM Holidays WHERE holiday_date = CONVERT(DATE, GETDATE())
 
       
        RAISERROR('Due to %s, you cannot manipulate data.', 16, 1, @HolidayName)
    END
    ELSE
    BEGIN
        DECLARE @DateToCheck DATE = '2024-07-21'
 
        IF EXISTS (
            SELECT 1 
            FROM Holidays 
            WHERE holiday_date = @DateToCheck
        )
        BEGIN
            PRINT 'Insertion is not allowed on holidays.'
        END
        ELSE
        BEGIN
            PRINT 'Insertion is allowed on non-holiday dates.'
 
            
             INSERT INTO EMP (empno, ename, sal) VALUES (8000, 'sanju', 3000)
 
            --UPDATE EMP SET ename = 'Santu' WHERE ename = 'john'
 
            --DELETE FROM EMP WHERE empno = 7521
        END
    END
END
 
Select * from EMP