using System;


namespace ConsoleAssignment_2
{
    
    
        class Bank

        {


            public static void Main(string[] args)
            {

                double balance = 1000000;
                Console.WriteLine("Customer Name");
                string name = Console.ReadLine();


                Console.WriteLine("Enter Your Account No:");
                double Acc = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter your Four Digit PIN");
                int PIN = Convert.ToInt32(Console.ReadLine());

                if (PIN == 0000)
                {
                    Console.WriteLine("Welcome" + name);

                }
                else
                {
                    Console.WriteLine("Invalid pin");
                }


                Console.WriteLine("Enter 0 to Balance , 1 to Withdraw and 2 to Deposit");
                int InputNo = Convert.ToInt32(Console.ReadLine());

                if (InputNo == 0)
                {
                    Console.WriteLine(" Balance " + balance);
                }
                else if (InputNo == 1)
                {
                    Console.WriteLine("Enter WithDraw Amount:");
                    int wD = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Withdraw Amount  " + wD);
                    Console.WriteLine("Current Balance " + (balance - wD));

                }
                else if (InputNo == 2)
                {
                    Console.WriteLine("Enter the Amount ");
                    int DA = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Amount: " + DA);
                    Console.WriteLine("Current Balance " + (balance + DA));
                }

                Console.Read();
            }
        }

    }




