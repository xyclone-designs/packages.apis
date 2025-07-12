using Newtonsoft.Json;

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.MunicipalMoney.Http.Rest
{
	public partial class Cubes
	{
		public class Response : MunicipalMoneyRest.Response 
		{
			public class Json
			{
				public const string Data = "data";
				public const string Status = "status";
			}

			[JsonProperty(Json.Data), JsonPropertyName(Json.Data)] public List<DataItem>? Data { get; set; }
			[JsonProperty(Json.Status), JsonPropertyName(Json.Status)] public string? Status { get; set; }

			public class DataItem
			{
				public class Json
				{
					public const string Description = "description";
					public const string Label = "label";
					public const string Name = "name";
					public const string Uri = "uri";
				}

				[JsonProperty(Json.Description), JsonPropertyName(Json.Description)] public string? Description { get; set; }
				[JsonProperty(Json.Label), JsonPropertyName(Json.Label)] public string? Label { get; set; }
				[JsonProperty(Json.Name), JsonPropertyName(Json.Name)] public string? Name { get; set; }
				[JsonProperty(Json.Uri), JsonPropertyName(Json.Uri)] public string? Uri { get; set; }		
			}
		}
	}
}
