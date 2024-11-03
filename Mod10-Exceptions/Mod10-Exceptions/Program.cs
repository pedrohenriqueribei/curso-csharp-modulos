using Mod10_Exceptions.Entities;
using Mod10_Exceptions.Exceptions;


namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Room Number");
                int number = int.Parse(Console.ReadLine());

                Console.WriteLine("Check-int date: (dd/MM/yyyy)");
                DateTime checkin = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Check-out date: (dd/MM/yyyy)");
                DateTime checkout = DateTime.Parse(Console.ReadLine());






                Reservation reservation = new Reservation(number, checkin, checkout);

                Console.WriteLine(reservation);

            }
            catch (DomainException ex)
            {
                Console.WriteLine("Erro na Reserva: " + ex.ToString());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Erro com Formato de Numero" + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro inesperado: " + ex.ToString());
            }
            Console.WriteLine();


        }
    }
}