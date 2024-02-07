using Abp.AutoMapper;

namespace DemoProject.Persons
{
    [AutoMapFrom(typeof(Person))]
    public class PersonCacheItem
    {
        public string Name { get; set; }
    }
}
