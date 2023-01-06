using System.Text.Json.Serialization;

namespace RestSharpTestProjectForSwaggerApi.Models.Responses.UserResponses
{
    public class UserResponse
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
