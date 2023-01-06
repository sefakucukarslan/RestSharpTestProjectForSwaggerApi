using System.Text.Json.Serialization;

namespace RestSharpTestProjectForSwaggerApi.Models.Responses.store
{
    public class GetInventoryResponse
    {
        [JsonPropertyName("sold")]
        public long Sold { get; set; }
        [JsonPropertyName("string")]
        public long String { get; set; }
        [JsonPropertyName("pending")]
        public long Pending { get; set; }
        [JsonPropertyName("Not available because died")]
        public long NotAvailableBecauseDied { get; set; }
        [JsonPropertyName("available")]
        public long WelcomeAvailable { get; set; }
        [JsonPropertyName("OKKK")]
        public long Okkk { get; set; }
        [JsonPropertyName("Not Available")]
        public long NotAvailable { get; set; }
        [JsonPropertyName("Available")]
        public long Available { get; set; }
    }
}
