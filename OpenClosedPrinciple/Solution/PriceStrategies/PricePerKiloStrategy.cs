using SOLID.Shared.Models;

namespace OpenClosedPrinciple.Solution.PriceStrategies
{
    public class PricePerKiloStrategy : IPriceStrategy
    {
        public bool IsMatch(OrderItem item)
        {
            return item.Identifier.StartsWith("Weight");
        }

        public decimal CalculatePrice(OrderItem item)
        {
            return item.Quantity * item.Price / 1000;
        }
    }
}
