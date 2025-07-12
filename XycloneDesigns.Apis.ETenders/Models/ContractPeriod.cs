using Newtonsoft.Json;

using System;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class ContractPeriod : Model
	{
		public class Json
		{
			public const string DurationInDays = "durationInDays";
			public const string EndDate = "endDate";
			public const string MaxExtentDate = "maxExtentDate";
			public const string StartDate = "startDate";
		}

		[JsonProperty(Json.DurationInDays), JsonPropertyName(Json.DurationInDays)] public int DurationInDays { get; set; }
		[JsonProperty(Json.EndDate), JsonPropertyName(Json.EndDate)] public DateTime? EndDate { get; set; }
		[JsonProperty(Json.MaxExtentDate), JsonPropertyName(Json.MaxExtentDate)] public DateTime? MaxExtentDate { get; set; }
		[JsonProperty(Json.StartDate), JsonPropertyName(Json.StartDate)] public DateTime? StartDate { get; set; }
	}
}