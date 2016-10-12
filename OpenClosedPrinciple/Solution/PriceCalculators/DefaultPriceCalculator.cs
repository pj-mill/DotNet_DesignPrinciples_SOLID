using OpenClosedPrinciple.Solution.PriceStrategies;
using SOLID.Shared.Models;
using System.Collections.Generic;
using System.Linq;

namespace OpenClosedPrinciple.Solution.PriceCalculators
{
    public class DefaultPriceCalculator : IPriceCalculator
    {
        private readonly List<IPriceStrategy> _pricingRules;

        public DefaultPriceCalculator()
        {
            _pricingRules = new List<IPriceStrategy>();
            _pricingRules.Add(new PricePerKiloStrategy());
            _pricingRules.Add(new PricePerUnitStrategy());
            _pricingRules.Add(new SpecialPriceStrategy());
            _pricingRules.Add(new BuyThreeGetOneFreeStrategy());
        }

        public decimal CalculatePrice(OrderItem item)
        {
            return _pricingRules.First(r => r.IsMatch(item)).CalculatePrice(item);
        }
    }
}
