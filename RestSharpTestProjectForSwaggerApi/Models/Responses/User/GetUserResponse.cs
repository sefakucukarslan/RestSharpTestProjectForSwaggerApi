using System.Text.Json.Serialization;

namespace RestSharpTestProjectForSwaggerApi.Models.Responses.UserResponses
{
    public class GetUserResponse
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("username")]
        public string UserName { get; set; }
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }
        [JsonPropertyName("lastName")]
        public string LastName { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("password")]
        public string Password { get; set; }
        [JsonPropertyName("phone")]
        public string Phone { get; set; }
        [JsonPropertyName("userStatus")]
        public int UserStatus { get; set; }
    }
}
