using Newtonsoft.Json;

using System;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class Publisher : Model
	{
		public class Json
		{
			public const string Name = "name";
			public const string Scheme = "scheme";
			public const string Uid = "uid";
			public const string Uri = "uri";
		}

		[JsonProperty(Json.Name), JsonPropertyName(Json.Name)] public string? Name { get; set; }
		[JsonProperty(Json.Scheme), JsonPropertyName(Json.Scheme)] public string? Scheme { get; set; }
		[JsonProperty(Json.Uid), JsonPropertyName(Json.Uid)] public string? Uid { get; set; }
		[JsonProperty(Json.Uri), JsonPropertyName(Json.Uri)] public Uri? Uri { get; set; }
	}
}