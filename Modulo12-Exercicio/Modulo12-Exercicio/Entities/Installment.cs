using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo12_Exercicio.Entities
{
    class Installment
    {
        public DateOnly DueDate  { get; set; }
        public double Amount { get; set; }

        public Installment(DateOnly date, double amount) {
            DueDate = date;
            Amount = amount;
        }

        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy")
                + " - "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
