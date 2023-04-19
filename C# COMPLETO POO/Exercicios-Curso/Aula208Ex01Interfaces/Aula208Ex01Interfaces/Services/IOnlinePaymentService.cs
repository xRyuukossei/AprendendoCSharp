
namespace Aula208Ex01Interfaces.Services
{
    interface IOnlinePaymentService
    {
        public double PaymentFee(double amount);
        public double Interest(double amount, int mounths);
    }
}
