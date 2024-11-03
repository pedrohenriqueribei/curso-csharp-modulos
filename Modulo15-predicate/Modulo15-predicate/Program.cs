using System.Drawing;

namespace Modulo15
{
    class Program
    {
        static void Main (string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //PREDICATE: Representa um método que recebe um objeto do tipo T e retorna um boleano

            Predicate<Product> pred = ProductMaior100;

            list.RemoveAll(pred);


            list.ForEach(Console.WriteLine);
        }

        public static bool ProductMaior100(Product product)
        {
            return product.Price > 100;
        }
    }
}
