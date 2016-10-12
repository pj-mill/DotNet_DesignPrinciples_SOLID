using System.Collections.Generic;

namespace DependencyInversionPrinciple.Problem
{
    public class ProductRepository
    {
        public IEnumerable<Product> FindAll()
        {
            return new List<Product>();
        }
    }
}
