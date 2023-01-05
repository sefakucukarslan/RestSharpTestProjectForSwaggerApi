using RestSharpTestProjectForSwaggerApi.Models.Requests.store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpTestProjectForSwaggerApi.Services.Abstract
{
    public interface IOrderService
    {
        void CreateOrderService(CreateOrderRequest createOrderRequest);
    }
}
