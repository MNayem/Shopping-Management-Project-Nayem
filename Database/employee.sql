create database employee

use employee

create table employee_table(
Employee_id varchar(20) primary key,
Employee_Name varchar(50),
Employee_Qualification varchar(50),
Employee_Address varchar(100),
Employee_Post varchar(50),
Employee_JoinDate date,
Employee_Salary varchar(50));

select * from employee_table

alter table employee_table add Employee_image image

alter table employee_table change Employee_JoinDate as Employee_JoinDate varchar(50);