using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class Release : Model
	{
		public class Json
		{
			public const string Awards = "awards";
			public const string Buyer = "buyer";
			public const string Contracts = "contracts";
			public const string Date = "date";
			public const string Description = "description";
			public const string Id = "id";
			public const string InitiationType = "initiationType";
			public const string Language = "language";
			public const string Ocid = "ocid";
			public const string Parties = "parties";
			public const string Planning = "planning";
			public const string RelatedProcesses = "relatedProcesses";
			public const string Tag = "tag";
			public const string Tender = "tender";
		}

		[JsonProperty(Json.Awards), JsonPropertyName(Json.Awards)] public List<Award>? Awards { get; set; }
		[JsonProperty(Json.Buyer), JsonPropertyName(Json.Buyer)] public Buyer? Buyer { get; set; }
		[JsonProperty(Json.Contracts), JsonPropertyName(Json.Contracts)] public List<Contract>? Contracts { get; set; }
		[JsonProperty(Json.Date), JsonPropertyName(Json.Date)] public DateTime? Date { get; set; }
		[JsonProperty(Json.Description), JsonPropertyName(Json.Description)] public string? Description { get; set; }
		[JsonProperty(Json.Id), JsonPropertyName(Json.Id)] public string? Id { get; set; }
		[JsonProperty(Json.InitiationType), JsonPropertyName(Json.InitiationType)] public string? InitiationType { get; set; }
		[JsonProperty(Json.Language), JsonPropertyName(Json.Language)] public string? Language { get; set; }
		[JsonProperty(Json.Ocid), JsonPropertyName(Json.Ocid)] public string? Ocid { get; set; }
		[JsonProperty(Json.Parties), JsonPropertyName(Json.Parties)] public List<Party>? Parties { get; set; }
		[JsonProperty(Json.Planning), JsonPropertyName(Json.Planning)] public Planning? Planning { get; set; }
		[JsonProperty(Json.RelatedProcesses), JsonPropertyName(Json.RelatedProcesses)] public string? RelatedProcesses { get; set; }
		[JsonProperty(Json.Tag), JsonPropertyName(Json.Tag)] public List<string>? Tag { get; set; }
		[JsonProperty(Json.Tender), JsonPropertyName(Json.Tender)] public Tender? Tender { get; set; }
	}
}