using System;


namespace MyProject
{
    class CheckEqual
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st Num :");
            int val1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd Num :");
            int val2 = Convert.ToInt32(Console.ReadLine());

            if (val1 == val2)
            {
                Console.WriteLine("Both " + val1 + " and " + val2 + " are equal");
            }
            else
            {
                Console.WriteLine("Entered numbers are Not Equal!!");
            }

            Console.Read();

        }
    }
}



