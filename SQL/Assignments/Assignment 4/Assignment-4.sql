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
    ('2024-08-15', 'Independence Day'),
    ('2024-11-12', 'Diwali'),
    ('2024-12-25', 'Ugadi'),
    ('2025-01-01', 'New Year');

-- Verify the holidays are correctly inserted
SELECT * FROM Holidays;


-- Create or alter the trigger to restrict data manipulation during holidays
CREATE OR ALTER TRIGGER trgRestrictDataManipulation
ON EMP
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Today DATE = CAST(GETDATE() AS DATE);
    DECLARE @HolidayName VARCHAR(50);

    -- Check if today is a holiday
    IF EXISTS (SELECT 1 FROM Holidays WHERE Holiday_Date = @Today)
    BEGIN
        -- Get the name of the holiday
        SELECT @HolidayName = Holiday_Name FROM Holidays WHERE Holiday_Date = @Today;

        -- Display an error message
        DECLARE @ErrorMessage NVARCHAR(100);
        SET @ErrorMessage = CONCAT('Due to ', @HolidayName, ', you cannot manipulate data.');
        RAISERROR(@ErrorMessage, 16, 1);

        -- Rollback the transaction to prevent data manipulation
        ROLLBACK TRANSACTION;
    END
END;

-- Attempting to insert data into the EMP table on Independence Day
-- Set the date to simulate today's date as Independence Day
DECLARE @Today DATE = '2024-08-15';

-- Attempt to insert a record into the EMP table
BEGIN TRY
    -- Start a transaction explicitly for testing
    BEGIN TRANSACTION;

    -- Insert statement that would typically be executed
    INSERT INTO EMP (empno, ename, sal)
    VALUES (102, 'John', 70000);

    -- If the insert operation succeeds, commit the transaction
    COMMIT TRANSACTION;

    -- If no error is raised, the insert was successful
    PRINT 'Insert successful.';
END TRY
BEGIN CATCH
    -- If an error occurs during the insert operation (e.g., due to holiday trigger)
    -- Print the error message
    PRINT ERROR_MESSAGE();

    -- Rollback the transaction to prevent changes
    ROLLBACK TRANSACTION;
END CATCH;
