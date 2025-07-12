using Newtonsoft.Json;

using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class SubmissionTerms : Model
	{
		public class Json
		{
			public const string VariantPolicy = "variantPolicy";
		}

		[JsonProperty(Json.VariantPolicy), JsonPropertyName(Json.VariantPolicy)] public string? VariantPolicy { get; set; }
	}
}