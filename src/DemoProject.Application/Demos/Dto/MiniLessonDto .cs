using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using DemoProject.Persons;

namespace DemoProject.Demos.Dto
{
    [AutoMapFrom(typeof(Lesson))]
    public class MiniLessonDto : EntityDto<long>
    {
        public MiniUserDto CreatorUser { get; set; }
        public string Title { get; set; }
    }
}
