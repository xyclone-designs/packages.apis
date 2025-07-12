using Newtonsoft.Json;

using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class Classification : Model
	{
		public class Json
		{
			public const string Description = "description";
			public const string Id = "id";
			public const string Scheme = "scheme";
		}

		[JsonProperty(Json.Description), JsonPropertyName(Json.Description)] public string? Description { get; set; }
        [JsonProperty(Json.Id), JsonPropertyName(Json.Id)] public string? Id { get; set; }
        [JsonProperty(Json.Scheme), JsonPropertyName(Json.Scheme)] public string? Scheme { get; set; }
    }
}