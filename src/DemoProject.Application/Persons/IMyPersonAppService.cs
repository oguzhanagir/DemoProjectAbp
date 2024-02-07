using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Persons
{
    public interface IMyPersonAppService
    {
        Task<PersonCacheItem> GetPersonNameById(int id);
    }
}
