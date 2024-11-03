using Mod10_Exception_Exerc.Entities;
using Mod10_Exception_Exerc.Exceptions;
using System.Globalization;

namespace Exercicio_Modulo10_Exception
{
    class Program
    {
        static void Main (string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.WriteLine("Number");
                int number = int.Parse(Console.ReadLine());

                Console.WriteLine("holder");
                string holder = Console.ReadLine();

                Console.WriteLine("Initial balance");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Withdraw limit:");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, initialBalance, withdrawLimit);

                Console.WriteLine(account);

                Console.WriteLine("Enter amount for deposit");
                double deposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Deposit(deposit);

                Console.WriteLine(account);

                Console.WriteLine("Enter amout dor withdraw");
                double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                account.WithDraw(withdraw);

                Console.WriteLine(account);
            }
            catch (DomainException ex) {
                Console.WriteLine(ex.Message);
            }
              

            
        }
    }
}