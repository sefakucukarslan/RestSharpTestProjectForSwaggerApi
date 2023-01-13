using RestSharpTestProjectForSwaggerApi.Models.Requests.pet;
using RestSharpTestProjectForSwaggerApi.Models.Responses.pet;

namespace RestSharpTestProjectForSwaggerApi.Actions.Abstract
{
    public interface IPetActions
    {
        BasePetResponse GetPetAction(long id);
        BasePetResponse CreatePetAction(CreatePetRequest createPetRequest);
        BasePetResponse UpdatePetAction(CreatePetRequest createPetRequest);
    }
}
