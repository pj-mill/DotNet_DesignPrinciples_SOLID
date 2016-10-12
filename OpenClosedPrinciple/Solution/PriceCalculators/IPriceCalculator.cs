using SOLID.Shared.Models;

namespace OpenClosedPrinciple.Solution.PriceCalculators
{
    public interface IPriceCalculator
    {
        decimal CalculatePrice(OrderItem item);
    }
}
