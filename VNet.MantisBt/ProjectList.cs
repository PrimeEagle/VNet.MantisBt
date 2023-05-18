using System.Collections.Generic;
using System.Text.Json.Serialization;
// ReSharper disable MemberCanBePrivate.Global

namespace VNet.MantisBt
{
    public class ProjectList
    {
        [JsonPropertyName("projects")]
        public List<Project> Projects { get; set; }
    }
}
