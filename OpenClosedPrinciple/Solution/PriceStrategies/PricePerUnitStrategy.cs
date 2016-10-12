using SOLID.Shared.Models;

namespace OpenClosedPrinciple.Solution.PriceStrategies
{
    public class PricePerUnitStrategy : IPriceStrategy
    {
        public bool IsMatch(OrderItem item)
        {
            return item.Identifier.StartsWith("Each");
        }

        public decimal CalculatePrice(OrderItem item)
        {
            return item.Quantity * item.Price;
        }
    }
}
