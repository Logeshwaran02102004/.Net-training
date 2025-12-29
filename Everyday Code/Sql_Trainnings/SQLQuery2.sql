CREATE TABLE students (
    student_id INT PRIMARY KEY,
    first_name VARCHAR(50),
    last_name VARCHAR(50),
    age INT,
    grade VARCHAR(10),
    email VARCHAR(100)
);


INSERT INTO students (student_id, first_name, last_name, age, grade, email) VALUES
(1, 'logesh', 'waran', 22, 'A', 'logesh@.com'),
(2, 'sakthi', ' vel', 21, 'B', 'sakthi@.com'),
(3, 'waseef', 'tauquer', 19, 'A', 'waseef.com'),
(4, 'prathees', 'ba', 22, 'C', 'prathees.com'),
(5, 'dileep', 'dd', 20, 'B', 'dileep.com'),
(6, 'jegan', 'adhhi', 23, 'A', 'jegan.com'),
(7, 'aadhi', 'ya', 21, 'B', 'aadhi.com'),
(8, 'ajay', 'kumar', 19, 'A', 'ajay.com'),
(9, 'isma', 'ka', 22, 'C', 'isma.com'),
(10, 'madhu', 'vijay', 20, 'B', 'madhu.com');

SELECT * FROM students;

-- how to create simple procedure

create procedure getstudents
as
select * from students

--how to execute procedure
getstudents
-----------------------------------------------------------------------------
-- how to create simple procedure with parameter
-- how to alter procedure
create procedure getbyaddress(@a varchar(20))
as
select * from students where grade=@a

getbyaddress 'A'
-----------------------------------------------------------------------------
-- how to drop the procedure
drop procedure getbyaddress
-----------------------------------------------------------------------------

-- procedure can contain simple logic with out queries as well
create procedure Addproc(@a int, @b int)
as
print @a + @b
-----------------------------------------------------------------------------
Addproc 10, 20
-----------------------------------------------------------------------------

-- can procedure return value?
create procedure Addproc1(@a int, @b int)
as
return @a + @b


-- how to execute procedure which returns ?
declare @result int
   exec @result = AddProc1 10,20
   print @result

-----------------------------------------------------------------------------
   -- can procedure return multiple values?
   --No
   create procedure Addproc2(@a int, @b int, @c int output,  @d int output)
as
set @c= @a + @b   -- a_+b  and a*b
set @d= @a * @b 



-- how to execute procedure which returns output params?
declare @m int
declare @n int   -- null

exec Addproc2 10,20,@m output ,@n output  -- reading the value from c and d
print @m
print @n  -- print the value
-----------------------------------------------------------------------------

-- how to create procedure with try/catch block

create procedure divide(@a int, @b int)
as
begin try
 print @a/@b
end TRY
begin catch
print 'Error OCCURED : ' + error_message()
end CATCH
-----------------------------------------------------------------------------

divide 10,0
-----------------------------------------------------------------------------
sp_depends newstudentstbl
-----------------------------------------------------------------------------
-- how to execute the procedure with insert command
-- this is not done
insert into student exec getbyaddress 'pune'
-----------------------------------------------------------------------------
select * from student

select * from newstudentstbl
--still this is not completed

create table testing
(
custid int identity (10,10),
custname varchar(20),
age int
)


insert into testing values('Ashok',23)
insert into testing values('Logeshwaran',23)
select * from testing


create procedure myproc(@cname varchar(20),@ag int)
as
insert into testing values(@cname,@ag)
return scope_identity()
-- i want to know what values has been assiged for custid 

declare @res int
exec @res = myproc 'deepa',22
print @res


-----------------------------------------------------------------------------

create procedure displaydata(@tbl varchar(20))
as
declare @myquery nvarchar(100)
set @myquery = 'select * from ' + @tbl
exec sp_executesql @myquery -- runs the select command



displaydata 'students'

======================================================================================

-- adding one more row in the table
create procedure InsertStudent
@student_id int, @first_name varchar(100),@last_name varchar(100), @age int, @grade varchar(10),@email varchar(50)
as
INSERT INTO Students (student_id, first_name,last_name, age, grade,email)
values (@student_id, @first_name,@last_name, @age, @grade,@email);
 
exec InsertStudent
@student_id = 12,
@first_name = 'fagath',
@last_name = 'naz',
@age = 21,
@grade = 'B',
@email = 'fagathnaz';

getstudents



CREATE TABLE Orders (
    OrderId INT IDENTITY(1,1) PRIMARY KEY,  -- Auto-increment ID
    CustomerName VARCHAR(100),
    ProductName VARCHAR(100),
    Quantity INT,
    Price DECIMAL(10,2),
    PurchaseDate DATE
);

-- to get order deatails from 2004 to 2007
INSERT INTO Orders (CustomerName, ProductName, Quantity, Price, PurchaseDate) VALUES
('Logesh Waran', 'Laptop', 1, 75000, '2004-11-01'),
('Sakthi Vel', 'Smartphone', 2, 45000, '2005-11-03'),
('Waseef Tauquer', 'Headphones', 1, 2500, '2006-11-05'),
('Prathees Ba', 'Monitor', 2, 12000, '2007-11-07'),
('Dileep DD', 'Keyboard', 3, 1500, '2008-11-09');

create procedure GetOrders_Date (@StartDate date, @EndDate date)
as
select * from Orders
WHERE PurchaseDate BETWEEN @StartDate AND @EndDate;
 
exec GetOrders_Date '2004-01-01', '2007-03-20';




-- to print product and quantity usins the customer name
alter procedure GetCustomerName (@CustName varchar(100), @Qty int output, @product varchar(100) output)
as
select  
@Qty = Quantity, @product = ProductName
FROM Orders
WHERE CustomerName = @CustName; 

declare @q varchar, @p varchar(100);
exec GetCustomerName 'Logesh Waran', @q output, @p output;
print @q;
print @p;
 

 -- to check the productname book is there or not
create procedure CheckStock
@ProductName varchar(100)
as
    if exists (select ProductName from orders where ProductName = @ProductName)
    begin
      select SUM(quantity) AS TotalStock
      FROM orders WHERE ProductName = @ProductName;
    end
    else
    begin
        print 'Books does not exists';
    end
 
exec CheckStock @ProductName = 'Books';


-- creating the customer table

CREATE TABLE Customers (
    custid INT PRIMARY KEY,
    custname VARCHAR(100),
    Age INT,
    caddress VARCHAR(200),
    cphone BIGINT
);


INSERT INTO Customers (custid, custname, Age, caddress, cphone) VALUES
(101, 'Logesh Waran', 22, 'Chennai', 9876543210),
(102, 'Sakthi Vel', 21, 'Coimbatore', 8765432109),
(103, 'Waseef Tauquer', 19, 'Kerala', 9988776655),
(104, 'Prathees Ba', 22, 'Madurai', 8877665544),
(105, 'Dileep DD', 20, 'Salem', 8899001122);


alter procedure getdata(@age int)
as return @age


declare @returned_age int
exec @returned_age = getdata 40
 
insert into Customers (custid, custname, Age, caddress, cphone)
VALUES (007, 'siuuuuu', @returned_age, 'bangalore', 9887878787)
 
select * from Customers;


--display all customer deatails between 2 to 5

create procedure GetRow
@StartRow INT, @EndRow INT
as
     WITH CustomerCTE AS
    (
        SELECT *,
               ROW_NUMBER() OVER (ORDER BY custid) AS RowNum
        FROM Customers
    )
SELECT * FROM CustomerCTE WHERE RowNum BETWEEN @StartRow AND @EndRow;
GetRow 2, 5;






















