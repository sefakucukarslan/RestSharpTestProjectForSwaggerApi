using RestSharpTestProjectForSwaggerApi.Actions.Abstract;
using RestSharpTestProjectForSwaggerApi.Actions.Concrete;
using RestSharpTestProjectForSwaggerApi.Models.Requests.pet;
using RestSharpTestProjectForSwaggerApi.Models.Responses.pet;
using RestSharpTestProjectForSwaggerApi.Services.Abstract;
using Xunit;

namespace RestSharpTestProjectForSwaggerApi.Services.Concrete
{
    public class PetServices : IPetServices
    {
        IPetActions actions;
        GetPetResponse petResponse;

        public PetServices()
        {
            actions = new PetActions();
        }
        public void CreatePetService(CreatePetRequest createPetRequest)
        {
            throw new NotImplementedException();
        }

        public void GetPetService(long id)
        {
            petResponse = actions.GetPetAction(id);
        }
    }
}
