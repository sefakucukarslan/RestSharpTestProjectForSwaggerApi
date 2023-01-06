using RestSharpTestProjectForSwaggerApi.Actions.Abstract;
using RestSharpTestProjectForSwaggerApi.Actions.Concrete;
using RestSharpTestProjectForSwaggerApi.Models.Requests.store;
using RestSharpTestProjectForSwaggerApi.Models.Requests.user;
using RestSharpTestProjectForSwaggerApi.Models.Responses.store;
using RestSharpTestProjectForSwaggerApi.Models.Responses.UserResponses;
using RestSharpTestProjectForSwaggerApi.Services.Abstract;
using Xunit;

namespace RestSharpTestProjectForSwaggerApi.Services.Concrete
{
    public class StoreServices : IStoreServices
    {
        IStoreActions storeActions;
        CreateStoreResponse storeResponse;
        GetStoreResponse getStoreResponse;
        GetInventoryResponse inventoryResponse;
        DeleteStoreResponse deleteStoreResponse;

        public StoreServices()
        {
            storeActions = new StoreActions();
        }

        public void CreateStoreService(CreateStoreRequest createOrderRequest)
        {
            storeResponse = storeActions.CreateStoreAction(createOrderRequest);
            Assert.Equal(1, storeResponse.Id);
            Assert.Equal(1, storeResponse.PetId);
            Assert.Equal(1, storeResponse.Quantity);
            //Assert.Equal(DateTime.Now,storeResponse.ShipDate);
            Assert.Contains(storeResponse.Status, "placed");
            Assert.True(storeResponse.Complete);
        }

        public void DeleteStoreService(int orderId)
        {
            deleteStoreResponse = storeActions.DeleteStoreAction(orderId);
            Assert.True(deleteStoreResponse.Code == 200);
            Assert.Equal("unknown", deleteStoreResponse.Type);
            Assert.Equal("1", deleteStoreResponse.Message);
        }

        public void GetInventoryService()
        {
            inventoryResponse = storeActions.GetInventoryAction();
            Assert.Equal(3, inventoryResponse.Sold);
            Assert.Equal(611, inventoryResponse.String);
            Assert.Equal(3, inventoryResponse.Pending);
            Assert.Equal(6, inventoryResponse.NotAvailableBecauseDied);
            Assert.Equal(351, inventoryResponse.Available);
            Assert.Equal(7, inventoryResponse.Okkk);
            Assert.Equal(1, inventoryResponse.NotAvailable);
            Assert.Equal(1, inventoryResponse.Available);
        }

        public void GetStoreService(int orderId)
        {
            getStoreResponse = storeActions.GetStoreAction(orderId);
            Assert.Equal(1, getStoreResponse.Id);
            Assert.Equal(1, getStoreResponse.PetId);
            Assert.Equal(1, getStoreResponse.Quantity);
            //Assert.Equal(DateTime.Now, getStoreResponse.ShipDate);
            Assert.Contains(getStoreResponse.Status, "placed");
            Assert.True(getStoreResponse.Complete);
        }
    }
}
