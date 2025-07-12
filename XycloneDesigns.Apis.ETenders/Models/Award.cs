using Newtonsoft.Json;

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class Award : Model
	{
		public class Json
		{
			public const string Description = "description";
			public const string Id = "id";
			public const string Suppliers = "suppliers";
			public const string Status = "status";
			public const string Title = "title";
			public const string Value = "value";
		}

		[JsonProperty(Json.Description), JsonPropertyName(Json.Description)] public string? Description { get; set; }
        [JsonProperty(Json.Id), JsonPropertyName(Json.Id)] public string? Id { get; set; }
        [JsonProperty(Json.Suppliers), JsonPropertyName(Json.Suppliers)] public List<Supplier>? Suppliers { get; set; }
        [JsonProperty(Json.Status), JsonPropertyName(Json.Status)] public string? Status { get; set; }
		[JsonProperty(Json.Title), JsonPropertyName(Json.Title)] public string? Title { get; set; }
		[JsonProperty(Json.Value), JsonPropertyName(Json.Value)] public Value? Value { get; set; }
    }
}