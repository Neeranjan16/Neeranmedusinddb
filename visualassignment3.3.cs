using System;


namespace ConsoleAppassign3._3
{
    class sales
    {
        public int Salesno, Qty, price;
        public double productno, totalamount;
        public string dateofsale;
        public sales(int salesno, double productno, int Qty, string dateofsale)
        {
            this.Salesno = salesno;
            this.productno = productno;
            this.Qty = Qty;
            this.dateofsale = dateofsale;
        }
        public void details(int Qty, int price)
        {
            totalamount = price;
            Console.WriteLine("Total amount");
            Console.WriteLine(totalamount);
        }
        static void Main(string[] args)
        {
            sales p = new sales(43, 22, 822, "21/2/2023");
            p.details(1, 666);
            Console.ReadLine();

        }
    }
}
