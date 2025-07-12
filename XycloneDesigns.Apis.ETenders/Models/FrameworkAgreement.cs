using Newtonsoft.Json;

using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class FrameworkAgreement : Model
	{
		public class Json
		{
			public const string MaximumParticipants = "maximumParticipants";
			public const string PeriodRationale = "periodRationale";
		}

		[JsonProperty(Json.MaximumParticipants), JsonPropertyName(Json.MaximumParticipants)] public int MaximumParticipants { get; set; }
        [JsonProperty(Json.PeriodRationale), JsonPropertyName(Json.PeriodRationale)] public string? PeriodRationale { get; set; }
    }
}