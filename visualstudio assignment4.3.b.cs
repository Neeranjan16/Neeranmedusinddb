using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppassignment4._3._2
{
    class trainticket
    {

        const int TotalFare = 300;


        public string Name { get; set; }
        public int Age { get; set; }

        static void Main(string[] args)
        {

            trainticket program = new trainticket();


            Console.Write("Please enter ur Name: ");
            program.Name = Console.ReadLine();

            Console.Write("Please enter ur Age: ");
            program.Age = int.Parse(Console.ReadLine());


            program.Concession();
        }


        public void Concession()
        {

            if (Age < 10)
            {
                Console.WriteLine("Name: " + Name + ", Ur total fare is " + (TotalFare * 1));
                Console.Read();
            }
            else if (Age >= 65)
            {
                Console.WriteLine("Name: " + Name + ", Ur total fare is " + (TotalFare * 0.5));
                Console.Read();
            }
            else
            {
                Console.WriteLine("Name: " + Name + ", Ur total fare is " + TotalFare);
                Console.Read();
            }
        }
    }
}
