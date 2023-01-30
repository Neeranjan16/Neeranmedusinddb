using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppassingnment3._2
{
    class occurrences
    {

        static void Main(string[] args)
        {
            Console.Write("enter your word ");
            string Word = Console.ReadLine();

            Console.Write("Enter count: ");
            char Letter = Console.ReadLine()[0];

            int count = 0;
            for (int i = 0; i < Word.Length; i++)
            {
                if (Word[i] == Letter)
                {
                    count++;
                }
            }

            Console.WriteLine("LETTER '{0}' appears {1} times.", Letter, count);
            Console.Read();
        }
    }
}
