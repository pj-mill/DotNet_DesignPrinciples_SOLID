using OpenClosedPrinciple.Solution.PriceCalculators;
using SOLID.Shared.Models;
using System.Collections.Generic;

namespace OpenClosedPrinciple.Solution
{
    public class ShoppingCart
    {
        private readonly List<OrderItem> _orderItems;
        private readonly IPriceCalculator _priceCalculator;

        public ShoppingCart(IPriceCalculator priceCalculator)
        {
            _priceCalculator = priceCalculator;
            _orderItems = new List<OrderItem>();
        }

        public IEnumerable<OrderItem> OrderItems
        {
            get { return _orderItems; }
        }

        public string CustomerEmail { get; set; }

        public void Add(OrderItem orderItem)
        {
            _orderItems.Add(orderItem);
        }

        public decimal TotalAmount()
        {
            decimal total = 0m;
            foreach (OrderItem orderItem in OrderItems)
            {
                total += _priceCalculator.CalculatePrice(orderItem);
            }
            return total;
        }
    }
}
