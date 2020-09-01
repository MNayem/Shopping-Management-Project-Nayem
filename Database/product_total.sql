create database product_total

use product_total

create table product_total_available(
Product_id varchar(20) primary key,
Product_name varchar(50),
Catagory varchar(50),
Buy_price varchar(50),
Sale_price varchar(50),
Entry_date date,
Expire_date date,
);

select * from product_total_available