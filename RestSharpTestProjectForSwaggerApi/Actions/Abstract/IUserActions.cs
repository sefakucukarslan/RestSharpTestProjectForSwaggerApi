using RestSharpTestProjectForSwaggerApi.Models.Requests;
using RestSharpTestProjectForSwaggerApi.Models.Responses.UserResponses;

namespace RestSharpTestProjectForSwaggerApi.Actions.Abstract
{
    internal interface IUserActions
    {
        BaseUserResponse UserLoginAction(string userName, string password);
        BaseUserResponse UserLogoutAction();
        BaseUserResponse CreateUserAction(CreateUserRequest createUserRequest);
        BaseUserResponse UserUpdateAction(string userName, CreateUserRequest createUserRequest);
        BaseUserResponse UserDeleteAction(string userName);
        CreateUserRequest UserGetAction(string userName);

    }
}
