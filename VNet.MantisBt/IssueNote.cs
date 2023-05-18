using System.Text.Json.Serialization;

namespace VNet.MantisBt
{
	public class IssueNote
	{
		[JsonPropertyName("text")]
		public string Text { get; set; }

		[JsonPropertyName("view_state")]
		public ViewState ViewState { get; set; }
	}
}
