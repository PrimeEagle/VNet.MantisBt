using System.Text.Json.Serialization;

namespace VNet.MantisBt
{
    public class IdName
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
