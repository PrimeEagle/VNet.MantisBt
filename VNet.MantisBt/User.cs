using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VNet.MantisBt
{
    public class User
    {
        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonPropertyName("real_name")]
        public string RealName { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("access_level")]
        public IdName AccessLevel { get; set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        [JsonPropertyName("protected")]
        public bool Protected { get; set; }

        [JsonPropertyName("projects")]
        public List<IdName> Projects { get; set; }
    }
}