--select * from BankAccount
--create table Customer(cus_id int primary key , cus_name varchar(20),cus_age int,cus_address varchar(20))
--create table Products(pro_id int primary key,pro_name varchar(20),price decimal(10,2))
--create table ErrorLog(error_id int identity primary key,error_msg varchar(4000) , error_time datetime default getdate())
--select *from Customer

-- Assignmnet 

--****basic transaction from account 1 to 2 ************************


declare @amount int = 1000
begin transaction
update BankAccount set balance = balance - @amount where acc_id = 1000
declare @bal int
select @bal = balance from BankAccount where acc_id = 1000
if @bal<0
begin
rollback transaction
print 'You dont have enough money please check your balance'
end
else
begin
update BankAccount set balance = balance + @amount where acc_id = 2000
commit transaction
print 'transaction successful'
end

select * from BankAccount


--***** rollback to t2 **********************

begin transaction
insert into PriceOrders values(104,1000,5000,'2025-03-20')
save transaction t1
insert into PriceOrders values(105,2000,10000,'2024-08-02')
save transaction t2
insert into PriceOrders values(106,3000,8000,'2023-10-01')
save transaction t3
rollback transaction t2
commit
 
select * from PriceOrders



--******** to throw error message*********************

begin try
begin transaction 
update Products set price = price/0
commit
end try
begin catch
rollback
insert into ErrorLog(error_msg) values (ERROR_MESSAGE())
end catch
 
select * from ErrorLog


--***** to throw error in inner transaction *******************
begin transaction outertransaction
insert into Customer values(4000,'Ronaldo',40,'Portugal')
begin transaction innertransaction
insert into PriceOrders values(103,300,6000,'2023-07-21')
select 5/0
if @@ERROR <> 0
begin 
print 'inner transaction rolled back'
rollback transaction innertransaction
end
commit transaction outertransaction
 
select * from Customer
select * from PriceOrders




-- it read uncommited method **************************

set transaction isolation level
read uncommitted

begin transaction
select * from BankAccount where acc_id = 1000;
waitfor delay '00:00:10'
select * from BankAccount where acc_id = 1000;
commit


--it is for non repeatable read **********************


set transaction isolation level read committed;
 
begin transaction;
select * from BankAccount where acc_id = 1000;
 
waitfor delay '00:00:10';  
select * from BankAccount where acc_id= 1000;
commit;        






 
