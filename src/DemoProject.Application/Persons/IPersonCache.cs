using Abp.Domain.Entities.Caching;

namespace DemoProject.Persons
{
    public interface IPersonCache : IMultiTenancyEntityCache<PersonCacheItem>
    {

    }
}
