using Newtonsoft.Json;

using System;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class EnquiryPeriod : Model
	{
		public class Json
		{
			public const string EndDate = "endDate";
			public const string StartDate = "startDate";
		}

		[JsonProperty(Json.EndDate), JsonPropertyName(Json.EndDate)] public DateTime? EndDate { get; set; }
		[JsonProperty(Json.StartDate), JsonPropertyName(Json.StartDate)] public DateTime? StartDate { get; set; }
	}
}