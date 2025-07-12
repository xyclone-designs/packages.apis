using Newtonsoft.Json;

using System;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class Document : Model
	{
		public class Json
		{
			public const string Id = "id";
			public const string DocumentType = "documentType";
			public const string Title = "title";
			public const string Description = "description";
			public const string Url = "url";
			public const string DatePublished = "datePublished";
			public const string DateModified = "dateModified";
			public const string Format = "format";
			public const string Language = "language";
		}

		[JsonProperty(Json.Id), JsonPropertyName(Json.Id)] public string? Id { get; set; }
        [JsonProperty(Json.DocumentType), JsonPropertyName(Json.DocumentType)] public string? DocumentType { get; set; }
        [JsonProperty(Json.Title), JsonPropertyName(Json.Title)] public string? Title { get; set; }
        [JsonProperty(Json.Description), JsonPropertyName(Json.Description)] public string? Description { get; set; }
        [JsonProperty(Json.Url), JsonPropertyName(Json.Url)] public string? Url { get; set; }
		[JsonProperty(Json.DatePublished), JsonPropertyName(Json.DatePublished)] public DateTime? DatePublished { get; set; }
        [JsonProperty(Json.DateModified), JsonPropertyName(Json.DateModified)] public DateTime? DateModified { get; set; }
        [JsonProperty(Json.Format), JsonPropertyName(Json.Format)] public string? Format { get; set; }
        [JsonProperty(Json.Language), JsonPropertyName(Json.Language)] public string? Language { get; set; }
	}
}