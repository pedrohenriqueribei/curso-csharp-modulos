using ModuloGenerics.Entities;
using ModuloGenerics.Services;
using System.Globalization;

namespace Modulo13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.WriteLine("Enter N:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');

                string desc = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);

                Product product = new Product(desc, price);

               
                list.Add(product);
            }

            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Max(list);

            Console.WriteLine(max);


        }
    }
}
