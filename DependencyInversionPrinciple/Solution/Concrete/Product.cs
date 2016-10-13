using DependencyInversionPrinciple.Solution.Abstract;

namespace DependencyInversionPrinciple.Solution.Concrete
{
    public class Product : EntityBase
    {
        public void AdjustPrice(IProductDiscountStrategy productDiscount)
        { }
    }
}
