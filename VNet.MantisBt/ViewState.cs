using System.Text.Json.Serialization;

namespace VNet.MantisBt
{
	public class ViewState
	{
		[JsonPropertyName("name")]
		public string Name { get; set; }
	}
}
