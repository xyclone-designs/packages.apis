using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class RelatedProcess : Model
	{
		public class Json
		{
			public const string Id = "id";
			public const string Identifier = "identifier";
			public const string Relationship = "relationship";
			public const string Scheme = "scheme";
			public const string Title = "title";
			public const string Uri = "uri";
		}

		[JsonProperty(Json.Id), JsonPropertyName(Json.Id)] public string? Id { get; set; }
		[JsonProperty(Json.Identifier), JsonPropertyName(Json.Identifier)] public Identifier? Identifier { get; set; }
		[JsonProperty(Json.Relationship), JsonPropertyName(Json.Relationship)] public List<string>? Relationship { get; set; }
		[JsonProperty(Json.Scheme), JsonPropertyName(Json.Scheme)] public string? Scheme { get; set; }
		[JsonProperty(Json.Title), JsonPropertyName(Json.Title)] public string? Title { get; set; }
		[JsonProperty(Json.Uri), JsonPropertyName(Json.Uri)] public Uri? Uri { get; set; }
	}
}