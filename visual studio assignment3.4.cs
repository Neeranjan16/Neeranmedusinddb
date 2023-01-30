using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppassign3._4
{
    class scholar
    {
        public void merit(int m, float n)
        {
            Console.WriteLine("enter your mark");

            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your fees");
            n = Convert.ToInt32(Console.ReadLine());
            if (m >= 70 && m <= 80)
            {
                Console.WriteLine("Scholarship:" + 0.2 * n);

            }
            else if (m > 80 && m <= 90)
            {
                Console.WriteLine("Scholarship:" + 0.3 * n);

            }
            else if (m > 90)
            {
                Console.WriteLine("Scholarship:" + 0.5 * n);

            }

        }
        static void Main(string[] args)
        {
            scholar p = new scholar();
            p.merit(99, 100000);
            Console.ReadLine();


        }
    }
}
