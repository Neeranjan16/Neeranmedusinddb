using System;

namespace StudentDetail
{

    interface Student
    {
        int SId { get; set; }
        string Name { get; set; }
        void ShowDetails();
    }


    class Dayscholar : Student
    {
        public int SId { get; set; }
        public string Name { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine("DayScholar Detail: ");
            
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Student ID: " + SId);
        }
    }


    class Resident : Student
    {
        public int SId { get; set; }
        public string Name { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine("Resident Detail: ");
           
            Console.WriteLine("Name: " + Name);
             Console.WriteLine("SID: " + SId);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Dayscholar dayscholar = new Dayscholar();
            
            dayscholar.Name = "Vijay";
            dayscholar.SId = 16;


            Resident resident = new Resident();
           
            resident.Name = "Thalapathy";
            resident.SId = 67;


            Console.WriteLine("\n");
            dayscholar.ShowDetails();


            Console.WriteLine("\n");
            resident.ShowDetails();

            Console.Read();
        }
    }
}
