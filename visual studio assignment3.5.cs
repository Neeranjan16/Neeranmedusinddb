using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppassign3._5
{
    class Program
    {
        private double regno;
    private string name;
    private int feescharged;
    public double Regno
    {
        get
        {
            return regno;
        }
        set
        {
            regno = value;
        }
    }
    public string Name
    {
        get { 
                return name; 
            }
        set {
                name = value;
            }
    }
    public int Feescharged
    {
        get {
                return feescharged; 
            }
        set { 
                feescharged = value; 
            }
    }

    public static void Main(string[] args)
    {
        Program p = new Program();
        p.regno = 00001;
        p.name = "Neeranjan";
        p.feescharged = 15000;
        Console.WriteLine("Name: " + p.name);
        Console.WriteLine("Regno:" + p.regno);
        Console.WriteLine("Fees:" + p.feescharged);
        Console.ReadLine();



    }
}
}

