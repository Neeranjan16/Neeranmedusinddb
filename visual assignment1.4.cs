using System;
using System;


namespace consoleappass1._4
{
    class Arrays
    {
        static void Main(string[] args)
        {

            int[] arr = { 50, 30, 76, 75, 67, 97 };

            int i = 0;
            int sum = 0;
            float avg;

            for (i = 0; i < arr.Length; i++)
            {                                             
                sum += arr[i];
            }

            avg = (float)sum / arr.Length;                  

            Console.WriteLine("Avg Array Elements: " + avg);



            Console.Read();
        }
    }
}
