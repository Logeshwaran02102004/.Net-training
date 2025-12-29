select * from Customers

set transaction isolation level
read uncommitted-- instead of uncommitted if we use committed means we can get only the commited data
 
begin transaction
select * from Customers where cus_id = 1;
waitfor delay '00:00:10'
select * from Customers where cus_id=1
commit

-- this is for read commited

set transaction isolation level read committed
begin transaction
select * from Customers where cus_id=2
waitfor delay '00:00:10'
select * from Customers where cus_id=2
commit
 
 -- repeatable 
 set transaction isolation level Repeatable Read
begin transaction
select * from Customers where cus_id=3

waitfor delay '00:00:5'
select * from Customers where cus_id=3
commit transaction

--serializable

set transaction isolation level serializable -- no insert is allowed
begin transaction 
select * from Customers where cus_id >=2
commit
 
 -- simple transaction demo
 create table TableA
(
custid int primary key,
custname varchar(20)
)

create table TableB
(
custid int primary key,
custname varchar(20)
)

-- without transaction
insert into TableA values(200,'vijay')
insert into TableB values(100,'viju')

select * from tableA
select * from TableB

-- with transaction
begin transaction
insert into TableA values(300,'Ram')
insert into TableB values(100,'rahim')
if(@@ERROR > 0)
rollback transaction
else
commit transaction


-- save point demo


BEGIN TRANSACTION;

INSERT INTO Employees VALUES (1, 'John');

SAVE TRANSACTION SP1;

INSERT INTO Employees VALUES (2, 'Sara');

-- Rollback the second insert only
ROLLBACK TRANSACTION SP1;

COMMIT TRANSACTION;
=============================

BEGIN TRANSACTION;

INSERT INTO Accounts VALUES (101, 'Amit', 5000);

SAVE TRANSACTION DepositSave;

BEGIN TRY
    -- This will cause an error (division by zero)
    DECLARE @x INT = 1/0;
    
    UPDATE Accounts SET Balance = Balance + 2000 WHERE AccID = 101;
END TRY
BEGIN CATCH
    PRINT 'Error occurred... rolling back to savepoint';
    ROLLBACK TRANSACTION DepositSave;
END CATCH;

COMMIT TRANSACTION;
