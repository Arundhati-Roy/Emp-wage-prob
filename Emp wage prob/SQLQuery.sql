/*UC1*/
use tsetDB
drop table employee_payroll
/*UC2*/
create table employee_payroll(

id int NOT NULL identity(1,1) PRIMARY KEY,
name VARCHAR(50) NOT NULL,
salary DECIMAL(10,2) NOT NULL,
startDate DATETIME NOT NULL ) ;


 /*UC3*/
 insert into employee_payroll(name,salary,startDate)
 values('AR',67897,'2019-08-30'),
 ('NR',6757698,'2018-05-23'),
 ('PR',8786758,'2012-09-03'),
 ('SR',236758,'1987-12-13')
 ;
 '''Doubt: When I try to add values but it fails, id still gets incremented'''

 /*UC4*/
SELECT * FROM employee_payroll

 exec sp_help employee_payroll

 /*UC5*/
SELECT * FROM employee_payroll
where name='AR'

SELECT * FROM employee_payroll
WHERE startDate BETWEEN CAST('2019-01-01'
AS DATE) AND getDATE();

 /*UC6*/
 Alter table employee_payroll
 Add gender varchar(30)
UPDATE employee_payroll set gender ='F' 
where name = 'AR' or 
name ='Charlie';
SELECT * FROM employee_payroll

 /*UC7*/
SELECT SUM(salary) as SalF FROM employee_payroll
WHERE gender = 'F' GROUP BY gender;

 /*UC8*/
 Alter table employee_payroll
 drop column empPhone,addr,dept;
 '''Doubt: Drop column gives error'''
  Alter table employee_payroll
 Add empPhone varchar(30),
 addr varchar(255) Default 'Mumbai',
 dept varchar(30) Default 'NA'
WITH VALUES ;
 SELECT * FROM employee_payroll
 '''Doubt: Default value is not inserted'''

  /*UC9*/
 Alter table employee_payroll
 drop column basicPay,deductions,taxablePay,incomeTax,NetPay;
 Alter table employee_payroll
 Add basicPay int,
 deductions int,
 taxablePay int,
 incomeTax int,
 NetPay as basicPay-deductions-taxablePay-incomeTax;
 SELECT * FROM employee_payroll

 /*UC10*/
 insert into employee_payroll(name,salary,startDate,gender,empPhone,addr,
 dept,basicPay,deductions,taxablePay,incomeTax)
 values('Teressia',5667897,'2017-08-20','F',876556789,'Pune','Sales',65857,678,234,5876);
  SELECT * FROM employee_payroll
