using RestSharpTestProjectForSwaggerApi.Models.Requests;
using RestSharpTestProjectForSwaggerApi.Services.Abstract;
using RestSharpTestProjectForSwaggerApi.Services.Concrete;
using Xunit;

namespace RestSharpTestProjectForSwaggerApi.Tests
{
    public class UserTests
    {
        IUserServices userService;

        public UserTests()
        {
            userService = new UserServices();
        }

        [Theory(DisplayName = "User Login")]
        [InlineData("AdminSefa", "12345")]
        public void UserLoginTest(string userName, string password)
        {
            userService.UserLoginService(userName, password);
        }

        [Theory(DisplayName = "Get User")]
        [InlineData("AdminSefa")]
        public void GetUserTest(string userName)
        {
            userService.GetUserService(userName);
        }

        [Fact(DisplayName = "User Logout")]
        public void UserLogoutTest()
        {
            userService.UserLogoutService();
        }


        [Fact(DisplayName = "Create User")]
        public void CreateUserTest()
        {
            userService.CreateUserService(
                new CreateUserRequest
                {
                    Id = 0,
                    FirstName = "Sefa",
                    LastName = "Küçükarslan",
                    UserName = "AdminSefa",
                    Email = "sefa@gmail.com",
                    Password = "12345",
                    Phone = "5555-55-555",
                    UserStatus = 1
                });
        }

        [Theory(DisplayName ="User Update")]
        [InlineData("AdminSefa")]
        public void UserUpdateTest(string changingUserUserName)
        {
            userService.UpdateUserService(changingUserUserName,
                 new CreateUserRequest
                 {
                     Id = 9222968140497196000,
                     FirstName = "SefaUpdate",
                     LastName = "KüçükarslanUpdate",
                     UserName = "AdminSefa",
                     Email = "sefa@gmail.com",
                     Password = "12345",
                     Phone = "5555-55-555",
                     UserStatus = 1
                 });
        }

        [Theory(DisplayName ="User Delete")]
        [InlineData("AdminSefa")]
        public void UserDeleteTest(string deleteUser)
        {
            userService.DeleteUserService(deleteUser);
        }
    }
}
