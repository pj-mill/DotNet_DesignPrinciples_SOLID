using LiskovSubstitutionPrinciple.Problem.PaymentModels;
using LiskovSubstitutionPrinciple.Shared.Enums;
using System;

namespace LiskovSubstitutionPrinciple.Problem.Factories
{
    public class PaymentFactory
    {
        public static PaymentBase GetPaymentService(PaymentServiceType serviceType)
        {
            switch (serviceType)
            {
                case PaymentServiceType.PayPal:
                    return new PayPalPayment();
                case PaymentServiceType.WorldPay:
                    return new WorldPayPayment();
                default:
                    throw new NotImplementedException("No such service.");
            }
        }
    }
}
