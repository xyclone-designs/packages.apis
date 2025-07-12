using Newtonsoft.Json;

using System;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class Link : Model
	{
		public class Json
		{
			public const string Next = "next";
			public const string Prev = "prev";
		}

		[JsonProperty(Json.Next), JsonPropertyName(Json.Next)] public Uri? Next { get; set; }
        [JsonProperty(Json.Prev), JsonPropertyName(Json.Prev)] public Uri? Prev { get; set; }
    }
}