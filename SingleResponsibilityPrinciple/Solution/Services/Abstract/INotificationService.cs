using SOLID.Shared.Models;

namespace SingleResponsibilityPrinciple.Solution.Services.Abstract
{
    public interface INotificationService
    {
        void NotifyCustomerOrderCreated(ShoppingCart cart);
    }
}
