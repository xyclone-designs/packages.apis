using Newtonsoft.Json;

using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class Value : Model
	{
		public class Json
		{
			public const string Amount = "amount";
			public const string Currency = "currency";
		}

		[JsonProperty(Json.Amount), JsonPropertyName(Json.Amount)] public double Amount { get; set; }
		[JsonProperty(Json.Currency), JsonPropertyName(Json.Currency)] public string? Currency { get; set; }
	}
}