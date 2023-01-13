using RestSharpTestProjectForSwaggerApi.Models.Requests.pet;

namespace RestSharpTestProjectForSwaggerApi.Services.Abstract
{
    public interface IPetServices
    {
        void CreatePetService(CreatePetRequest createPetRequest);
        void UpdatePetService(CreatePetRequest createPetRequest);
        void GetPetService(long id);
        void DeletePetService(long id);
    }
}
