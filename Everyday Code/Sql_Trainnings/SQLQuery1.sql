CREATE DATABASE SQL_DAY_1;
 
CREATE TABLE Customers (
    cus_id      INT PRIMARY KEY,
    cus_name    VARCHAR(15),
    cus_age     TINYINT,
    cus_address VARCHAR(20),
    cus_phone   INT
);
 
insert into Customers 
values
(1, 'Logesh', 22, 'Bangalore', 12345678),
(2, 'prathess', 20, 'Coimbatore', 45678765),
(3, 'waseef', 34, 'Chennai', 23456541),
(4, 'keerthik', 59, 'Hyderabad', 7634554),
(5, 'sakthi', 52, 'Trichy', 98764565),
(6, 'Sree', 43, 'Palani', 87654876),
(7, 'harini', 58, 'Chennai', 7654981),
(8, 'jeevs', 38, 'Mysore', 654321987);
 
CREATE TABLE Orders (
    cus_id        INT,
    order_id      INT PRIMARY KEY,
    order_date    DATE,
    order_product VARCHAR(15),
    price         INT,
    quantity      SMALLINT,
    FOREIGN KEY (cus_id) REFERENCES Customers(cus_id)
);
 
insert into Orders
(cus_id, order_id, order_date, order_product, price, quantity)
values
(1,101,'2025-03-20','Chocolate',5000,200),
(2,102,'2025-08-02','Rose',2500,500),
(3,105,'2025-09-23','Books',7600,700),
(4,103,'2025-10-31','Cricket Bat',88500,600),
(5,107,'2025-05-26','Dress',22500,900),
(6,123,'2025-07-04','Bag',4390,350),
(7,112,'2025-06-22','Pouch',5000,250),
(8,109,'2025-08-02','Bottle',45000,1000);
 
select * from Customers;
 
select * from Orders;






select * from Customers where cus_id IN (select cus_id from Orders where order_product = 'Rose');
 

select * from Customers where cus_id In (select cus_id from Orders where order_product IN ('Rose' , 'Chocolate' ,'Pouch'));
 


select * from Customers where cus_id NOT IN (select cus_id from Orders);
 


select MAX(cus_age) as second_highest_age from Customers where cus_age < (select MAX(cus_age) from Customers);
 


select * from orders where cus_id IN (select cus_id from Customers where cus_address ='Bangalore');
 


select * from Customers where cus_id IN (select cus_id from Orders where quantity = (select MIN(Quantity) from Orders));
 


select * from Customers where cus_age > (select cus_age from Customers where cus_name = 'sakthi');
 


UPDATE Customers SET cus_age = (select cus_age from Customers where cus_id = 2) where cus_id = 02;
 

select * from Orders where MONTH(order_date) = 03;
 

select * from Orders where DAY(order_date) < 16 AND cus_id IN (select cus_id from Customers where cus_address = 'Bangalore');
 
