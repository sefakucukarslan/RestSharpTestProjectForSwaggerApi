using RestSharp;
using RestSharpTestProjectForSwaggerApi.Actions.Abstract;
using RestSharpTestProjectForSwaggerApi.Models.Responses.pet;
using System.Text.Json;

namespace RestSharpTestProjectForSwaggerApi.Actions.Concrete
{
    public class PetActions : IPetActions
    {
        RestClient client;
        RestRequest request;
        IRestResponse response;
        private readonly string baseUrl = "https://petstore.swagger.io/v2/pet/";

        public PetActions()
        {
            client = new RestClient();
        }

        public GetPetResponse GetPetAction(long id)
        {
            client.BaseUrl = new Uri(baseUrl + id);
            request = new RestRequest(Method.GET);
            response = client.Execute(request);
            return JsonSerializer.Deserialize<GetPetResponse>(response.Content);
        }
    }
}
