select * from emp
select * from dept
		  
 
--1. Select a list of managers

	   select * from Emp where job='manager'
-- 2. list out names and salaries of all employees earninig more than 1000 per month

	  select Ename, sal from Emp where sal >= 1000

--3 list out names and salaries of all employees except James
	  
	  select Ename,sal from Emp where Ename <> 'james'
--4 find out names  of all employees whose name sbegin with 'S'

	  Select Ename from Emp where ename like 's%'

--5  find out names of all employees that have 'A' anywhere in their name

       Select Ename from Emp where Ename like'%A%'

--6 list out all the employees that have 'L' as thier third caharacter in thier name

	  select Ename from Emp where Ename like '__L%'

--7 Compute daily salary of jones
	   
	   Select Ename,(sal/30) as 'Per day slary' from Emp  where Ename = 'jones'

--8 compute total monthly salary of all employees

	   Select  sum(sal) as 'Total Monthly salary'
	   from Emp 

-- 9 print the avaerage annual salary
	   Select  avg(sal) as 'average salary' from Emp
	   
--10 list the name job salary department number of all employees except salesman from department number30*/

	   select Ename,job,sal,Deptno from Emp where not (job = 'salesman' and  Deptno =30);
	  
--11 List out unique departments of employee table
	   
	    select distinct Empno from Emp ;

-- 12 List the name and salary of employees who can earn more than 1500 
	 
	    Select Ename , sal From Emp where sal >=1500 ;
		
--13 Display the name, job, and salary of all the employees whose job is MANAGER or ANALYST and their salary is not equal to 1000, 3000, or 5000

		select Ename, job, sal
        from Emp
        Where (job = 'manager' OR job = 'analyst') AND sal NOT IN (1000, 3000, 5000);


-- 14 Display the name, salary and commission for all employees whose commission amount is greater than their salary increased by 10%

		   select Ename, sal, Comm from Emp
           where Comm > sal + (sal * 0.1);

-- 15 Display the name of all employees who have two Ls in their name and are in department 30 or their manager is 7782.

		   select  Ename from Emp
		   where (Deptno=30 or mgr_id= 7782) and  Ename like '%ll%' 
-- 16 Display the names of employees with experience of over 30 years and under 40 yrs.
 

                    select Ename, DATEDIFF(YEAR, Hiredate, GETDATE()) AS Experience
                        from Emp
						



-- 17 retrive the names of department in asceding and employee in desc order
 
		  select Dname from dept
		  order by Dname asc

		  select Ename from Emp
		  order by Ename desc

--18 find out experience of miller

		             select DATEDIFF(YEAR, hiredate, GETDATE()) AS 'exp'
                     from Emp
                      where Ename = 'Miller';