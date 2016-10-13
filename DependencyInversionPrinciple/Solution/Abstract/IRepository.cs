using System.Collections.Generic;

namespace DependencyInversionPrinciple.Solution.Abstract
{
    public interface IRepository<T> where T : EntityBase
    {
        IEnumerable<T> FindAll();
    }
}
