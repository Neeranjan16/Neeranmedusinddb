using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppasssign4_1

{
    public abstract class Student
    {
        public string Name { get; set; }
        public int SId { get; set; }
        public int Grade { get; set; }

        public abstract bool Pass(int grade);
    }

    public class Under_Grad : Student
    {
        public override bool Pass(int grade)
        {
            return grade > 70;
        }
    }

    public class Grad : Student
    {
        public override bool Pass(int grade)
        {
            return grade > 80;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Under_Grad UG = new Under_Grad()
            {
                Name = "Neeranjan",
                SId = 16,
                Grade = 99
            };

            Grad G = new Grad()
            {
                Name = "Nikhil",
                SId = 17,
                Grade = 62
            };

            Console.WriteLine($"Undergrad grade : {UG.Pass(UG.Grade)}");
            Console.WriteLine($"Grad grade: {G.Pass(G.Grade)}");
            Console.Read();
        }
    }
}