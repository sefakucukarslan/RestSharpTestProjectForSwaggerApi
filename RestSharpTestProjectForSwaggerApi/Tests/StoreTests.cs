using RestSharpTestProjectForSwaggerApi.Models.Requests;
using RestSharpTestProjectForSwaggerApi.Services.Abstract;
using Xunit;

namespace RestSharpTestProjectForSwaggerApi.Tests
{
    public class StoreTests
    {
        IOrderService orderService;

        public StoreTests(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        [Fact(DisplayName ="Create Order")]
        public void CreateOrderTest()
        {
            orderService.CreateOrderService(new CreateOrderRequest
            {
                Id= 1,
                PetId= 1,
                Quantity= 1,
                ShipDate= DateTime.Now,
                Status = "placed",
                Complete = true
            });
        }
    }
}
