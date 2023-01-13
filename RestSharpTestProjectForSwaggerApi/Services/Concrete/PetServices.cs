using RestSharpTestProjectForSwaggerApi.Actions.Abstract;
using RestSharpTestProjectForSwaggerApi.Actions.Concrete;
using RestSharpTestProjectForSwaggerApi.Models.Requests.pet;
using RestSharpTestProjectForSwaggerApi.Models.Responses.pet;
using RestSharpTestProjectForSwaggerApi.Models.Responses.UserResponses;
using RestSharpTestProjectForSwaggerApi.Services.Abstract;
using Xunit;

namespace RestSharpTestProjectForSwaggerApi.Services.Concrete
{
    public class PetServices : IPetServices
    {
        IPetActions actions;
        BasePetResponse basePetResponse;
        DeletePetResponse deletePetResponse;

        public PetServices()
        {
            actions = new PetActions();
        }
        public void CreatePetService(CreatePetRequest createPetRequest)
        {
            basePetResponse = actions.CreatePetAction(createPetRequest);
            Assert.Equal(createPetRequest.Id, basePetResponse.Id);
            Assert.Equal(createPetRequest.Category.Id, basePetResponse.Category.Id);
            Assert.Equal(createPetRequest.Category.Name, basePetResponse.Category.Name);
            Assert.Equal(createPetRequest.Name, basePetResponse.Name);
            Assert.Equal(createPetRequest.PhotoUrls, basePetResponse.PhotoUrls);
            Assert.Equal(createPetRequest.Status, basePetResponse.Status);
        }

        public void DeletePetService(long id)
        {
            deletePetResponse = actions.DeletePetAction(id);
            Assert.True(deletePetResponse.Code == 200);
            Assert.Contains("1", deletePetResponse.Message);
            Assert.Equal("unknown", deletePetResponse.Type);
        }

        public void GetPetService(long id)
        {
            basePetResponse = actions.GetPetAction(id);
            Assert.Equal(1, basePetResponse.Id);
            Assert.Equal(1, basePetResponse.Category.Id);
            Assert.Equal("Fefo", basePetResponse.Category.Name);
            Assert.Equal("Fifo", basePetResponse.Name);
            Assert.True(basePetResponse.PhotoUrls.Any());
            Assert.Equal("Available",basePetResponse.Status);

        }

        public void UpdatePetService(CreatePetRequest createPetRequest)
        {
            basePetResponse = actions.UpdatePetAction(createPetRequest);
            Assert.Equal(createPetRequest.Id, basePetResponse.Id);
            Assert.Equal(createPetRequest.Category.Id, basePetResponse.Category.Id);
            Assert.Equal(createPetRequest.Category.Name, basePetResponse.Category.Name);
            Assert.Equal(createPetRequest.Name, basePetResponse.Name);
            Assert.Equal(createPetRequest.PhotoUrls, basePetResponse.PhotoUrls);
            Assert.Equal(createPetRequest.Status, basePetResponse.Status);
        }
    }
}
