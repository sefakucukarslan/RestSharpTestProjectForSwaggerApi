using System.Text.Json.Serialization;

namespace RestSharpTestProjectForSwaggerApi.Models.Requests.store
{
    public class CreateStoreRequest
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
