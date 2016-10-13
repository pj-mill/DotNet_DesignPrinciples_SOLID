using System.Collections.Generic;

namespace DependencyInversionPrinciple.Solution.Abstract
{
    public class ServiceBase<T> where T : EntityBase
    {
        protected Repository<T> _repository;

        public ServiceBase(Repository<T> repository)
        {
            _repository = repository;
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _repository.FindAll();
        }
    }
}
