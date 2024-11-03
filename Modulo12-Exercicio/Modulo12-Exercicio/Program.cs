using Modulo12_Exercicio.Entities;
using System.Globalization;

namespace Modulo12
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.WriteLine("Number");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Date: (dd/MM/yyyy)");
            DateOnly dateOnly = DateOnly.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine("Contract value");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Enter number of installments");
            int installments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, dateOnly, number);

            


        }
    }
}
