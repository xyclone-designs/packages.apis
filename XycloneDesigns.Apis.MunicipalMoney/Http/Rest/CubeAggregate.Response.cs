using Newtonsoft.Json;

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.MunicipalMoney.Http.Rest
{
	public partial class CubeAggregate
	{
		public class Response : MunicipalMoneyRest.Response 
		{
            public class Json
            {
				public const string Aggregates = "aggregates";
				public const string Cell = "cell";
				public const string Cells = "cells";
                public const string Page = "page";
				public const string PageSize = "page_size";
				public const string Order = "order";
				public const string Status = "status";
				public const string TotalCellCount = "total_cell_count";
			}

			public Response() : base() { }
			public Response(string response) : base(response) { }

			[JsonProperty(Json.Aggregates), JsonPropertyName(Json.Aggregates)] public List<string>? Aggregates { get; set; }
			[JsonProperty(Json.Cell), JsonPropertyName(Json.Cell)] public List<string>? Cell { get; set; }
			[JsonProperty(Json.Cells), JsonPropertyName(Json.Cells)] public List<object>? Cells { get; set; }
            [JsonProperty(Json.Page), JsonPropertyName(Json.Page)] public int? Page { get; set; }
			[JsonProperty(Json.PageSize), JsonPropertyName(Json.PageSize)] public int? PageSize { get; set; }
			[JsonProperty(Json.Order), JsonPropertyName(Json.Order)] public List<string>? Order { get; set; }
			[JsonProperty(Json.Status), JsonPropertyName(Json.Status)] public string? Status { get; set; }
            [JsonProperty(Json.TotalCellCount), JsonPropertyName(Json.TotalCellCount)] public int? TotalCellCount { get; set; }
		}
	}
}
