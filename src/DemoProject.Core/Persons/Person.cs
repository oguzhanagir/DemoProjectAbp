using Abp.Domain.Entities;

namespace DemoProject.Persons
{
    public class Person : Entity, IMayHaveTenant
    {
        public string Name { get; set; }

        public int Age { get; set; }
        public int? TenantId { get; set; }
    }

}
