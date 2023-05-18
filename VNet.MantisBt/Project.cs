using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VNet.MantisBt
{
    public class Project
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("status")]
        IdNameLabel Status { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        [JsonPropertyName("view_state")]
        public IdNameLabel ViewState { get; set; }

        [JsonPropertyName("access_level")]
        public IdNameLabel AccessLevel { get; set; }

        [JsonPropertyName("custom_fields")]
        public List<CustomField> CustomFields { get; set; }

        [JsonPropertyName("versions")]
        public List<Version> Versions { get; set; }

        [JsonPropertyName("categories")]
        public List<Category> Categories { get; set; }

        [JsonPropertyName("subProjects")]
        public List<IdName> SubProjects { get; set; }
    }
}
