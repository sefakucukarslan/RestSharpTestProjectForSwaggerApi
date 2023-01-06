using System.Text.Json.Serialization;

namespace RestSharpTestProjectForSwaggerApi.Models.Responses.store
{
    public class DeleteStoreResponse
    {
        [JsonPropertyName("code")]
        public long Code { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
