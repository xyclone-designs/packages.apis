using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class Contract : Model
	{
		public class Json
		{
			public const string AwardID = "awardID";
			public const string DateSigned = "dateSigned";
			public const string Description = "description";
			public const string Documents = "documents";
			public const string Id = "id";
			public const string Implementation = "implementation";
			public const string Milestones = "milestones";
			public const string Period = "period";
			public const string RelatedProcesses = "relatedProcesses";
			public const string Status = "status";
			public const string Title = "title";
			public const string Value = "value";
		}

		[JsonProperty(Json.AwardID), JsonPropertyName(Json.AwardID)] public string? AwardID { get; set; }
		[JsonProperty(Json.DateSigned), JsonPropertyName(Json.DateSigned)] public DateTime? DateSigned { get; set; }
		[JsonProperty(Json.Description), JsonPropertyName(Json.Description)] public string? Description { get; set; }
		[JsonProperty(Json.Documents), JsonPropertyName(Json.Documents)] public List<Document>? Documents { get; set; }
		[JsonProperty(Json.Id), JsonPropertyName(Json.Id)] public string? Id { get; set; }
		[JsonProperty(Json.Implementation), JsonPropertyName(Json.Implementation)] public Implementation? Implementation { get; set; }
		[JsonProperty(Json.Milestones), JsonPropertyName(Json.Milestones)] public List<Milestone>? Milestones { get; set; }
		[JsonProperty(Json.Period), JsonPropertyName(Json.Period)] public Period? Period { get; set; }
		[JsonProperty(Json.RelatedProcesses), JsonPropertyName(Json.RelatedProcesses)] public List<RelatedProcess>? RelatedProcesses { get; set; }
		[JsonProperty(Json.Status), JsonPropertyName(Json.Status)] public string? Status { get; set; }
		[JsonProperty(Json.Title), JsonPropertyName(Json.Title)] public string? Title { get; set; }
		[JsonProperty(Json.Value), JsonPropertyName(Json.Value)] public Value? Value { get; set; }
	}
}