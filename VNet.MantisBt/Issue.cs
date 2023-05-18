using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VNet.MantisBt
{
	public class Issue
	{
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("summary")]
		public string Summary { get; set; }

		[JsonPropertyName("description")]
		public string Description { get; set; }

		[JsonPropertyName("additional_information")]
		public string AdditionalInformation { get; set; }

		[JsonPropertyName("project")]
		public Project Project { get; set; }

		[JsonPropertyName("category")]
		public Category Category { get; set; }

		[JsonPropertyName("reporter")]
		public IdName Reporter { get; set; }

		[JsonPropertyName("handler")]
		public IdName Handler { get; set; }

		[JsonPropertyName("status")]
		public IdNameLabelColor Status { get; set; }

		[JsonPropertyName("resolution")]
		public IdNameLabel Resolution { get; set; }

		[JsonPropertyName("view_state")]
		public IdNameLabel ViewState { get; set; }
		[JsonPropertyName("priority")]
		public IdNameLabel Priority { get; set; }

		[JsonPropertyName("severity")]
		public IdNameLabel Severity { get; set; }

		[JsonPropertyName("reproducibility")]
		public IdNameLabel Reproducibility { get; set; }

		[JsonPropertyName("sticky")]
		public bool Sticky { get; set; }

		[JsonPropertyName("created_at")]
		public DateTime CreatedAt { get; set; }

		[JsonPropertyName("updated_at")]
		public DateTime UpdatedAt { get; set; }

		[JsonPropertyName("custom_fields")]
		public List<FieldItem> CustomFields { get; set; }

		[JsonPropertyName("tags")]
		public List<IdName> Tags { get; set; }

		[JsonPropertyName("history")]
		public List<HistoryItem> History { get; set; }
	}
}
