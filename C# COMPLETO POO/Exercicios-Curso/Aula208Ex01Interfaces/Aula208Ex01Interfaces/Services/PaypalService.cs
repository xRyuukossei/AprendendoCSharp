
namespace Aula208Ex01Interfaces.Services
{
    internal class PaypalService : IOnlinePaymentService
    {
        private double _paypalFee = 0.02;
        private double _mounthInterest = 0.01;

        public double PaymentFee(double amount)
        {
            return amount * _paypalFee;
        }
        public double Interest(double amount, int mounths)
        {
            return (amount * mounths) * _mounthInterest;
        }
    }
}
