namespace Modulo15
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

            //ACT: representa um método void que recebe um ou mais argumentos

            list.ForEach(UpdatePrice);

            list.ForEach(Console.WriteLine);
        }

        static void UpdatePrice(Product product) {
            product.Price += product.Price * 0.1;
        }
    }
}
