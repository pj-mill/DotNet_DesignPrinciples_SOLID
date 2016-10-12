using SOLID.Shared.Models;

namespace OpenClosedPrinciple.Solution.PriceStrategies
{
    public class BuyThreeGetOneFreeStrategy : IPriceStrategy
    {
        public bool IsMatch(OrderItem item)
        {
            return item.Identifier.StartsWith("Buy3OneFree");
        }

        public decimal CalculatePrice(OrderItem item)
        {
            decimal total = 0m;
            total += item.Quantity * item.Price;
            int setsOfThree = item.Quantity / 3;
            total -= setsOfThree * item.Price;
            return total;
        }
    }
}
