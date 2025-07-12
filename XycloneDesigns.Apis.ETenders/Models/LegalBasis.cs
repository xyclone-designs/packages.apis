using Newtonsoft.Json;

using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class LegalBasis : Model
	{
		public class Json
		{
			public const string Id = "id";
			public const string Scheme = "scheme";
		}

		[JsonProperty(Json.Id), JsonPropertyName(Json.Id)] public string? Id { get; set; }
        [JsonProperty(Json.Scheme), JsonPropertyName(Json.Scheme)] public string? Scheme { get; set; }
    }
}