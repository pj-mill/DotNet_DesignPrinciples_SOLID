namespace LiskovSubstitutionPrinciple.Problem.PaymentModels
{
    public abstract class PaymentBase
    {
        public abstract string Refund(decimal amount, string transactionId);
    }
}
