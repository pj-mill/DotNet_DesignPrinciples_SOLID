namespace LiskovSubstitutionPrinciple.Problem.PaymentWebServices
{
    public class PaypalWebService
    {
        public string GetTransactionToken(string username, string password)
        {
            return "Hello from PayPal";
        }

        public string MakeRefund(decimal amount, string transactionId, string token)
        {
            return "Auth";
        }
    }
}
