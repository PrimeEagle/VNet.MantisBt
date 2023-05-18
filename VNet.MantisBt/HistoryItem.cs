using System;
using System.Text.Json.Serialization;

namespace VNet.MantisBt
{
    public class HistoryItem
    {
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("user")]
        public HistoryUser User { get; set; }

        [JsonPropertyName("field")]
        public FieldItem Field { get; set; }

        [JsonPropertyName("type")]
        public IdName Type { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("old_value")]
        public IdNameLabelColor OldValue { get; set; }

        [JsonPropertyName("new_value")]
        public IdNameLabelColor NewValue { get; set; }

        [JsonPropertyName("change")]
        public string Change { get; set; }
    }
}
