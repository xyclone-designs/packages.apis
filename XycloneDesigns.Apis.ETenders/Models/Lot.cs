using Newtonsoft.Json;

using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class Lot : Model
	{
		public class Json
		{
			public const string AwardCriteria = "awardCriteria";
			public const string ContractPeriod = "contractPeriod";
			public const string Description = "description";
			public const string HasOptions = "hasOptions";
			public const string HasRenewal = "hasRenewal";
			public const string Id = "id";
			public const string Options = "options";
			public const string Renewal = "renewal";
			public const string SubmissionTerms = "submissionTerms";
			public const string Status = "status";
			public const string Value = "value";
		}

		[JsonProperty(Json.AwardCriteria), JsonPropertyName(Json.AwardCriteria)] public AwardCriteria? AwardCriteria { get; set; }
        [JsonProperty(Json.ContractPeriod), JsonPropertyName(Json.ContractPeriod)] public ContractPeriod? ContractPeriod { get; set; }
        [JsonProperty(Json.Description), JsonPropertyName(Json.Description)] public string? Description { get; set; }
		[JsonProperty(Json.HasOptions), JsonPropertyName(Json.HasOptions)] public bool HasOptions { get; set; }
		[JsonProperty(Json.HasRenewal), JsonPropertyName(Json.HasRenewal)] public bool HasRenewal { get; set; }
		[JsonProperty(Json.Id), JsonPropertyName(Json.Id)] public string? Id { get; set; }
		[JsonProperty(Json.Options), JsonPropertyName(Json.Options)] public Options? Options { get; set; }
		[JsonProperty(Json.Renewal), JsonPropertyName(Json.Renewal)] public Renewal? Renewal { get; set; }
		[JsonProperty(Json.SubmissionTerms), JsonPropertyName(Json.SubmissionTerms)] public SubmissionTerms? SubmissionTerms { get; set; }
		[JsonProperty(Json.Status), JsonPropertyName(Json.Status)] public string? Status { get; set; }
		[JsonProperty(Json.Value), JsonPropertyName(Json.Value)] public Value? Value { get; set; }
	}
}