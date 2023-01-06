using RestSharpTestProjectForSwaggerApi.Models.Requests.user;
using RestSharpTestProjectForSwaggerApi.Models.Responses.UserResponses;

namespace RestSharpTestProjectForSwaggerApi.Actions.Abstract
{
    internal interface IUserActions
    {
        UserResponse UserLoginAction(string userName, string password);
        UserResponse UserLogoutAction();
        UserResponse CreateUserAction(CreateUserRequest createUserRequest);
        UserResponse UserUpdateAction(string userName, CreateUserRequest createUserRequest);
        UserResponse UserDeleteAction(string userName);
        GetUserResponse UserGetAction(string userName);

    }
}
