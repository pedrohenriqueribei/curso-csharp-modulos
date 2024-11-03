using Modulo13_Hash_Product.Entities;
using System.Diagnostics;

namespace Modulo13
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 9000.0));
            a.Add(new Product("Notebook", 1350.9));

            Product prod = new Product("Notebook", 1350.9);
            Console.WriteLine(a.Contains(prod));
        }
    }
}