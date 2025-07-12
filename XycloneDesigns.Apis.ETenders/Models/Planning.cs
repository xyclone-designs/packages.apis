using Newtonsoft.Json;

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class Planning : Model
	{
		public class Json
		{
			public const string Rationale = "rationale";
			public const string Budget = "budget";
			public const string Documents = "documents";
		}

		[JsonProperty(Json.Rationale), JsonPropertyName(Json.Rationale)] public string? Rationale { get; set; }
		[JsonProperty(Json.Budget), JsonPropertyName(Json.Budget)] public Budget? Budget { get; set; }
        [JsonProperty(Json.Documents), JsonPropertyName(Json.Documents)] public List<Document>? Documents { get; set; }
    }
}