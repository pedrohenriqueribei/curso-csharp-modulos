namespace Modulo15_Func
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //FUNC: representa um método que recebe zero ou mais argumento e retorna um valor T

            Func<Product, string> func = NameUpper;

            List<string> result = list.Select(func).ToList();

            result.ForEach(Console.WriteLine);
        }

        static string NameUpper(Product product)
        {
            return product.Name.ToUpper();
        }
    }
}

