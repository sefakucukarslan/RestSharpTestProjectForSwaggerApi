using RestSharp;
using RestSharpTestProjectForSwaggerApi.Actions.Abstract;
using RestSharpTestProjectForSwaggerApi.Models.Requests.pet;
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

        public BasePetResponse GetPetAction(long id)
        {
            client.BaseUrl = new Uri(baseUrl + id);
            request = new RestRequest(Method.GET);
            response = client.Execute(request);
            return JsonSerializer.Deserialize<BasePetResponse>(response.Content);
        }

        public BasePetResponse CreatePetAction(CreatePetRequest createPetRequest)
        {
            client.BaseUrl = new Uri(baseUrl);
            request = new RestRequest(Method.POST);
            request.AddJsonBody(JsonSerializer.Serialize(createPetRequest));
            response = client.Execute(request);
            return JsonSerializer.Deserialize<BasePetResponse>(response.Content);
        }

        public BasePetResponse UpdatePetAction(CreatePetRequest createPetRequest)
        {
            client.BaseUrl = new Uri(baseUrl);
            request = new RestRequest(Method.PUT);
            request.AddJsonBody(JsonSerializer.Serialize(createPetRequest));
            response = client.Execute(request);
            return JsonSerializer.Deserialize<BasePetResponse>(response.Content);
        }

        public DeletePetResponse DeletePetAction(long id)
        {
            client.BaseUrl = new Uri(baseUrl + id);
            request = new RestRequest(Method.DELETE);
            response = client.Execute(request);
            return JsonSerializer.Deserialize<DeletePetResponse>(response.Content);
        }
    }
}
