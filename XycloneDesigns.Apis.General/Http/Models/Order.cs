using System;
using System.Linq;

namespace XycloneDesigns.Apis.General.Http.Models
{
	public class Order(string key, bool descending = false) : IParsable<Order>
	{
		public string Key { get; set; } = key;
		public bool Descending { get; set; } = descending;

		public virtual string AsString()
		{
			return string.Format("{0}|{1}", Key, Descending);
		}
		
		public static Order Parse(string value, IFormatProvider? provider)
		{
			if (TryParse(value, provider, out Order order))
				return order;

			string[] _str = value.Split('|', StringSplitOptions.TrimEntries);

			string? key = _str.ElementAtOrDefault(0);
			string? descending = _str.ElementAtOrDefault(1);

			return new Order(key ?? string.Empty, bool.TryParse(descending, out bool _descending) && _descending);
		}
		public static bool TryParse(string? value, IFormatProvider? provider, out Order order)
		{
			order = null;

			if (value?.Split('|', 2, StringSplitOptions.TrimEntries) is not string[] str)
				return false;

			if (str.ElementAtOrDefault(0) is not string key)
				return false;
			
			if (bool.TryParse(str.ElementAtOrDefault(1), out bool descending) is false)
				return false;

			order = new Order(key, descending);

			return true;
		}
	}
}
