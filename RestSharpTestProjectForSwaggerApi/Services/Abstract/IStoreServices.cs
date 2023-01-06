using RestSharpTestProjectForSwaggerApi.Models.Requests.store;

namespace RestSharpTestProjectForSwaggerApi.Services.Abstract
{
    public interface IStoreServices
    {
        void CreateStoreService(CreateStoreRequest createOrderRequest);
        void GetStoreService(int orderId);
        void GetInventoryService();
        void DeleteStoreService(int orderId);
    }
}
