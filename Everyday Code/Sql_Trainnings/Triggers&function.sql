select * from Customers
select * from Orders


--String Functions
--LEN()
SELECT LEN('SQL Server') AS LengthResult;

-- CONCAT()
SELECT CONCAT('Hello ', 'World') AS FullText;

 --REPLACE()
SELECT REPLACE('SQL SERVER TRAINING', 'SERVER', 'Database') AS NewText;

--SUBSTRING()
SELECT SUBSTRING('Microsoft SQL Server', 11, 3) AS ExtractedText;
-- Output: SQL


select SUBSTRING('helloworld',2,3)

 --UPPER()
SELECT UPPER('sql server') AS UpperCaseText;

-- LOWER()
SELECT LOWER('SQL SERVER') AS LowerCaseText;

-- RIGHT()
SELECT RIGHT('SQLSERVER', 6) AS LastCharacters;
-- Output: SERVER

--LEFT()
SELECT LEFT('DATABASE', 4) AS FirstCharacters;
-- Output: DATA

--Aggregate Functions


CREATE TABLE Sales(
   Id INT,
   Amount INT
);

INSERT INTO Sales VALUES
(1, 100), (2, 300), (3, 250), (4, 150);

--MAX()
SELECT MAX(Amount) AS MaxAmount FROM Sales;

--MIN()
SELECT MIN(Amount) AS MinAmount FROM Sales;

-- SUM()
SELECT SUM(Amount) AS TotalAmount FROM Sales;

-- COUNT()
SELECT COUNT(*) AS TotalRows FROM Sales;

-- AVG()
SELECT AVG(Amount) AS AverageAmount FROM Sales;

-- Numeric Functions
--SQRT()
SELECT SQRT(144) AS SquareRoot;

-- ROUND()
SELECT ROUND(123.4567, 2) AS RoundedValue;
-- Output: 123.46

 select POWER(2, 3);
-- Output: 8

-- RAND()
SELECT RAND() AS RandomNumber;       -- Random number between 0 and 1

select getdate()
--date function
SELECT DATENAME(year, GETDATE()) as Year,
       DATENAME(week, GETDATE()) as Week,
       DATENAME(dayofyear, GETDATE()) as DayOfYear,
       DATENAME(month, GETDATE()) as Month,
       DATENAME(day, GETDATE()) as Day,
       DATENAME(weekday, GETDATE()) as WEEKDAY



SELECT DATEADD(DAY, 10, '2024-01-01');
SELECT DATEADD(MONTH, -2, '2024-06-15');
SELECT DATEADD(YEAR, 1, GETDATE())


select DATEDIFF(DAY, '2024-01-01', '2024-01-02')
SELECT DATEDIFF(YEAR, '2010-01-01', GETDATE());
SELECT DATEDIFF(MONTH, '2024-01-01', '2024-06-01');

--cast functions
-- 1.cast
-- 2.convert

declare  @x int
set @x= 10
--print 'you have entered ' + cast(@x as varchar)-- no formatting
print 'you have entered ' + convert(varchar(10),@x)-- supports formatting


-- what is formatting?

declare @a date
set @a = '1-1-2000'
--print 'the date u have entered is' + cast(@a as varchar)
print 'you have entered ' + convert(varchar(10),@a,111)
print 'you have entered ' + convert(varchar(10),@a,109)
print 'you have entered ' + convert(varchar(10),@a,112)
print 'you have entered ' + convert(varchar(10),@a,113)
print 'you have entered ' + convert(varchar(10),@a,108)

===========================================================


--scalar function

alter function fn_add(@a int, @b int)
returns int
as
begin
declare @c int
set @c =@a  * @b
return @c
end

-- how to run the function
select dbo.fn_add(10,20)

=========================================

-diff between procedres and function
--procedures may or maynot return value
--function should return value

--procedures cannot be used inside query
-- function can be used inside query

select pid, qty,dbo.fn_add(pid,qty) from orders

-- how to drop function
drop function dbo.fn_add
-----------------------------------------------
inline function
------------------------------------------------

create function fn_getstudents(@a varchar(20))
returns table
as
return(
select * from newstudentstbl where saddress =@a
)


select * from fn_getstudents('hyd')
=============================================



realtime example

select c.custid, c.custname , c.caddress , o.orderid ,
 o.orderdate , o.qty,p.pname,p.price from custs  c
  join orders o on c.custid=o.custid
join products p on o.pid = p.pid





create function test()
returns table
as
return(
select c.custid, c.custname , c.caddress ,o.pid, o.orderid ,
 o.orderdate , o.qty
from custs  c join orders o on c.custid=o.custid
)
select * from dbo.test()

select p.pname,p.price , co.* from 
 products p join dbo.test() co on co.pid = p.pid
 
 ===================================================
 
 
 multi statement table valued function
 
 CREATE FUNCTION fn_Employees
   (@length nvarchar(9))
RETURNS @tbl_Employees TABLE
   (EmployeeID int PRIMARY KEY NOT NULL,
   [Employee Name] Nvarchar(61) NOT NULL)
AS
BEGIN
   IF @length = 'ShortName'
      INSERT @tbl_Employees SELECT EmployeeID, LastName
      FROM Employees
   ELSE IF @length = 'LongName'
      INSERT @tbl_Employees SELECT EmployeeID,
      (FirstName + ' ' + LastName) FROM Employees
   RETURN
END

------------------------------------

how to run the multi statement function

SELECT * FROM dbo.fn_Employees('LongName')
Or
SELECT * FROM dbo.fn_Employees('ShortName') 


--to find the greatest of the three numbers
CREATE FUNCTION greatestofthree
(
    @a INT,
    @b INT,
    @c INT
)
RETURNS INT
AS
BEGIN
    DECLARE @max INT;

    SET @max =
    CASE
        WHEN @a >= @b AND @a >= @c THEN @a
        WHEN @b >= @a AND @b >= @c THEN @b
        ELSE @c
    END;

    RETURN @max;
END;

SELECT dbo.greatestofthree(100, 205, 150) AS GreatestNumber;


select * from Orders


-- disocunt 10 percent for all the products
CREATE FUNCTION discount10percent()
RETURNS TABLE
AS
RETURN
(
    SELECT 
        order_id,
        order_product,
        price AS OriginalPrice,
        price * 0.10 AS DiscountAmount,
        price * 0.90 AS FinalPrice
    FROM Orders      
);


SELECT * FROM discount10percent();

--discount only if the product name is books and toys

create function booktoysdiscount
(
    @productname varchar(50), @price decimal(10,2)
)
returns decimal(10,2)
as
begin
    declare @discount decimal(10,2);
 
    if @productname = 'books'
        set @discount = @price * 0.10;
    else if @productname = 'toys'
        set @discount = @price * 0.15;
    else
        set @discount = 0;
 
    return @discount;
end;
select dbo.booktoysdiscount('books', 200) as discount;
select dbo.booktoysdiscount('toys', 300) as discount;
select dbo.booktoysdiscount('shoes', 500) as discount;


-- to get the get from lastnyears 


create function getlastnyear
( @n int )
returns table
as
return
(
    select *
    from Orders
    where order_date >= dateadd(year, -@n, getdate())
);
select * from getlastnyear(3);


-- triggers assignment 

CREATE TABLE CustomersDeatails
(
    cus_id INT PRIMARY KEY,
    cus_name VARCHAR(100) NOT NULL,
    cus_address VARCHAR(100) NOT NULL,
    cus_product VARCHAR(100)
);

INSERT INTO CustomersDeatails VALUES
(1, 'logesh', 'bangalore','book'),
(2, 'waseef', 'Bangalore', 'watch'),
(3, 'keerthik', 'Chennai','mac'),
(4, 'isma', 'Delhi','cell'),
(5, 'arini', 'Pune','cd');



-- we cant delete the row of declared city
select * from Customers

create trigger deletecities
on CustomersDeatails
after delete
as
begin
    if exists (select * from deleted 
               where cus_address in ('Bangalore', 'Chennai', 'Delhi'))
    begin
        rollback;
        print 'You cannot delete customers from Bangalore, Chennai, or Delhi.';
    end
end;
 
delete from CustomersDeatails where cus_id = 1;


-- only you can insert the declared products
--select * from Orders


create trigger allowonlydeclared
on CustomersDeatails
after insert
as
begin
    if exists (
        select *
        from inserted
        where order_product not in ('books', 'cd', 'mobile')
    )
    begin
        rollback;
        print 'Only Books, CD, and Mobile are allowed to be inserted.';
    end
end;
insert into CustomersDeatails(cus_id,cus_name,cud_address,cus_product) values (77,'name','Bangalore','cd');
 
 
select * from Orders








 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 

















