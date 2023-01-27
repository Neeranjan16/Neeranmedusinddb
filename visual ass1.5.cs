using System;


namespace ConsoleApp_ass1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[10];

            
            int sum = 0;
            int min = int.MaxValue;
            int max = int.MinValue;

            
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter the mark " + (i + 1) + ": ");
                marks[i] = int.Parse(Console.ReadLine());

                
                sum += marks[i];
                if (marks[i] < min)
                {
                    min = marks[i];
                }
                if (marks[i] > max)
                {
                    max = marks[i];
                }
            }

            
            double average = (double)sum / 10;

            // Print results
            Console.WriteLine("Total: " + sum);
            Console.WriteLine("Average: " + average);
            Console.WriteLine("Minimum: " + min);
            Console.WriteLine("Maximum: " + max);
            Console.Read();
        }
    }
}
