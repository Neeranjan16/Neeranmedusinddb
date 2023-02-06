using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppstructures
{
    struct Book
    {
        private string Title;
        private string Author;
        private string Subject;
        private int Book_Id;

        public void GetValues(string T, string A, string S, int Id)
        {
            Title = T;;
            Author = A;
            Subject = S;
            Book_Id = Id;
        }

        public void ShowValues()
        {
            Console.WriteLine("Title: {0}", Title);
            Console.WriteLine("Author: {0}", Author);
            Console.WriteLine("Subject: {0}", Subject);
            Console.WriteLine("Book ID: {0}", Book_Id);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book BookA = new Book();
            Book BookB = new Book();
            Book BookC = new Book();
            Book BookD = new Book();

            BookA.GetValues("Vikram", "Lokesh kanagaraj", "Once upon their lived a ghost", 230);
            BookB.GetValues("Jai bhim", "TJ Gnanavel", "A real incident in 1990's", 456);
            BookC.GetValues("Theri", "Atlee", "A policeman's story", 763);
            BookD.GetValues("Harry potter", "David yates", "A Magical world", 768);


            Console.WriteLine("Book A:");
            BookA.ShowValues();

            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("Book B:");
            BookB.ShowValues();

            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("Book C:");
            BookC.ShowValues();

            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("Book D:");
            BookD.ShowValues();

            Console.ReadLine();
        }
    }
}
