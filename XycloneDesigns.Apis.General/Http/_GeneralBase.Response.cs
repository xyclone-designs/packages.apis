using Newtonsoft.Json;

using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.General.Http
{
	public static partial class GeneralBase
	{
		public abstract class Response { }
		public abstract class Response<T>
		{
			public class Json
			{
				public const string Count = "count";
				public const string Items = "items";
				public const string Page = "page";
				public const string Pages = "pages";
			}
			public class TypeObject
			{
				public object Page = new { Type = "integer" };
				public object Pages = new { Type = "integer" };
				public object Count = new { Type = "integer" };
				public object? Items { get; set; }
			}

			[JsonProperty(Json.Count), JsonPropertyName(Json.Count)] public int Count { get; set; } = 1;
			[JsonProperty(Json.Page), JsonPropertyName(Json.Page)] public int Page { get; set; } = 1;
			[JsonProperty(Json.Pages), JsonPropertyName(Json.Pages)] public int Pages { get; set; } = 1;
			[JsonProperty(Json.Items), JsonPropertyName(Json.Items)] public IEnumerable<T> Items { get; set; } = Enumerable.Empty<T>();
		}
	}
}
