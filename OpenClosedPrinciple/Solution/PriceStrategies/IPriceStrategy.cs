using SOLID.Shared.Models;

namespace OpenClosedPrinciple.Solution.PriceStrategies
{
    public interface IPriceStrategy
    {
        bool IsMatch(OrderItem item);
        decimal CalculatePrice(OrderItem item);
    }
}
