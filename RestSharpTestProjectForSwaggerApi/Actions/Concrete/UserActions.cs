using RestSharp;
using RestSharpTestProjectForSwaggerApi.Actions.Abstract;
using RestSharpTestProjectForSwaggerApi.Models.Requests;
using RestSharpTestProjectForSwaggerApi.Models.Responses.UserResponses;
using System.Text.Json;

namespace RestSharpTestProjectForSwaggerApi.Actions.Concrete
{
    internal class UserActions : IUserActions
    {
        RestClient client;
        RestRequest request;
        IRestResponse response;
        private readonly string baseUrl = "https://petstore.swagger.io/v2/user/";

        public UserActions() 
        { 
            client = new RestClient();
        }

        public BaseUserResponse UserLoginAction(string userName, string password)
        {
            client.BaseUrl = new Uri(baseUrl + "login?username=" + userName + "&password=" + password);
            request= new RestRequest(Method.GET);
            response = client.Execute(request);
            return JsonSerializer.Deserialize<BaseUserResponse>(response.Content);
        }

        public BaseUserResponse UserLogoutAction()
        {
            client.BaseUrl = new Uri(baseUrl + "logout");
            request = new RestRequest(Method.GET);
            response = client.Execute(request);
            return JsonSerializer.Deserialize<BaseUserResponse>(response.Content);
        }

        public BaseUserResponse CreateUserAction(CreateUserRequest createUserRequest)
        {
            client.BaseUrl = new Uri(baseUrl);
            request = new RestRequest(Method.POST);
            request.AddJsonBody(JsonSerializer.Serialize(createUserRequest));
            response = client.Execute(request);
            return JsonSerializer.Deserialize<BaseUserResponse>(response.Content);
        }

        public BaseUserResponse UserUpdateAction(string userName, CreateUserRequest createUserRequest)
        {
            client.BaseUrl = new Uri(baseUrl + userName);
            request = new RestRequest(Method.PUT);
            request.AddJsonBody(JsonSerializer.Serialize(createUserRequest));
            response = client.Execute(request);
            return JsonSerializer.Deserialize<BaseUserResponse>(response.Content);
        }

        public BaseUserResponse UserDeleteAction(string userName)
        {
            client.BaseUrl = new Uri(baseUrl + userName);
            request = new RestRequest(Method.DELETE);
            response = client.Execute(request);
            return JsonSerializer.Deserialize<BaseUserResponse>(response.Content);
        }

        public BaseUserResponse UserGetAction(string userName)
        {
            client.BaseUrl = new Uri(baseUrl + userName);
            request = new RestRequest(Method.GET);
            response = client.Execute(request);
            return JsonSerializer.Deserialize<BaseUserResponse>(response.Content);
        }
    }
}
