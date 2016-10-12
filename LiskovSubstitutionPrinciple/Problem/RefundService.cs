using LiskovSubstitutionPrinciple.Problem.Factories;
using LiskovSubstitutionPrinciple.Problem.PaymentModels;
using LiskovSubstitutionPrinciple.Shared.Enums;

namespace LiskovSubstitutionPrinciple.Problem
{
    /*
     * Problems
    (1) We cannot simply take the payment object returned by the factory, we need to check its type – 
        therefore we cannot substitute the subtype for its base type, hence we break LSP. Such if-else statements 
        where you branch your logic based on some object’s type are telling signs of LSP violation.
    (2) We need to extend the if-else statements as soon as a new provider is implemented, which also violates the Open-Closed Principle
    (3) We need to extend the 'serviceResponse.Contains' code as well if a new payment provider returns a different response, such as “OK”
    (4) The client, i.e.the RefundService object needs to intimately know about the different types of payment providers and their internal 
        setup which greatly increases coupling.
    (5) The client needs to know how to interpret the string responses from the services and that is not the correct approach – 
        the individual services should be the only ones that can do that
   */

    public class RefundService
    {
        public bool Refund(PaymentServiceType paymentServiceType, decimal amount, string transactionId)
        {
            bool refundSuccess = false;
            PaymentBase payment = PaymentFactory.GetPaymentService(paymentServiceType);
            if ((payment as PayPalPayment) != null)
            {
                ((PayPalPayment)payment).AccountName = "Andras";
                ((PayPalPayment)payment).Password = "Passw0rd";
            }
            else if ((payment as WorldPayPayment) != null)
            {
                ((WorldPayPayment)payment).AccountName = "Andras";
                ((WorldPayPayment)payment).Password = "Passw0rd";
                ((WorldPayPayment)payment).ProductId = "ABC";
            }

            string serviceResponse = payment.Refund(amount, transactionId);

            if (serviceResponse.Contains("Auth") || serviceResponse.Contains("Success"))
            {
                refundSuccess = true;
            }

            return refundSuccess;
        }
    }
}
