using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using DemoProject.Authorization.Users;
using DemoProject.Demos.Dto;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DemoProject.Demos
{
    public class DemoAppService : DemoProjectAppServiceBase, IDemoAppService
    {
        private readonly IRepository<User, long> _userRepository;
        private readonly IRepository<Lesson,long> _lessonRepository;
        private readonly IMapper _mapper;

        public DemoAppService(IMapper mapper, IRepository<User, long> userRepository, IRepository<Lesson, long> lessonRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
            _lessonRepository = lessonRepository;
        }

        public ListResultDto<MiniLessonDto> GetLatestLessons()
        {
            var lessons = _lessonRepository.GetAll().AsNoTracking().Where(x => x.CurrentState == 1).OrderByDescending(x => x.PublishDate).Take(5);

            return new ListResultDto<MiniLessonDto>
            {
                Items = lessons.ProjectTo<MiniLessonDto>(_mapper.ConfigurationProvider).ToList()
            };
        }

        public ListResultDto<MiniUserDto> GetUserList()
        {
            var users = _userRepository.GetAll().OrderByDescending(x => x.DeletionTime).Take(5).Select(x => new MiniUserDto
            {
                Id = x.Id,
                FullName = x.FullName,
            }).ToList();

            return new ListResultDto<MiniUserDto>(ObjectMapper.Map<List<MiniUserDto>>(users));
            //return new ListResultDto<MiniUserDto>
            //{
            //    Items = users.ProjectTo<MiniUserDto>(_mapper.ConfigurationProvider).ToList()
            //};
        }

    }
}
