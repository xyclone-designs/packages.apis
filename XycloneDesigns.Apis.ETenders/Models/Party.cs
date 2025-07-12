using Newtonsoft.Json;

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class Party : Model
	{
		public class Json
		{
			public const string Address = "address";
			public const string ContactPoint = "contactPoint";
			public const string Details = "details";
			public const string Id = "id";
			public const string Identifier = "identifier";
			public const string Name = "name";
			public const string Roles = "roles";
		}

		[JsonProperty(Json.Address), JsonPropertyName(Json.Address)] public Address? Address { get; set; }
		[JsonProperty(Json.ContactPoint), JsonPropertyName(Json.ContactPoint)] public ContactPoint? ContactPoint { get; set; }
		[JsonProperty(Json.Details), JsonPropertyName(Json.Details)] public Details? Details { get; set; }
		[JsonProperty(Json.Id), JsonPropertyName(Json.Id)] public string? Id { get; set; }
		[JsonProperty(Json.Identifier), JsonPropertyName(Json.Identifier)] public Identifier? Identifier { get; set; }
		[JsonProperty(Json.Name), JsonPropertyName(Json.Name)] public string? Name { get; set; }
        [JsonProperty(Json.Roles), JsonPropertyName(Json.Roles)] public List<string>? Roles { get; set; }
    }
}