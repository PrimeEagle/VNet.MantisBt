using System.Text.Json.Serialization;

namespace VNet.MantisBt
{
    public class FieldItem
    {
        [JsonPropertyName("field")]
        public IdName Field { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
