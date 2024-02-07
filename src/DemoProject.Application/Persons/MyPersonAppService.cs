using Abp.Dependency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Persons
{
    public class MyPersonAppService : DemoProjectAppServiceBase, IMyPersonAppService, ITransientDependency
    {
        private readonly IPersonCache _personCache;

        public MyPersonAppService(IPersonCache personCache)
        {
            _personCache = personCache;
        }

        public async Task<PersonCacheItem> GetPersonNameById(int id)
        {
            var result = await _personCache.GetAsync(id);
            return result;
        }
    }
}
