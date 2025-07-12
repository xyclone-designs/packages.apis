using Newtonsoft.Json;

using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class ProblemDetails : Model
	{
		public class Json
		{
			public const string Detail = "detail";
			public const string Instance = "instance";
			public const string Status = "status";
			public const string Title = "title";
			public const string Type = "type";
		}

		[JsonProperty(Json.Detail), JsonPropertyName(Json.Detail)] public string? Detail { get; set; }
        [JsonProperty(Json.Instance), JsonPropertyName(Json.Instance)] public int? Instance { get; set; }
		[JsonProperty(Json.Status), JsonPropertyName(Json.Status)] public string? Status { get; set; }
		[JsonProperty(Json.Title), JsonPropertyName(Json.Title)] public string? Title { get; set; }
		[JsonProperty(Json.Type), JsonPropertyName(Json.Type)] public string? Type { get; set; }
    }
}