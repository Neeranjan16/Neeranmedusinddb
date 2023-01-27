using System;

namespace ConsoleApp_assignment_1._2
{
   
             class PosorNeg
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter a number");

                int number = Convert.ToInt32(Console.ReadLine());

                if (number >= 0)
                {
                    Console.WriteLine("The num is Pos");

                }
                else
                {
                    Console.WriteLine("The num is Neg");
                }

                Console.Read();
            }
             }
}
