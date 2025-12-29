-- read uncommited demo
begin transaction
update Customers set cus_name = 'loge' where cus_id=1
rollback

--read commited demo

begin transaction
update Customers set cus_name='raj' 
where cus_id=2
rollback

--window1 will wait ultil update is  commited from window2
--(update, insert can happen)

-- this is for repeatable read demo;
begin transaction
update Customers set cus_name='raj'
where cus_id=3
commit
rollback

--Serializable
begin transaction 
insert into Customers values(10,'waseee',22,'abc',123456)
commit