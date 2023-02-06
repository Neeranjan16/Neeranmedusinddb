using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ConsoleAppassignment5._1
{
    class Program
    {
        public static SqlConnection conn;
        public static SqlCommand Cmd;

        static void Main(string[] args)
        {
            selectdata();
            Console.Read();
        }
        static SqlConnection GetConnection()
        {
            conn = new SqlConnection("Data Source=DESKTOP-0IB3J5K\\SQLEXPRESS;Initial Catalog=neemedusindDB;" +
                "Integrated Security=true;");
            conn.Open();
            return conn;
        }


        static void selectdata()
        {
            conn = GetConnection();



            Console.WriteLine("Emp No:");
            int Empno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Emp Name");
            string EmpName = Console.ReadLine();

            Console.WriteLine("Emp Salary:");
            double EmpSal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Emp Type:");
            Char EmpType = Convert.ToChar(Console.ReadLine());

            Cmd = new SqlCommand("INSERT INTO Code_Employee VALUES(@empno, @empname, @empsal, @emptype)");




            Cmd.Parameters.AddWithValue("@empno", Empno);
            Cmd.Parameters.AddWithValue("@empname", EmpName);
            Cmd.Parameters.AddWithValue("@empsal", EmpSal);
            Cmd.Parameters.AddWithValue("@emptype", EmpType);
            Cmd.Connection = conn;

            int values = Cmd.ExecuteNonQuery();
            if (values > 0)
            {
                Console.WriteLine("Employee Details are Stored");
            }
            else
            {
                Console.WriteLine("Error please contact admin");
            }

            Cmd = new SqlCommand("select * from Code_employee where emsal >=25000", conn);

            conn.Close();



        }

    }
}
