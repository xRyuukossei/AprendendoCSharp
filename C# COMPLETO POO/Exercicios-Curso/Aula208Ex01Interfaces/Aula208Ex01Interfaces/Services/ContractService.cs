using Aula208Ex01Interfaces.Entities;

namespace Aula208Ex01Interfaces.Services
{
    internal class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int mounths)
        {
            double quota = contract.TotalValue / mounths;
            for (int i = 1; i <= mounths; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updatedQuota = quota + _onlinePaymentService.Interest(quota, i);
                double totalQuota = updatedQuota + _onlinePaymentService.PaymentFee(updatedQuota);
                contract.AddInstallment(new Installment(date, totalQuota));
            }
        }
    }
}
