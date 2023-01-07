using RestSharp;
using RestSharpTestProjectForSwaggerApi.Actions.Abstract;
using RestSharpTestProjectForSwaggerApi.Models.Requests.user;
using RestSharpTestProjectForSwaggerApi.Models.Responses.UserResponses;
using System.Text.Json;

namespace RestSharpTestProjectForSwaggerApi.Actions.Concrete
{
    public class UserActions : IUserActions
    {
        RestClient client;
        RestRequest request;
        IRestResponse response;
        private readonly string baseUrl = "https://petstore.swagger.io/v2/user/";

        public UserActions() 
        { 
            client = new RestClient();
        }

        public UserResponse UserLoginAction(string userName, string password)
        {
            client.BaseUrl = new Uri(baseUrl + "login?username=" + userName + "&password=" + password);
            request = new RestRequest(Method.GET);
            response = client.Execute(request);
            return JsonSerializer.Deserialize<UserResponse>(response.Content);
        }

        public UserResponse UserLogoutAction()
        {
            client.BaseUrl = new Uri(baseUrl + "logout");
            request = new RestRequest(Method.GET);
            response = client.Execute(request);
            return JsonSerializer.Deserialize<UserResponse>(response.Content);
        }

        public UserResponse CreateUserAction(CreateUserRequest createUserRequest)
        {
            client.BaseUrl = new Uri(baseUrl);
            request = new RestRequest(Method.POST);
            request.AddJsonBody(JsonSerializer.Serialize(createUserRequest));
            response = client.Execute(request);
            return JsonSerializer.Deserialize<UserResponse>(response.Content);
        }

        public UserResponse UserUpdateAction(string userName, CreateUserRequest createUserRequest)
        {
            client.BaseUrl = new Uri(baseUrl + userName);
            request = new RestRequest(Method.PUT);
            request.AddJsonBody(JsonSerializer.Serialize(createUserRequest));
            response = client.Execute(request);
            return JsonSerializer.Deserialize<UserResponse>(response.Content);
        }

        public UserResponse UserDeleteAction(string userName)
        {
            client.BaseUrl = new Uri(baseUrl + userName);
            request = new RestRequest(Method.DELETE);
            response = client.Execute(request);
            return JsonSerializer.Deserialize<UserResponse>(response.Content);
        }

        public GetUserResponse UserGetAction(string userName)
        {
            client.BaseUrl = new Uri(baseUrl + userName);
            request = new RestRequest(Method.GET);
            request.AddHeader("Accept", "application/json");
            response = client.Execute(request);
            return JsonSerializer.Deserialize<GetUserResponse>(response.Content);
        }
    }
}
