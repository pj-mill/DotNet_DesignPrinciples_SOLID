using LiskovSubstitutionPrinciple.Problem.PaymentWebServices;

namespace LiskovSubstitutionPrinciple.Problem.PaymentModels
{
    public class PayPalPayment : PaymentBase
    {
        public string AccountName { get; set; }
        public string Password { get; set; }

        public override string Refund(decimal amount, string transactionId)
        {
            PaypalWebService payPalWebService = new PaypalWebService();
            string token = payPalWebService.GetTransactionToken(AccountName, Password);
            string response = payPalWebService.MakeRefund(amount, transactionId, token);
            return response;
        }
    }
}
