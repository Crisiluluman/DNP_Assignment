using System.Text.Json.Serialization;

namespace DNP_Assignment.Models
{
    public class User
    {
        [JsonPropertyName("userName")]
        public string UserName { get; set; }
        
        [JsonPropertyName("password")]
        public string Password { get; set; }
        
        [JsonPropertyName("role")]
        public string Role { get; set; }
    }
}