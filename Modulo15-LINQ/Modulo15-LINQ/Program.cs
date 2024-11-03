namespace Modulo15
{
    class Program
    {
        static void Main(string[] args)
        {
            //specific the data source
            int[] numbers = { 1, 2, 3, 4, 5, 6 };

            //Define the query expression
            IEnumerable<int> result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            //Execute the query
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            
        }
    }
}