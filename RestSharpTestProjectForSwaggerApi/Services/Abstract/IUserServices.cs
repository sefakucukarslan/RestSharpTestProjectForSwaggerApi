using RestSharpTestProjectForSwaggerApi.Models.Requests.user;

namespace RestSharpTestProjectForSwaggerApi.Services.Abstract
{
    internal interface IUserServices
    {
        void UserLoginService(string userName, string password);
        void UserLogoutService();
        void CreateUserService(CreateUserRequest createUserRequest);
        void UpdateUserService(string userName, CreateUserRequest createUserRequest);
        void DeleteUserService(string userName);
        void GetUserService(string userName);
    }
}
