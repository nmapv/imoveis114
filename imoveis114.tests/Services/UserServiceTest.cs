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
            var returnedUser  = await userService.InsertAsync(user);

            Assert.NotNull(returnedUser);
        }

        //[Fact]
        //public async Task GetUserAsync()
        //{
        //    var user = await userService.
        //}
    }
}