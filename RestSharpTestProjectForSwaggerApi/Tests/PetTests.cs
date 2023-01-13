using RestSharpTestProjectForSwaggerApi.Models.Requests.pet;
using RestSharpTestProjectForSwaggerApi.Services.Abstract;
using RestSharpTestProjectForSwaggerApi.Services.Concrete;
using Xunit;

namespace RestSharpTestProjectForSwaggerApi.Tests
{
    public class PetTests
    {
        IPetServices petServices;

        public PetTests()
        {
            petServices = new PetServices();
        }

        [Fact(DisplayName ="Create Pet")]
        public void CreatePetTests()
        {
            petServices.CreatePetService(new CreatePetRequest
            {
                Id= 1,
                Category = new Category { Id= 1 ,Name="Fefo"},
                Name = "Fifo",
                PhotoUrls= new List<string> { "fofi"},
                Status = "available"                
            });
        }
        
        [Fact(DisplayName ="Update Pet")]
        public void UpdatePetTests()
        {
            petServices.UpdatePetService(new CreatePetRequest
            {
                Id= 2,
                Category = new Category { Id= 2 ,Name="Fofe"},
                Name = "Fofi",
                PhotoUrls= new List<string> { "fifo"},
                Status = "available"                
            });
        }

        [Theory(DisplayName ="Get PetId")]
        [InlineData(1)]
        public void GetPetTests(long id)
        {
            petServices.GetPetService(id);
        }
        
        [Theory(DisplayName ="Delete PetId")]
        [InlineData(1)]
        public void DeletePetTests(long id)
        {
            petServices.GetPetService(id);
        }

    }
}
