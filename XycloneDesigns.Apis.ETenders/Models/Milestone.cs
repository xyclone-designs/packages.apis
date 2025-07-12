using Newtonsoft.Json;

using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class Milestone : Model
	{
		public class Json
		{
			public const string Code = "code";
			public const string DateMet = "dateMet";
			public const string DateModified = "dateModified";
			public const string Desciption = "desciption";
			public const string DueDate = "dueDate";
			public const string Id = "id";
			public const string Status = "status";
			public const string Title = "title";
			public const string Type = "type";
		}

		[JsonProperty(Json.Code), JsonPropertyName(Json.Code)] public string? Code { get; set; }
		[JsonProperty(Json.DateMet), JsonPropertyName(Json.DateMet)] public string? DateMet { get; set; }
		[JsonProperty(Json.DateModified), JsonPropertyName(Json.DateModified)] public string? DateModified { get; set; }
		[JsonProperty(Json.Desciption), JsonPropertyName(Json.Desciption)] public string? Desciption { get; set; }
		[JsonProperty(Json.DueDate), JsonPropertyName(Json.DueDate)] public string? DueDate { get; set; }
		[JsonProperty(Json.Id), JsonPropertyName(Json.Id)] public string? Id { get; set; }
		[JsonProperty(Json.Status), JsonPropertyName(Json.Status)] public string? Status { get; set; }
		[JsonProperty(Json.Title), JsonPropertyName(Json.Title)] public string? Title { get; set; }
        [JsonProperty(Json.Type), JsonPropertyName(Json.Type)] public string? Type { get; set; }
    }
}