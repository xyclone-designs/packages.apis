using Newtonsoft.Json;

using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.General.Http.Rest
{
	public partial class GeneralRest
	{
		public class Response : ApiResponse 
		{
			public virtual IQueryable<T> Filter<T>(Request request, IQueryable<T> queryable) where T : Tables._Table
			{
				if (request.Pk is null || request.Pk.Length == 0)
					return queryable;

				if (request.Pk.Any(__ => __ > 0)) queryable = queryable.Where(_ => request.Pk.Any(__ => __ == _.Pk));
				if (request.Pk.Any(__ => __ < 0)) queryable = queryable.Where(_ => request.Pk.All(__ => __ != -_.Pk));

				return queryable;
			}
		}
		public class Response<T> : Response
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
			[JsonProperty(Json.Items), JsonPropertyName(Json.Items)] public int Page { get; set; } = 1;
			[JsonProperty(Json.Page), JsonPropertyName(Json.Page)] public int Pages { get; set; } = 1;
			[JsonProperty(Json.Pages), JsonPropertyName(Json.Pages)] public IEnumerable<T> Items { get; set; } = Enumerable.Empty<T>();
		}        
    }
}
