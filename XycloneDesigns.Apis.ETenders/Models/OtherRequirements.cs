using Newtonsoft.Json;

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class OtherRequirements : Model
	{
		public class Json
		{
			public const string ReservedParticipation = "reservedParticipation";
			public const string RequiresStaffNamesAndQualifications = "requiresStaffNamesAndQualifications";
		}

		[JsonProperty(Json.ReservedParticipation), JsonPropertyName(Json.ReservedParticipation)] public List<string>? ReservedParticipation { get; set; }
		[JsonProperty(Json.RequiresStaffNamesAndQualifications), JsonPropertyName(Json.RequiresStaffNamesAndQualifications)] public bool? RequiresStaffNamesAndQualifications { get; set; }
    }
}