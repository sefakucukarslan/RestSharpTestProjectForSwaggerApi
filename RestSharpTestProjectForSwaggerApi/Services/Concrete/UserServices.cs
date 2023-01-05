using RestSharpTestProjectForSwaggerApi.Actions.Abstract;
using RestSharpTestProjectForSwaggerApi.Actions.Concrete;
using RestSharpTestProjectForSwaggerApi.Models.Requests.user;
using RestSharpTestProjectForSwaggerApi.Models.Responses.UserResponses;
using RestSharpTestProjectForSwaggerApi.Services.Abstract;
using Xunit;

namespace RestSharpTestProjectForSwaggerApi.Services.Concrete
{
    internal class UserServices : IUserServices
    {
        IUserActions useractions;
        BaseUserResponse baseUserResponse;
        CreateUserRequest createUserRequest;

        public UserServices()
        {
            useractions = new UserActions();
        }
        public void UserLoginService(string userName, string password)
        {
            baseUserResponse = useractions.UserLoginAction(userName, password);
            Assert.True(baseUserResponse.Code == 200);
            Assert.Contains("logged in user session:", baseUserResponse.Message);
            Assert.Equal("unknown", baseUserResponse.Type);
        }

        public void UserLogoutService()
        {
            baseUserResponse = useractions.UserLogoutAction();
            Assert.True(baseUserResponse.Code == 200);
            Assert.Equal("unknown", baseUserResponse.Type);
            Assert.Contains("ok", baseUserResponse.Message);
        }

        public void CreateUserService(CreateUserRequest createUserRequest)
        {
            baseUserResponse = useractions.CreateUserAction(createUserRequest);
            Assert.True(baseUserResponse.Code == 200);
            Assert.Equal("unknown", baseUserResponse.Type);
            Assert.Contains(createUserRequest.Id.ToString(), baseUserResponse.Message);
        }

        public void UpdateUserService(string userName, CreateUserRequest createUserRequest)
        {
            baseUserResponse = useractions.UserUpdateAction(userName, createUserRequest);
            Assert.True(baseUserResponse.Code == 200);
            Assert.Equal("unknown", baseUserResponse.Type);
            Assert.Contains(createUserRequest.Id.ToString(), baseUserResponse.Message);
        }

        public void DeleteUserService(string userName)
        {
            baseUserResponse = useractions.UserDeleteAction(userName);
            Assert.True(baseUserResponse.Code == 200);
            Assert.Equal("unknown", baseUserResponse.Type);
            Assert.Contains(userName, baseUserResponse.Message);
        }

        public void GetUserService(string userName)
        {
            createUserRequest = useractions.UserGetAction(userName);
            //Assert.True(createUserRequest.Id == 9222968140497196000);
            Assert.Contains(userName, createUserRequest.UserName);
            Assert.Equal("Sefa", createUserRequest.FirstName);
            Assert.Equal("Küçükarslan", createUserRequest.LastName);
            Assert.Equal("sefa@gmail.com", createUserRequest.Email);
            Assert.Equal("12345", createUserRequest.Password);
            Assert.Equal("5555-55-555", createUserRequest.Phone);
            Assert.Equal(1, createUserRequest.UserStatus);
        }
    }
}
