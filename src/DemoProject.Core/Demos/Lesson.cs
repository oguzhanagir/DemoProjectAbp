using Abp.Domain.Entities;
using DemoProject.Authorization.Users;
using System;

namespace DemoProject.Demos
{
    public class Lesson : Entity<long>
    {
        public DateTime PublishDate { get; set; }
        public int CurrentState { get; set; }
        public string Image { get; set; }
        public virtual User CreatorUser { get; set; }
    }
}
