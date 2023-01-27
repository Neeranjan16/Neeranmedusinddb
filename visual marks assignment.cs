using System;


namespace ConsoleAppmarksassign
{
    class Marks
    {
        public string name, branch, Class;
        public int sem;
        public long rollno;
        public int[] marks = new int[5];
        Marks(long rollno, string name, string Class, int sem, string branch, int[] marks)
        {
            this.rollno = rollno;
            this.name = name;
            this.Class = Class;
            this.sem = sem;
            this.branch = branch;
            this.marks = marks;
        }
        int GetMarks()
        {
            Console.Write("marks are");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(marks[i] + " ");
            }
            return 0;
        }
        int displayresult()
        {
            float avg = 0;
            for (int i = 0; i < 5; i++)
            {
                avg = avg + marks[i];
            }
            avg = avg / 5;
            Console.WriteLine();
            Console.Write(" average mark" + avg);
            int flag = 0;
            for (int i = 0; i < 5; i++)
            {
                if (marks[i] < 35)
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 1 || avg < 50)
            {
                Console.WriteLine(" Fail");
            }
            return 0;
        }
        int DisplayData()
        {
            Console.WriteLine();
            Console.WriteLine("Student detail");
            Console.WriteLine(rollno + " " + name + " " + Class + " " + sem + " " + branch);
            return 0;
        }


        static void Main(string[] args)
        {
            int[] arr = { 87,67,88,78,100 };
           Marks obj = new Marks(16, "NEERANJAN", "Btech", 4, "CSE", arr);
            Console.WriteLine("Student");
            obj.GetMarks();
            obj.displayresult();
            obj.DisplayData();
        }
    }
}

