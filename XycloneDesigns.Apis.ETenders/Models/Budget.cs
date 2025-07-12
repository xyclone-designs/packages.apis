using Newtonsoft.Json;

using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class Budget : Model
	{
		public class Json
		{
			public const string Description = "description";
			public const string Rationale = "rationale";
		}

		[JsonProperty(Json.Description), JsonPropertyName(Json.Description)] public string? Description { get; set; }
		[JsonProperty(Json.Rationale), JsonPropertyName(Json.Rationale)] public string? Rationale { get; set; }
    }
}