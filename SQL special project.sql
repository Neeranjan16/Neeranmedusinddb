drop table client
drop table employees



CREATE TABLE Client(CLIENTID int PRIMARY KEY,CNAME VARCHAR(40) NOT NULL,ADDRESS VARCHAR(30),EMAIL VARCHAR(30) UNIQUE,PHONENUMBER VARCHAR(10),BUSINESS VARCHAR(20) NOT NULL);
Insert into Client(CLIENTID,CNAME,ADDRESS,EMAIL,PHONENUMBER,BUSINESS)values(1001,'ACMEUtilities','Noida','contact@acmeutil.com',9567880032,'Manufacturing');
Insert into Client(CLIENTID,CNAME,ADDRESS,EMAIL,PHONENUMBER,BUSINESS)values(1002,'TrackonConsultants','Mumbai','consult@trackon.com',8734210090,'Consultant');
Insert into Client(CLIENTID,CNAME,ADDRESS,EMAIL,PHONENUMBER,BUSINESS)values(1003,'MoneySaverDistributors','Bangalore','save@moneysaver.com',7799886655,'Reseller');
Insert into Client(CLIENTID,CNAME,ADDRESS,EMAIL,PHONENUMBER,BUSINESS)values(1004,'LawfulCorp','Chennai','justice@lawful.com',9210342219,'Professional');

select*from Client

CREATE TABLE Department(
DEPTNO INT PRIMARY KEY,
DNAME VARCHAR(15) NOT NULL,
LOC VARCHAR(20));


insert into Department(DEPTNO,DNAME,LOC) values(10,'Design','Pune');
insert into Department(DEPTNO,DNAME,LOC) values(20,'Development','Pune');
insert into Department(DEPTNO,DNAME,LOC) values(30,'Testing','Mumbai');
insert into Department(DEPTNO,DNAME,LOC) values(40,'Document','Mumbai');

select * from Department

CREATE TABLE EMPLOYEES(EMPNO int PRIMARY KEY,ENAME VARCHAR(20) NOT NULL,JOB VARCHAR(15),SALARY float CHECK (SALARY > 0),
DEPTNO int REFERENCES DEPARTMENT(DEPTNO));

Insert into EMPLOYEES(EMPNO,ENAME,JOB,SALARY,DEPTNO) values(7001,'Sandeep','Analyst',25000,10);
Insert into EMPLOYEES(EMPNO,ENAME,JOB,SALARY,DEPTNO) values(7002,'Rajesh','Designer',30000,10);
Insert into EMPLOYEES(EMPNO,ENAME,JOB,SALARY,DEPTNO) values(7003,'Madhav','Developer',40000,20);
Insert into EMPLOYEES(EMPNO,ENAME,JOB,SALARY,DEPTNO) values(7004,'Manoj','Developer',40000,20);
Insert into EMPLOYEES(EMPNO,ENAME,JOB,SALARY,DEPTNO) values(7005,'Abhay','Designer',35000,10);
Insert into EMPLOYEES(EMPNO,ENAME,JOB,SALARY,DEPTNO) values(7006,'Uma','Tester',30000,30);
Insert into EMPLOYEES(EMPNO,ENAME,JOB,SALARY,DEPTNO) values(7007,'Gita','Tech. Writer',30000,40);
Insert into EMPLOYEES(EMPNO,ENAME,JOB,SALARY,DEPTNO) values(7008,'Priya','Tester',35000,30);
Insert into EMPLOYEES(EMPNO,ENAME,JOB,SALARY,DEPTNO) values(7009,'Nutan','Developer',45000,20);
Insert into EMPLOYEES(EMPNO,ENAME,JOB,SALARY,DEPTNO) values(7010,'Smita','Analyst',20000,10);
Insert into EMPLOYEES(EMPNO,ENAME,JOB,SALARY,DEPTNO) values(7011,'Anand','Project Mgr',65000,10);
select*from EMPLOYEES;

CREATE TABLE PROJECT(
PROJECTID INT PRIMARY KEY,
DESCR VARCHAR(30) NOT NULL,
Startdate  DATE,
Plannedenddate DATE,
Actualenddate DATE,
BUDGET INT CHECK(BUDGET > 0),
CLIENTID INT REFERENCES Client(CLIENTID));

Insert into PROJECT(PROJECTID,DESCR,Startdate,Plannedenddate,Actualenddate,BUDGET,CLIENTID)values(401,'Inventory','01-04-11','01-OCT-11','31-OCT-11',150000,1001);
Insert into PROJECT(PROJECTID,DESCR,Startdate,Plannedenddate,Actualenddate,BUDGET,CLIENTID)values(402,'Accounting','01-AUG-11','01-JAN-12',null,500000,1002);
Insert into PROJECT(PROJECTID,DESCR,Startdate,Plannedenddate,Actualenddate,BUDGET,CLIENTID)values(403,'Payroll','01-OCT-11','31-DEC-11',null,75000,1003);
Insert into PROJECT(PROJECTID,DESCR,Startdate,Plannedenddate,Actualenddate,BUDGET,CLIENTID)values(404,'ContactMgmt','01-NOV-11','31-DEC-11',null,50000,1004);

select*from PROJECT;

CREATE TABLE EMPPROJECTTASK(
PROJECTID INT REFERENCES PROJECT(PROJECTID),
EMPNO INT REFERENCES EMPLOYEES(EMPNO),
startdate DATE,
enddate DATE,
TASK VARCHAR(225) NOT NULL,
Status  VARCHAR(10) NOT NULL,
PRIMARY KEY(PROJECTID,EMPNO));

Insert into EMPPROJECTTASK(PROJECTID,EMPNO,startdate,enddate,TASK,Status)values(401,7001,'01-APR-11','20-APR-11','SystemAnalysis','Completed');
Insert into EMPPROJECTTASK(PROJECTID,EMPNO,startdate,enddate,TASK,STATUS)values (401,7002,'21-APR-11','30-MAY-11','SystemDesign','Completed');
Insert into EMPPROJECTTASK(PROJECTID,EMPNO,startdate,enddate,TASK,STATUS)values (401,7003,'01-JUN-11','15-JUL-11','Coding','Completed');
Insert into EMPPROJECTTASK(PROJECTID,EMPNO,startdate,enddate,TASK,STATUS)values (401,7004,'18-JUL-11','01-SEP-11','Coding','Completed');
Insert into EMPPROJECTTASK(PROJECTID,EMPNO,startdate,enddate,TASK,STATUS)values (401,7006,'03-SEP-11','15-SEP-11','Testing','Completed');
Insert into EMPPROJECTTASK(PROJECTID,EMPNO,startdate,enddate,TASK,STATUS)values (401,7009,'18-SEP-11','05-OCT-11','CodeChange','Completed');
Insert into EMPPROJECTTASK(PROJECTID,EMPNO,startdate,enddate,TASK,STATUS)values (401,7008,'06-OCT-11','16-OCT-11','Testing','Completed');
Insert into EMPPROJECTTASK(PROJECTID,EMPNO,startdate,enddate,TASK,STATUS)values (401,7007,'06-OCT-11','22-OCT-11','Documentation','Completed');
Insert into EMPPROJECTTASK(PROJECTID,EMPNO,startdate,enddate,TASK,STATUS)values (401,7011,'22-OCT-11','31-OCT-11','Signof','Completed');
Insert into EMPPROJECTTASK(PROJECTID,EMPNO,startdate,enddate,TASK,STATUS)values (402,7010,'01-AUG-11','20-AUG-11','SystemAnalysis','Completed');
Insert into EMPPROJECTTASK(PROJECTID,EMPNO,startdate,enddate,TASK,STATUS)values (402,7002,'22-AUG-11','30-SEP-11','SystemDesign','Completed');
Insert into EMPPROJECTTASK(PROJECTID,EMPNO,startdate,enddate,TASK,STATUS)values (402,7004,'01-OCT-11',null,'Coding','In Progress');



select*from EMPPROJECTTASK



select*from Client;
select*from EMPPROJECTTASK;
select*from EMPLOYEES;
Select*from PROJECT;
select * from Department;