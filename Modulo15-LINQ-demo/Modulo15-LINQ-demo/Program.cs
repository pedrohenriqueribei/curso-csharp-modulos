using Modulo15_LINQ_demo.Entities;
using System.Security.Cryptography;

namespace Modulo15_LINQ_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computer", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

            List<Category> c = new List<Category>() { c1, c2, c3 };

            List<Product> products = new List<Product>() {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            Console.WriteLine();
           

            IEnumerable<Product> r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900);

            Print("TIER 1 AND PRICE < 900", r1);


            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("NAMES OF PRODUTCS FROM TOOLS", r2);

            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, Category = p.Category.Name });
            Print("NAMES STARTED WITH 'C'", r3);

            IEnumerable<Product> r4 = products.Where(p => p.Category.Tier == 1).OrderByDescending(p => p.Price).ThenBy(p => p.Name);
            Print("TIER 1 ORDER BY PRICE", r4);

            var r5 = r4.Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE SKIP 2 TAKE 4", r5);

            var r6 = products.FirstOrDefault();
            Console.WriteLine("FIRST: " + r6);

            var r7 = products.Where(p => p.Price > 30000.0);
            Console.WriteLine("MORE: " + r7);


            var r16 = products.GroupBy(p => p.Category);

            Console.WriteLine();
            foreach(IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine("Category " + group.Key.Name + ":");

                foreach(Product product in group)
                {
                    Console.WriteLine(product.Name);
                }

                Console.WriteLine();
            }
        }

        static void Print<T>(string msg, IEnumerable<T> collection)
        {
            Console.WriteLine(msg);

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }

}
