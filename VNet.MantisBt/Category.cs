using System.Text.Json.Serialization;

namespace VNet.MantisBt
{
    public class Category
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("project")]
        public IdName Project { get; set; }
    }
}
