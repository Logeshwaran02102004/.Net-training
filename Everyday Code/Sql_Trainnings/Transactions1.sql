begin transaction;

update BankAccount
set balance = 10000
where acc_id = 1000;
 
rollback transaction;


-- this is for read committe
update BankAccount
SET acc_name = 'prathess'
WHERE acc_id = 1000;
Commit