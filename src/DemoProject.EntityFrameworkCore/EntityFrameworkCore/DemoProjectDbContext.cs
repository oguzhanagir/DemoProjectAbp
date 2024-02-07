using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using DemoProject.Authorization.Roles;
using DemoProject.Authorization.Users;
using DemoProject.MultiTenancy;
using DemoProject.Persons;
using DemoProject.Demos;

namespace DemoProject.EntityFrameworkCore
{
    public class DemoProjectDbContext : AbpZeroDbContext<Tenant, Role, User, DemoProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Person> Persons { get; set; }  
        public DbSet<Lesson> Lessons { get; set; }  
        public DemoProjectDbContext(DbContextOptions<DemoProjectDbContext> options)
            : base(options)
        {
        }
    }


}
