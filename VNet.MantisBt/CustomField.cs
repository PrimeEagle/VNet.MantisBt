using System.Text.Json.Serialization;

namespace VNet.MantisBt
{
    public class CustomField
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("default_value")]
        public string DefaultValue { get; set; }

        [JsonPropertyName("possible_values")]
        public string PossibleValues { get; set; }

        [JsonPropertyName("valid_regexp")]
        public string ValidRegExp { get; set; }

        [JsonPropertyName("length_min")]
        public int LengthMin { get; set; }

        [JsonPropertyName("length_max")]
        public int LengthMax { get; set; }

        [JsonPropertyName("access_level_r")]
        public IdNameLabel AccessLevelR { get; set; }

        [JsonPropertyName("access_level_rw")]
        public IdNameLabel AccessLevelRW { get; set; }

        [JsonPropertyName("display_report")]
        public bool DisplayReport { get; set; }

        [JsonPropertyName("display_update")]
        public bool DisplayUpdate { get; set; }

        [JsonPropertyName("display_resolved")]
        public bool DisplayResolved { get; set; }

        [JsonPropertyName("display_closed")]
        public bool DisplayClosed { get; set; }

        [JsonPropertyName("require_report")]
        public bool RequireReport { get; set; }

        [JsonPropertyName("require_update")]
        public bool RequireUpdate { get; set;}

        [JsonPropertyName("require_resolved")]
        public bool RequireResolved { get; set; }

        [JsonPropertyName("require_closed")]
        public bool RequireClosed { get; set; }
    }
}