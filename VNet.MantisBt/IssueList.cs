using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VNet.MantisBt
{
	public class IssueList
	{
		[JsonPropertyName("issues")]
		public List<Issue> Issues { get; set; }
	}
}
