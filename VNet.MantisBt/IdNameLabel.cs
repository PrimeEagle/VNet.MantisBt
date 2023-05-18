using System.Text.Json.Serialization;

namespace VNet.MantisBt
{
    public class IdNameLabel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }
    }
}
