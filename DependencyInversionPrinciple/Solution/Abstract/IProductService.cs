using DependencyInversionPrinciple.Solution.Concrete;
using System.Collections.Generic;

namespace DependencyInversionPrinciple.Solution.Abstract
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts(IProductDiscountStrategy discountStrategy);
    }
}
