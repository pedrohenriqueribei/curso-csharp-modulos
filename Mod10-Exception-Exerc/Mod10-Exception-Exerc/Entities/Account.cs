
using Mod10_Exception_Exerc.Exceptions;
using System.Globalization;

namespace Mod10_Exception_Exerc.Entities
{
    class Account
    {
        public int Id { get; set; } 
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int id, string holder, double balance, double withDrawLimit)
        {
            Id = id;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void WithDraw (double amount)
        {
            if (Balance < amount)
            {
                throw new DomainException("Você não tem saldo suficiente");
            }

            if (amount > WithDrawLimit)
            {
                throw new DomainException("Operação não autorizada");
            }
                Balance -= amount;
        }

        public override string ToString()
        {
            return "Number: " + Id + "\n"
                + "Holder: " + Holder + "\n"
                + "Balance: " + Balance.ToString("F2", CultureInfo.InvariantCulture) + "\n"
                + "WithDraw: " + WithDrawLimit.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
