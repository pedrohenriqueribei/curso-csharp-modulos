using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DateTime dt = new DateTime(2024, 11, 2, 8, 10, 45);


        Console.WriteLine(dt);
        Console.WriteLine(dt.Elapsed());
    }
}