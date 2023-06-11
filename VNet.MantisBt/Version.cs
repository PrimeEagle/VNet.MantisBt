using System;
using System.Text.Json.Serialization;

namespace VNet.MantisBt
{
    public class Version
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("released")]
        public bool Released { get; set; }

        [JsonPropertyName("obsolete")]
        public bool Obsolete { get; set; }

        [JsonPropertyName("timestamp")]
        public DateTime Timestamp { get; set; }
    }
}
