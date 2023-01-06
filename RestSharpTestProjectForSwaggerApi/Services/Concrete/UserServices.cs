using RestSharpTestProjectForSwaggerApi.Actions.Abstract;
using RestSharpTestProjectForSwaggerApi.Actions.Concrete;
using RestSharpTestProjectForSwaggerApi.Models.Requests.user;
using RestSharpTestProjectForSwaggerApi.Models.Responses.UserResponses;
using RestSharpTestProjectForSwaggerApi.Services.Abstract;
using Xunit;

namespace RestSharpTestProjectForSwaggerApi.Services.Concrete
{
    public class UserServices : IUserServices
    {
        IUserActions userActions;
        UserResponse userResponse;
        GetUserResponse getUserResponse;

        public UserServices()
        {
            userActions = new UserActions();
        }
        public void UserLoginService(string userName, string password)
        {
            userResponse = userActions.UserLoginAction(userName, password);
            Assert.True(userResponse.Code == 200);
            Assert.Contains("logged in user session:", userResponse.Message);
            Assert.Equal("unknown", userResponse.Type);
        }

        public void UserLogoutService()
        {
            userResponse = userActions.UserLogoutAction();
            Assert.True(userResponse.Code == 200);
            Assert.Equal("unknown", userResponse.Type);
            Assert.Contains("ok", userResponse.Message);
        }

        public void CreateUserService(CreateUserRequest createUserRequest)
        {
            userResponse = userActions.CreateUserAction(createUserRequest);
            Assert.True(userResponse.Code == 200);
            Assert.Equal("unknown", userResponse.Type);
            Assert.Contains(createUserRequest.Id.ToString(), userResponse.Message);
        }

        public void UpdateUserService(string userName, CreateUserRequest createUserRequest)
        {
            userResponse = userActions.UserUpdateAction(userName, createUserRequest);
            Assert.True(userResponse.Code == 200);
            Assert.Equal("unknown", userResponse.Type);
            Assert.Contains(createUserRequest.Id.ToString(), userResponse.Message);
        }

        public void DeleteUserService(string userName)
        {
            userResponse = userActions.UserDeleteAction(userName);
            Assert.True(userResponse.Code == 200);
            Assert.Equal("unknown", userResponse.Type);
            Assert.Contains(userName, userResponse.Message);
        }

        public void GetUserService(string userName)
        {
            getUserResponse = userActions.UserGetAction(userName);
            //Assert.True(createUserRequest.Id == 9222968140497196000);
            Assert.Contains(userName, getUserResponse.UserName);
            Assert.Equal("Sefa", getUserResponse.FirstName);
            Assert.Equal("Küçükarslan", getUserResponse.LastName);
            Assert.Equal("sefa@gmail.com", getUserResponse.Email);
            Assert.Equal("12345", getUserResponse.Password);
            Assert.Equal("5555-55-555", getUserResponse.Phone);
            Assert.Equal(1, getUserResponse.UserStatus);
        }
    }
}
