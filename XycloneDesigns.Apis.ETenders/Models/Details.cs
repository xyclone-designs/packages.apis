using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class Details : Model
	{
		public class Json
		{
			public const string BuyerProfile = "buyerProfile";
			public const string Classifications = "classifications";
			public const string Url = "url";
		}

		[JsonProperty(Json.BuyerProfile), JsonPropertyName(Json.BuyerProfile)] public string? BuyerProfile { get; set; }
        [JsonProperty(Json.Classifications), JsonPropertyName(Json.Classifications)] public List<Classification>? Classifications { get; set; }
		[JsonProperty(Json.Url), JsonPropertyName(Json.Url)] public Uri? Url { get; set; }
	}
}