using Newtonsoft.Json;

using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class Criterion : Model
	{
		public class Json
		{
			public const string AppliesTo = "appliesTo";
			public const string Description = "description";
			public const string Type = "type";
		}

		[JsonProperty(Json.AppliesTo), JsonPropertyName(Json.AppliesTo)] public string? AppliesTo { get; set; }
        [JsonProperty(Json.Description), JsonPropertyName(Json.Description)] public string? Description { get; set; }
        [JsonProperty(Json.Type), JsonPropertyName(Json.Type)] public string? Type { get; set; }
    }
}