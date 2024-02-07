using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using DemoProject.Authorization.Users;

namespace DemoProject.Demos.Dto
{
    [AutoMapFrom(typeof(User))]
    public class MiniUserDto : EntityDto<long>
    {
        public string FullName { get; set; }
        public string ActiveUnitChart { get; set; }
        public string Image { get; set; }
    }
}
