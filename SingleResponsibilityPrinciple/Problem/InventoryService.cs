using SOLID.Shared.Exceptions;

namespace SingleResponsibilityPrinciple.Problem
{
    public class InventoryService
    {
        public void Reserve(string identifier, int quantity)
        {
            throw new InsufficientInventoryException();
        }
    }
}
