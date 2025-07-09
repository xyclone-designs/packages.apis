using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Linq;
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

			public Response() : this(string.Empty) { }
			public Response(string response) : base(response) 
			{
				JObject jobject = JObject.Parse(response);

				if (jobject.GetValue(Json.Data) is JArray _data)
					Data = _data
						.Values()
						.Select(_ => new DataItem(_))
						.ToList();
				else Console.WriteLine("Cubes.Response: '{0}' could not be found from key '{1}'", nameof(Data), Json.Data);

				if (jobject.GetValue(Json.Status)?.ToObject<string>() is string _status)
					Status = _status;
				else Console.WriteLine("Cubes.Response: '{0}' could not be found from key '{1}'", nameof(Status), Json.Status);

			}

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
				[JsonProperty(JsonKeys.Uri), JsonPropertyName(JsonKeys.Uri)] public Uri? Uri { get; set; } 
			}
		}
	}
}
