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

			public Response() : base() { }
			public Response(string response) : base(response) { }

			public List<DataItem>? Data { get; set; }
			public string? Status { get; set; }

			public class DataItem
			{
				public class JsonKeys
				{
					public const string Description = "description";
					public const string Label = "label";
					public const string Name = "name";
					public const string Uri = "uri";
				}

				[JsonProperty(JsonKeys.Description), JsonPropertyName(JsonKeys.Description)] public string? Description { get; set; }
				[JsonProperty(JsonKeys.Label), JsonPropertyName(JsonKeys.Label)] public string? Label { get; set; }
				[JsonProperty(JsonKeys.Name), JsonPropertyName(JsonKeys.Name)] public string? Name { get; set; }
				[JsonProperty(JsonKeys.Uri), JsonPropertyName(JsonKeys.Uri)] public string? Uri { get; set; }		
			}
		}
	}
}
