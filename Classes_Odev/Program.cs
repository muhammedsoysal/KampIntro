using System;

namespace Classes_Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ID = 1;
            product1.Name = "Monster Notebook";
            product1.UnitPrice = 15.4999;
            product1.Detail = "16 GB Ram 500GB SSD";

            Product product2 = new Product();
            product2.ID = 2;
            product2.Name = "Iphone 13";
            product2.UnitPrice = 16.299;
            product2.Detail = "256 Gb";

            Product []products=new Product[] { product1, product2 };
            foreach (var product in products)
            {
                Console.WriteLine(product.ID);
                Console.WriteLine(product.Name);
                Console.WriteLine(product.UnitPrice);
                Console.WriteLine(product.Detail);
                Console.WriteLine("--------------------------");
            }   
        }
        class Product
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public double UnitPrice { get; set; }
            public string Detail { get; set; }
        }
    }
}