using Newtonsoft.Json;

using System;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class ContactPoint : Model
	{
		public class Json
		{
			public const string Name = "name";
			public const string Telephone = "telephone";
			public const string Email = "email";
			public const string FaxNumber = "faxNumber";
			public const string Url = "url";
		}

		[JsonProperty(Json.Name), JsonPropertyName(Json.Name)] public string? Name { get; set; }
        [JsonProperty(Json.Telephone), JsonPropertyName(Json.Telephone)] public string? Telephone { get; set; }
        [JsonProperty(Json.Email), JsonPropertyName(Json.Email)] public string? Email { get; set; }
        [JsonProperty(Json.FaxNumber), JsonPropertyName(Json.FaxNumber)] public string? FaxNumber { get; set; }
        [JsonProperty(Json.Url), JsonPropertyName(Json.Url)] public Uri? Url { get; set; }
	}
}