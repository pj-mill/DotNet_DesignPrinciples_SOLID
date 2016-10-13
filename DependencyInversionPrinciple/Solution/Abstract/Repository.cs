using System.Collections.Generic;

namespace DependencyInversionPrinciple.Solution.Abstract
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        public virtual IEnumerable<T> FindAll()
        {
            return new List<T>();
        }
    }
}
