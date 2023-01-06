using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RestSharpTestProjectForSwaggerApi.Models.Responses.store
{
    public class GetStoreResponse
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("petId")]
        public long PetId { get; set; }
        [JsonPropertyName("quantity")]
        public long Quantity { get; set; }
        //[JsonPropertyName("shipDate")]
        //public DateTimeOffset ShipDate { get; set; }
        [JsonPropertyName("status")]
        public string Status { get; set; }
        [JsonPropertyName("complete")]
        public bool Complete { get; set; }
    }
}
