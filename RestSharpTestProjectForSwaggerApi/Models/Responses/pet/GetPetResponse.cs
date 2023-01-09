using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpTestProjectForSwaggerApi.Models.Responses.pet
{
    public class GetPetResponse
    {
        public class About
        {
            public long Id { get; set; }
            public Category Category { get; set; }
            public string Name { get; set; }
            public List<string> PhotoUrls { get; set; }
            public List<Category> Tags { get; set; }
            public string Status { get; set; }
        }

        public class Category
        {
            public long Id { get; set; }
            public string Name { get; set; }
        }
    }
}
