using DependencyInversionPrinciple.Solution.Abstract;
using System.Collections.Generic;

namespace DependencyInversionPrinciple.Solution.Concrete
{
    public class ProductService : ServiceBase<Product>, IProductService
    {
        public ProductService(Repository<Product> repository) : base(repository)
        { }

        public IEnumerable<Product> GetProducts(IProductDiscountStrategy discountStrategy)
        {
            var products = base.GetAll();
            foreach (Product p in products)
            {
                p.AdjustPrice(discountStrategy);
            }
            return products;
        }
    }
}
