using imoveis114.entity.Entity;
using imoveis114.service.Services;
using Xunit;

namespace imoveis114.tests.Services
{
    public class UserServiceTest
    {
        private readonly IUserService userService;

        public UserServiceTest(IUserService userService) 
        {
            this.userService = userService;
        }

        [Fact]
        public async Task InsertUserAsync()
        {
            var user = new User("test@test.com", "1234", "test", "test");
            await userService.InsertAsync(user);
        }

        [Fact]
        public async Task GetUserAsync()
        {
            var user = new User("test1@test.com", "1234", "test", "test");
            await userService.InsertAsync(user);

            var returnedUser = await userService.GetAsync(user.id);

            Assert.NotNull(returnedUser);
        }
    }
}