using Modulo12_Exercicio.Entities;

namespace Modulo12_Exercicio.Service
{
    class ContractService
    {
        public PaymentService PaymentService;

        public ContractService(PaymentService paymentService)
        {
            PaymentService = paymentService;
        }

        public void ProcessContract (Contract contract, int months)
        {
            double basic = contract.ContractValue / months;


        }
    }
}
