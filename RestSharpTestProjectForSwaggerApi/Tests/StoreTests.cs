using RestSharpTestProjectForSwaggerApi.Models.Requests.store;
using RestSharpTestProjectForSwaggerApi.Services.Abstract;
using RestSharpTestProjectForSwaggerApi.Services.Concrete;
using Xunit;

namespace RestSharpTestProjectForSwaggerApi.Tests
{
    public class StoreTests
    {
        IStoreServices storeService;

        public StoreTests()
        {
            storeService = new StoreServices();
        }

        [Fact(DisplayName ="Create Store")]
        public void CreateStoreTest()
        {
            storeService.CreateStoreService(new CreateStoreRequest
            {
                Id= 1,
                PetId= 1,
                Quantity= 1,
                //ShipDate= DateTime.Now,
                Status = "placed",
                Complete = true
            });
        }

        [Theory(DisplayName ="Get OrderId")]
        [InlineData(1)]
        public void GetStoreTest(int orderId)
        {
            storeService.GetStoreService(orderId);
        }

        [Fact(DisplayName ="Inventory")]
        public void GetInventoryTest()
        {
            storeService.GetInventoryService();
        }
        
        [Theory(DisplayName ="Delete OrderId")]
        [InlineData(1)]
        public void DeleteStoreTest(int orderId)
        {
            storeService.DeleteStoreService(orderId);
        }

    }
}
