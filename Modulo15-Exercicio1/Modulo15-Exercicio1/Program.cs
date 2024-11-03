using Modulo15_Exercicio1;
using System.Globalization;

namespace Modulo15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter path");
            //string path = Console.ReadLine();
            string path = "C:\\Users\\Pedro\\Desktop\\Projetos C#\\Modulo15-Exercicio1\\in.txt";

            List<Product> products = new List<Product>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    products.Add(new Product(name, price));
                }
            }

            var avg = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine(avg.ToString("F2", CultureInfo.InvariantCulture));

            var names = products.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}