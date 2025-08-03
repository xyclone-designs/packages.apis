using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;

namespace Newtonsoft.Json
{
	public class JsonForceListConverter<T> : JsonConverter
	{
		public override bool CanConvert(Type objectType)
		{
			return true;
		}
		public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
		{
			JToken jtoken = JToken.Load(reader);

			if (jtoken.Type == JTokenType.Array)
				return jtoken.ToObject<List<T>>();

			if (jtoken.ToObject<T>() is T t)
				return new List<T> { t };

			return null;
		}
		public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer) { }
	}
}