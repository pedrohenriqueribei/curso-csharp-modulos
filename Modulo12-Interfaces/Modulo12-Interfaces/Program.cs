using Modulo12_Interfaces.Entitities;
using Modulo12_Interfaces.Service;
using System.Globalization;

namespace Modulo12
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Enter rental data: ");
            Console.WriteLine("Model car: ");
            string car = Console.ReadLine();

            Console.WriteLine("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.WriteLine("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(car));

            Console.WriteLine("Enter price per hour");
            double hour = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter price per day");
            double day = double.Parse(Console.ReadLine());

            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE:");
            Console.WriteLine(carRental.Invoice);
        }
    }
}