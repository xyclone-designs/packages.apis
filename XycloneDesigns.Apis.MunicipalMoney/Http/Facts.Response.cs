using Newtonsoft.Json;

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.MunicipalMoney.Http
{
	public partial class Facts
	{
		public class Response : MunicipalMoney.Response
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
				public const string TotalFactCount = "total_fact_count";
			}

			[JsonProperty(Json.Cell), JsonPropertyName(Json.Cell)] public List<string>? Cell { get; set; }
			[JsonProperty(Json.Data), JsonPropertyName(Json.Data)] public List<object>? Data { get; set; }
			[JsonProperty(Json.Fields), JsonPropertyName(Json.Fields)] public List<string>? Fields { get; set; }
			[JsonProperty(Json.Page), JsonPropertyName(Json.Page)] public int? Page { get; set; }
			[JsonProperty(Json.PageSize), JsonPropertyName(Json.PageSize)] public int? PageSize { get; set; }
			[JsonProperty(Json.Order), JsonPropertyName(Json.Order)] public List<string>? Order { get; set; }
			[JsonProperty(Json.Status), JsonPropertyName(Json.Status)] public string? Status { get; set; }
			[JsonProperty(Json.TotalFactCount), JsonPropertyName(Json.TotalFactCount)] public int? TotalFactCount { get; set; }
		}
	}
}
