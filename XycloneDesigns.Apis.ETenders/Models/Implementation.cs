using Newtonsoft.Json;

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class Implementation : Model
	{
		public class Json
		{
			public const string Transactions = "transactions";
			public const string Milestones = "milestones";
			public const string Documents = "documents";
		}

		[JsonProperty(Json.Transactions), JsonPropertyName(Json.Transactions)] public List<TransactionInformation>? Transactions { get; set; }
        [JsonProperty(Json.Milestones), JsonPropertyName(Json.Milestones)] public List<Milestone>? Milestones { get; set; }
        [JsonProperty(Json.Documents), JsonPropertyName(Json.Documents)] public List<Document>? Documents { get; set; }
    }
}