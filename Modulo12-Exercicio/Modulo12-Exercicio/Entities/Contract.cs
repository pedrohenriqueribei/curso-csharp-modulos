using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Modulo12_Exercicio.Entities
{
    class Contract
    {

        public int ContractNumber { get; set; }
        public DateOnly ContractDate { get; set; }
        public double ContractValue { get; set; }

        public List<Installment> Installments  { get; set; }

        public Contract(int contractNumber, DateOnly contractDate, double contractValue)
        {
            ContractNumber = contractNumber;
            ContractDate = contractDate;
            ContractValue = contractValue;
            Installments = new List<Installment>();
        }

        public void addInstallment (Installment installment)
        {
            Installments.Add(installment);
        }

        public override string ToString()
        {
            return "CONTRACT \n" +
                "Number: " + ContractNumber + "\n" +
                "Date  : " + ContractDate + "\n" +
                "Value : " + ContractValue.ToString("F2", CultureInfo.InvariantCulture)+ "\n";
        }
    }
}
