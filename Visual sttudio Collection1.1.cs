using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCollection
{
    class Product
    {
        int ProductId;
        string ProductName;
        int Price;

        static void Main()
        {
            List<Product> Productlist = new List<Product>()
            {
                new Product(){ProductId=11, ProductName="hp",Price=5555},
                new Product(){ProductId=12, ProductName="Dell",Price=6666},
                new Product(){ProductId=13, ProductName="MAC",Price=9999},
                new Product(){ProductId=14, ProductName="Oneplus",Price=10000},
                new Product(){ProductId=15, ProductName="Iphone",Price=95000},
                new Product(){ProductId=16, ProductName="Samsung",Price=5500},
                new Product(){ProductId=17, ProductName="Redmi",Price=7000},
                new Product(){ProductId=18, ProductName="Realme",Price=5000},
                new Product(){ProductId=19, ProductName="vivo",Price=9000},
                new Product(){ProductId=20, ProductName="IQ",Price=9500}
            };




            //sort the Products on Price

            var sortedstdlist = Productlist.OrderByDescending(n => n.Price);

            foreach (var item in sortedstdlist)
            {
                Console.WriteLine(item.ProductId + " " + item.ProductName + " " + item.Price);
            }
            Console.Read();
        }
    }
}
