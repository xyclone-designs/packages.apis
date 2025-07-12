using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class ReleasePackage : Model
	{
		public class Json
		{
			public const string License = "license";
			public const string Links = "links";
			public const string PublicationPolicy = "publicationPolicy";
			public const string PublishedDate = "publishedDate";
			public const string Publisher = "publisher";
			public const string Releases = "releases";
			public const string Uri = "uri";
			public const string Version = "version";
		}

		[JsonProperty(Json.License), JsonPropertyName(Json.License)] public string? License { get; set; }
		[JsonProperty(Json.Links), JsonPropertyName(Json.Links)] public Link? Links { get; set; }
		[JsonProperty(Json.PublicationPolicy), JsonPropertyName(Json.PublicationPolicy)] public string? PublicationPolicy { get; set; }
		[JsonProperty(Json.PublishedDate), JsonPropertyName(Json.PublishedDate)] public DateTime? PublishedDate { get; set; }
		[JsonProperty(Json.Publisher), JsonPropertyName(Json.Publisher)] public Publisher? Publisher { get; set; }
		[JsonProperty(Json.Releases), JsonPropertyName(Json.Releases)] public List<Release>? Releases { get; set; }
		[JsonProperty(Json.Uri), JsonPropertyName(Json.Uri)] public Uri? Uri { get; set; }
		[JsonProperty(Json.Version), JsonPropertyName(Json.Version)] public string? Version { get; set; }
	}
}