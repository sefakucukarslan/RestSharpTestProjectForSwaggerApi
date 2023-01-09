using RestSharpTestProjectForSwaggerApi.Models.Requests.pet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpTestProjectForSwaggerApi.Services.Abstract
{
    public interface IPetServices
    {
        void CreatePetService(CreatePetRequest createPetRequest);
        void GetPetService(long id);
    }
}
