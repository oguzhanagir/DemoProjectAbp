using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shouldly;
using Xunit;
using Abp.Application.Services.Dto;
using DemoProject.Users;
using DemoProject.Users.Dto;
using DemoProject.Persons;

namespace DemoProject.Tests.Users
{
    public class UserAppService_Tests : DemoProjectTestBase
    {
        private readonly IUserAppService _userAppService;
        private readonly IMyPersonAppService _myPersonAppService;
        public UserAppService_Tests()
        {
            _userAppService = Resolve<IUserAppService>();
            _myPersonAppService = Resolve<IMyPersonAppService>();
        }

        [Fact]
        public async Task GetUsers_Test()
        {
            await _myPersonAppService.GetPersonNameById(1);
            // Act
            var output = await _userAppService.GetAllAsync(new PagedUserResultRequestDto{MaxResultCount=20, SkipCount=0} );

            // Assert
            output.Items.Count.ShouldBeGreaterThan(0);
        }

        [Fact]
        public async Task CreateUser_Test()
        {
            // Act
            await _userAppService.CreateAsync(
                new CreateUserDto
                {
                    EmailAddress = "john@volosoft.com",
                    IsActive = true,
                    Name = "John",
                    Surname = "Nash",
                    Password = "123qwe",
                    UserName = "john.nash"
                });

            await UsingDbContextAsync(async context =>
            {
                var johnNashUser = await context.Users.FirstOrDefaultAsync(u => u.UserName == "john.nash");
                johnNashUser.ShouldNotBeNull();
            });
        }
    }
}
