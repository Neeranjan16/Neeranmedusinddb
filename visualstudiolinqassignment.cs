﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplinq1
{
    using System;
    using System.Collections.Generic;

    class Employees
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
    }

    class consoleApplinq1
    {
        static void Main(string[] args)
        {
            List<Employees> empList = new List<Employees>
            {
                new Employees { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = new DateTime(1984, 11, 16), DOJ = new DateTime(2011, 6, 8), City = "Mumbai" },
                new Employees { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1984, 8, 20), DOJ = new DateTime(2012, 7, 7), City = "Mumbai" },
                new Employees { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 4, 12), City = "Pune" },
                new Employees { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1990, 6, 3), DOJ = new DateTime(2016, 2, 2), City = "Pune" },
                new Employees { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1991, 3, 8), DOJ = new DateTime(2016, 2, 2), City = "Mumbai" },
                new Employees { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = new DateTime(1989, 11, 7), DOJ = new DateTime(2014, 8, 8), City = "Chennai" },
                new Employees { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = new DateTime(1989, 12, 2), DOJ = new DateTime(2015, 6, 1), City = "Mumbai" },
                new Employees { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014, 11, 6), City = "Chennai" },
                new Employees { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = new DateTime(1992, 8, 12), DOJ = new DateTime(2014, 12, 3), City = "Chennai" },
                new Employees { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(12 / 4 / 1991), DOJ = new DateTime(2 / 01 / 2016), City = "Pune" }

            };



            //1. Details of all Employees
            var allEmployees = from e in empList
                               select e;

            Console.WriteLine("Detail of all the Employee:");
            Console.WriteLine("EmployeeID\tFirstName\tLastName\tTitle\tDOB\t\tDOJ\t\tCity");

            foreach (var emp in allEmployees)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t{4}\t{5}\t{6}",
                     emp.EmployeeID.ToString(), emp.FirstName, emp.LastName, emp.Title,
                    emp.DOB.ToShortDateString(), emp.DOJ.ToShortDateString(), emp.City);
            }


            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");

            

            var Emp_Not_in_Mumbai = from emp in empList
                                    where emp.City != "Mumbai"
                                    select emp;

            Console.WriteLine("Detail of all Employee whose location is not in Mumbai:");
            Console.WriteLine("EmployeeID\tFirstName\tLastName\tTitle\tDOB\t\tDOJ\t\tCity");
            foreach (var emp in Emp_Not_in_Mumbai)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t{4}\t{5}\t{6}",
                    emp.EmployeeID, emp.FirstName, emp.LastName, emp.Title,
                    emp.DOB.ToShortDateString(), emp.DOJ.ToShortDateString(), emp.City);
            }

            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");


            var AsstManagers = from emp in empList
                               where emp.Title == "AsstManager"
                               select emp;

            Console.WriteLine("Detail of all Employee whose title is AsstManager:");
            Console.WriteLine("EmployeeID\tFirstName\tLastName\tTitle\tDOB\t\tDOJ\t\tCity");
            foreach (var emp in AsstManagers)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t{4}\t{5}\t{6}",
                    emp.EmployeeID, emp.FirstName, emp.LastName, emp.Title,
                    emp.DOB.ToShortDateString(), emp.DOJ.ToShortDateString(), emp.City);
            }
            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");



            

            var lastNameStartsWithS = from emp in empList
                                      where emp.LastName.StartsWith("S")
                                      select emp;

            Console.WriteLine("Detail of all Employee whose last name starts with 'S':");
            Console.WriteLine("EmployeeID\tFirstName\tLastName\tTitle\tDOB\t\tDOJ\t\tCity");
            foreach (var emp in lastNameStartsWithS)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t{4}\t{5}\t{6}",
                    emp.EmployeeID, emp.FirstName, emp.LastName, emp.Title,
                    emp.DOB.ToShortDateString(), emp.DOJ.ToShortDateString(), emp.City);
            }

            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");

           
            var DOJ_befor_2015 = from emp in empList
                                 where emp.DOJ < new DateTime(2015, 1, 1)
                                 select emp;

            Console.WriteLine("Detail of all Employee who joined before 1/1/2015:");
            Console.WriteLine("EmployeeID\tFirstName\tLastName\tTitle\tDOB\t\tDOJ\t\tCity");
            foreach (var emp in DOJ_befor_2015)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t{4}\t{5}\t{6}",
                    emp.EmployeeID, emp.FirstName, emp.LastName, emp.Title,
                    emp.DOB.ToShortDateString(), emp.DOJ.ToShortDateString(), emp.City);
            }

            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
            

            var Born_After_1990 = from e in empList
                                  where e.DOB > new DateTime(1990, 1, 1)
                                  select e;

            Console.WriteLine("Detail of all Employees born after 1/1/1990:");
            Console.WriteLine("EmployeeID\tFirstName\tLastName\tTitle\tDOB\t\tDOJ\t\tCity");
            foreach (var emp in Born_After_1990)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t{4}\t{5}\t{6}",
                    emp.EmployeeID, emp.FirstName, emp.LastName, emp.Title,
                    emp.DOB.ToShortDateString(), emp.DOJ.ToShortDateString(), emp.City);
            }

            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");


            

            var Cons_Or_Assoc = from emp in empList
                                where emp.Title == "Consultant" || emp.Title == "Associate"
                                select emp;

            Console.WriteLine("Detail of all Employee who are either Consultant or Associate:");
            Console.WriteLine("EmployeeID\tFirstName\tLastName\tTitle\tDOB\t\tDOJ\t\tCity");
            foreach (var emp in Cons_Or_Assoc)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t{4}\t{5}\t{6}",
                    emp.EmployeeID, emp.FirstName, emp.LastName, emp.Title,
                    emp.DOB.ToShortDateString(), emp.DOJ.ToShortDateString(), emp.City);
            }

            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");



            int TotalNo_OfEmployees = (from emp in empList
                                       select emp).Count();

            Console.WriteLine("Total number of Employee: {0}", TotalNo_OfEmployees);

            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");



            int No_Of_EmployeesInChn = (from emp in empList
                                        where emp.City == "Chennai"
                                        select emp).Count();

            Console.WriteLine("Total no of Employee in Chennai: {0}", No_Of_EmployeesInChn);

            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
          

            int Maximum_ID = empList.Max(e => e.EmployeeID);

            Console.WriteLine("Highest Employee ID: {0}", Maximum_ID);

            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");

            

            int Not_Assoc = empList.Count(e => e.Title != "Associate");

            Console.WriteLine("Number of Employee whose designation is not Associate: {0}", Not_Assoc);

            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");

           

            var result = empList.GroupBy(emp => emp.City)
            .Select(group => new { City = group.Key, Count = group.Count() });

            Console.WriteLine("Employee count based on City:");
            foreach (var item in result)
            {
                Console.WriteLine("{0}: {1}", item.City, item.Count);
            }

            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");

           

            var Joined_After_2015 = empList.Where(x => x.DOJ > new DateTime(2015, 1, 1)).Count();
            Console.WriteLine("Total no of Employee who have joined after 1/1/2015: " + Joined_After_2015);

            Console.ReadKey();
        }
    }
}
