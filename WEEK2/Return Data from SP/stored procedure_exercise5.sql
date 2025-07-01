CREATE PROCEDURE sp_InsertEmployee
    @EmployeeID INT,
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @DepartmentID INT,
    @Salary DECIMAL(10,2),
    @JoinDate DATE
AS
BEGIN
    INSERT INTO Employees (EmployeeID, FirstName, LastName, DepartmentID, Salary, JoinDate)
    VALUES (@EmployeeID, @FirstName, @LastName, @DepartmentID, @Salary, @JoinDate);
END;
EXEC sp_InsertEmployee 
    @EmployeeID = 7,
    @FirstName = 'Reddy',
    @LastName = 'Lilly',
    @DepartmentID = 1,
    @Salary = 8400.00,
    @JoinDate = '2024-01-02';