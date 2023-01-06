using System.Text.Json;
using RestSharp;
using RestSharpTestProjectForSwaggerApi.Actions.Abstract;
using RestSharpTestProjectForSwaggerApi.Models.Requests.store;
using RestSharpTestProjectForSwaggerApi.Models.Responses.store;

namespace RestSharpTestProjectForSwaggerApi.Actions.Concrete
{
    public class StoreActions : IStoreActions
    {
        RestClient client;
        RestRequest request;
        IRestResponse response;
        private readonly string baseUrl = "https://petstore.swagger.io/v2/store/";

        public StoreActions()
        {
            client = new RestClient();
        }

        public CreateStoreResponse CreateStoreAction(CreateStoreRequest createStoreRequest)
        {
            client.BaseUrl = new Uri(baseUrl + "order");
            request = new RestRequest(Method.POST);
            request.AddJsonBody(JsonSerializer.Serialize(createStoreRequest));
            response = client.Execute(request);
            return JsonSerializer.Deserialize<CreateStoreResponse>(response.Content);
        }

        public GetStoreResponse GetStoreAction(int storeId)
        {
            client.BaseUrl = new Uri(baseUrl + "order/" + storeId);
            request = new RestRequest(Method.GET);
            response = client.Execute(request);
            return JsonSerializer.Deserialize<GetStoreResponse>(response.Content);
        }

        public GetInventoryResponse GetInventoryAction()
        {
            client.BaseUrl = new Uri(baseUrl + "inventory");
            request = new RestRequest(Method.GET);
            response = client.Execute(request);
            return JsonSerializer.Deserialize<GetInventoryResponse>(response.Content);
        }

        public DeleteStoreResponse DeleteStoreAction(int orderId)
        {
            client.BaseUrl = new Uri(baseUrl + "order/" + orderId);
            request = new RestRequest(Method.DELETE);
            response = client.Execute(request);
            return JsonSerializer.Deserialize<DeleteStoreResponse>(response.Content);
        }
    }
}
