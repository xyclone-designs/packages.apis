using Newtonsoft.Json;

using System;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class Communication : Model
	{
		public class Json
		{
			public const string AtypicalToolUrl = "atypicalToolUrl";
			public const string FutureNoticeDate = "futureNoticeDate";
		}

		[JsonProperty(Json.AtypicalToolUrl), JsonPropertyName(Json.AtypicalToolUrl)] public Uri? AtypicalToolUrl { get; set; }
		[JsonProperty(Json.FutureNoticeDate), JsonPropertyName(Json.FutureNoticeDate)] public DateTime? FutureNoticeDate { get; set; }
    }
}