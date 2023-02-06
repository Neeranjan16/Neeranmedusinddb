using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCollection1._2
{
    class Program
    {
        static void Main()
        {
            
            List<string> Book = new List<string>
            {
                "BOOKA",
                "BOOKB",
                "BOOKC",
                "BOOKD"
            };
            
            Console.WriteLine("Accessing the Generic List Element");
            foreach (var item in Book)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
