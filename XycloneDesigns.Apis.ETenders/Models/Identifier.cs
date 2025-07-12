using Newtonsoft.Json;

using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class Identifier : Model
	{
		public class Json
		{
			public const string LegalName = "legalName";
		}

		[JsonProperty(Json.LegalName), JsonPropertyName(Json.LegalName)] public string? LegalName { get; set; }
    }
}