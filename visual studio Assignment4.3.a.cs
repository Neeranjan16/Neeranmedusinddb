using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment4._3._1
{
    public class library
    {
        private const int TFare = 500;

        public static void Concession(int Age)
        {
            if (Age <= 5)
            {
                Console.WriteLine("Little Champs :Free Ticket");
            }
            else if (Age > 60)
            {
                int concession = (int)(TFare * 0.3);
                int finalFare = TFare - concession;
                Console.WriteLine("Senior Citizen:" + finalFare);
            }
            else
            {
                Console.WriteLine("Ticket Booked: " + TFare);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            library.Concession(age);
            Console.ReadLine();
        }
    }
}
