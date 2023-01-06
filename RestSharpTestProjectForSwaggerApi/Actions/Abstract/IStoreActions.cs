using RestSharpTestProjectForSwaggerApi.Models.Requests.store;
using RestSharpTestProjectForSwaggerApi.Models.Responses.store;


namespace RestSharpTestProjectForSwaggerApi.Actions.Abstract
{
    public interface IStoreActions
    {
        CreateStoreResponse CreateStoreAction(CreateStoreRequest createStoreRequest);
        GetStoreResponse GetStoreAction(int storeId);
        GetInventoryResponse GetInventoryAction();
        DeleteStoreResponse DeleteStoreAction(int orderId);
    }
}
