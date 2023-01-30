
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignmentz
{
    class firstasecondname 
    {
        public void str(string Fname, string Sname)
        {
            Console.WriteLine("Enter ur 1st Name");
            Console.WriteLine("Enter ur 2nd Name");
            Fname = Console.ReadLine();
            Sname = Console.ReadLine();
            Fname = Fname.ToUpper();
            Sname = Sname.ToUpper();
            Console.WriteLine(Fname);
            Console.WriteLine(Sname);
        }
        static void Main(string[] args)
        {
            firstasecondname p = new firstasecondname();
            p.str("Fname", "Sname");
            Console.ReadLine();


        }
    }
}
