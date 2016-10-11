using SOLID.Shared.Models;

namespace SingleResponsibilityPrinciple.Solution.Services.Abstract
{
    public interface IPaymentService
    {
        void ProcessCreditCard(PaymentDetails paymentDetails, decimal moneyAmount);
    }
}
