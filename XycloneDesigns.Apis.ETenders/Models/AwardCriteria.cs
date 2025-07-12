using Newtonsoft.Json;

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class AwardCriteria : Model
	{
		public class Json
		{
			public const string Criteria = "criteria";
		}

		[JsonProperty(Json.Criteria), JsonPropertyName(Json.Criteria)] public List<Criterion>? Criteria { get; set; }
    }
}