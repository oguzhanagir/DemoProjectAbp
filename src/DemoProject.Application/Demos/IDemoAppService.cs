using Abp.Application.Services.Dto;
using DemoProject.Demos.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Demos
{
    public interface IDemoAppService
    {
        ListResultDto<MiniLessonDto> GetLatestLessons();
    }
}
