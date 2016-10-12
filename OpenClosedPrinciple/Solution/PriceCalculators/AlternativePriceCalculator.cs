using OpenClosedPrinciple.Solution.PriceStrategies;
using SOLID.Shared.Models;
using System.Collections.Generic;
using System.Linq;

namespace OpenClosedPrinciple.Solution.PriceCalculators
{
    public class AlternativePriceCalculator : IPriceCalculator
    {
        private readonly IEnumerable<IPriceStrategy> _priceStrategies;

        public AlternativePriceCalculator(IEnumerable<IPriceStrategy> priceStrategies)
        {
            _priceStrategies = priceStrategies;
        }

        public decimal CalculatePrice(OrderItem item)
        {
            return _priceStrategies.First(r => r.IsMatch(item)).CalculatePrice(item);
        }
    }
}
