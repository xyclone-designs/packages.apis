using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;

namespace Newtonsoft.Json
{
	public class JsonForceListConverter<T> : JsonConverter
	{
		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(List<T>);
		}
		public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
		{
			JToken jtoken = JToken.Load(reader);

			return jtoken.Type == JTokenType.Array ? jtoken.ToObject<List<T>>() : jtoken.ToObject<T>() is T t ? new List<T> { t } : null;
		}
		public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer) { }
	}
}