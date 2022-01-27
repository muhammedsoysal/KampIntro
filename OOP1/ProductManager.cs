using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager
    {
        //encapsulation 
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        public int topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public void topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1+sayi2);
        }
    }
}
