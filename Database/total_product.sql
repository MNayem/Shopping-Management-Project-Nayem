create database total_product1

use total_product1

create table total_available_product1(
Product_id varchar(20) primary key,
Product_name varchar(50),
Category varchar(30),
Buy_Price varchar(50),
Price varchar(50),
Entry_Date date,
Expire_Date date);

select * from total_available_product1
alter table  total_available_product add buy_price varchar(50)

insert into total_available_product values('p1','Layer Shot Perfume','Body Spray','370','04-12-2017','01-12-2018')
update total_available_product set buy_price='100'

SELECT * from  total_available_product where Entry_Date = DATEADD(DAY, 2 - DATEPART(WEEKDAY, GETDATE()), CAST(GETDATE() AS DATE))  
DATEADD(DAY, 8 - DATEPART(WEEKDAY, GETDATE()), CAST(GETDATE() AS DATE))

select * from total_available_product where Entry_Date between CAST(GETDATE() AS DATE) and CAST(GETDATE() AS DATE)

select * from total_available_product where Entry_Date = DateAdd(M,-1,GetDate())

