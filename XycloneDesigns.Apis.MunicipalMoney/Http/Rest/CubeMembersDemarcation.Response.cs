using Newtonsoft.Json;

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.MunicipalMoney.Http.Rest
{
	public partial class CubeMembersDemarcation
	{
		public class Response : MunicipalMoneyRest.Response 
		{
            public class Json
            {
				public const string Cell = "cell";
				public const string Data = "data";
				public const string Fields = "fields";
                public const string Page = "page";
				public const string PageSize = "page_size";
				public const string Order = "order";
				public const string Status = "status";
				public const string TotalMemberCount = "total_member_count";
			}

			public Response() : base() { }
			public Response(string response) : base(response) { }

			[JsonProperty(Json.Cell), JsonPropertyName(Json.Cell)] public List<string>? Cell { get; set; }
			[JsonProperty(Json.Data), JsonPropertyName(Json.Data)] public List<object>? Data { get; set; }
			[JsonProperty(Json.Fields), JsonPropertyName(Json.Fields)] public List<string>? Fields { get; set; }
            [JsonProperty(Json.Page), JsonPropertyName(Json.Page)] public int? Page { get; set; }
			[JsonProperty(Json.PageSize), JsonPropertyName(Json.PageSize)] public int? PageSize { get; set; }
			[JsonProperty(Json.Order), JsonPropertyName(Json.Order)] public List<string>? Order { get; set; }
			[JsonProperty(Json.Status), JsonPropertyName(Json.Status)] public string? Status { get; set; } 
            [JsonProperty(Json.TotalMemberCount), JsonPropertyName(Json.TotalMemberCount)] public int? TotalMemberCount { get; set; }
		}
	}
}
