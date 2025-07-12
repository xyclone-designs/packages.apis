using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.General.Http
{
	public class ApiFile
	{
		public class Json
		{
			public const string DateCreated = "datecreated";
			public const string DateEdited = "dateedited";
			public const string Description = "description";
			public const string FilePath = "filepath";
			public const string Name = "name";
			public const string Url = "url";

		}
		public class OrderKeys
		{
			public const string Name = "name";

			public static IOrderedQueryable<ApiFile> Order(IQueryable<ApiFile> queryable, string orderkey, bool reverse)
			{
				return (orderkey, reverse) switch
				{
					(Name, false) => queryable.OrderBy(_ => _.Name),
					(Name, true) => queryable.OrderByDescending(_ => _.Name),

					(_, _) => queryable.OrderBy(_ => _.Name),
				};
			}
			public static IQueryable<ApiFile> Order(IQueryable<ApiFile> queryable, bool reverse, params string[] orderkeys)
			{
				IOrderedQueryable<ApiFile>? ordered = null;

				foreach (string orderkey in orderkeys)
					ordered = Order(ordered ?? queryable, orderkey, reverse);

				return ordered ?? queryable;
			}

			public static IEnumerable<string> AsEnumerable()
			{
				return Enumerable.Empty<string>()
					.Append(Name);
			}
		}

		[JsonProperty(Json.DateCreated), JsonPropertyName(Json.DateCreated)] public string? DateCreated { get; set; }
		[JsonProperty(Json.DateEdited), JsonPropertyName(Json.DateEdited)] public string? DateEdited { get; set; }
		[JsonProperty(Json.Description), JsonPropertyName(Json.Description)] public string? Description { get; set; }
		[JsonProperty(Json.FilePath), JsonPropertyName(Json.FilePath)] public string? FilePath { private get; set; }
		[JsonProperty(Json.Name), JsonPropertyName(Json.Name)] public string? Name { get; set; }
		[JsonProperty(Json.Url), JsonPropertyName(Json.Url)] public string? Url { get; set; }

		public string? GetFilePath()
		{
			return FilePath;
		}

		public static object AsTypeObject()
		{
			return new
			{
				DateCreated = new { Type = "string", Format = "date" },
				DateEdited = new { Type = "string", Format = "date" },
				Description = new { Type = "string", },
				Name = new { Type = "string" },
				Url = new { Type = "string" },
			};
		}
		public static ApiFile FromJToken(JToken jtoken)
		{
			return FromJObject(new JObject(jtoken));
		}
		public static ApiFile FromJObject(JObject jobject)
		{
			return new ApiFile
			{
				DateCreated = jobject.TryGetValue(nameof(DateCreated), StringComparison.OrdinalIgnoreCase, out JToken? _datecreated)
					? _datecreated?.ToObject<string>()
					: null,
				DateEdited = jobject.TryGetValue(nameof(DateEdited), StringComparison.OrdinalIgnoreCase, out JToken? _dateedited)
					? _dateedited?.ToObject<string>()
					: null,
				Description = jobject.TryGetValue(nameof(Description), StringComparison.OrdinalIgnoreCase, out JToken? _description)
					? _description?.ToObject<string>()
					: null,
				Name = jobject.TryGetValue(nameof(Name), StringComparison.OrdinalIgnoreCase, out JToken? _name)
					? _name?.ToObject<string>()
					: null,
				Url = jobject.TryGetValue(nameof(Url), StringComparison.OrdinalIgnoreCase, out JToken? _url)
					? _url?.ToObject<string>()
					: null,
			};
		}
	}
}
