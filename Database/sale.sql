create database sale1

use sale1

create table sale_table1(
Product_id varchar(20) primary key,
Product_name varchar(50),
Catagory varchar(50),
Buy_price varchar(50),
Sale_price varchar(50),
Sale_date date);

select * from sale_table1

delete from sale_table1 where Product_id = 'p7'