using Newtonsoft.Json;

using System;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class AwardPeriod : Model
	{
		public class Json
		{
			public const string StartDate = "startDate";
		}

		[JsonProperty(Json.StartDate), JsonPropertyName(Json.StartDate)] public DateTime? StartDate { get; set; }
	}
}