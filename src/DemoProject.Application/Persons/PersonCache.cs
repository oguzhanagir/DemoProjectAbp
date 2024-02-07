using Abp.Dependency;
using Abp.Domain.Entities.Caching;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.Runtime.Caching;

namespace DemoProject.Persons
{
    public class PersonCache : MayHaveTenantEntityCache<Person, PersonCacheItem>, IPersonCache, ITransientDependency
    {
        public PersonCache(ICacheManager cacheManager, IRepository<Person> repository,IUnitOfWorkManager unitOfWorkManager)
            : base(cacheManager,unitOfWorkManager,repository)
        {

        }
    }
}
