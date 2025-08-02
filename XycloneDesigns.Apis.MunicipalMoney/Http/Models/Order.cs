using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Enums;

using GeneralOrder = XycloneDesigns.Apis.General.Http.Models.Order;

namespace XycloneDesigns.Apis.MunicipalMoney.Http.Models
{
	public class Order(string key, bool descending = false) : GeneralOrder(key, descending), IParsable<Order>
	{
		public const string ASCENDING = "asc";
		public const string DESCENDING = "desc";

		public override string AsString()
		{
			return string.Format("{0}:{1}", Key, Descending ? DESCENDING : ASCENDING);
		}

		public static new Order Parse(string value, IFormatProvider? provider)
		{
			string[] _str = value.Split(':', StringSplitOptions.TrimEntries);

			return new Order(_str[0], true switch
			{
				true when string.Equals(ASCENDING, _str[1], StringComparison.OrdinalIgnoreCase) => ASCENDING,
				true when string.Equals(DESCENDING, _str[1], StringComparison.OrdinalIgnoreCase) => DESCENDING,

				_ => ASCENDING

			} == DESCENDING);
		}
		public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out Order order)
		{
			order = null;

			if (s?.Split('|', 2, StringSplitOptions.TrimEntries) is not string[] str)
				return false;

			if (str.ElementAtOrDefault(0) is not string key)
				return false;

			if (str.ElementAtOrDefault(1) is not string direction)
				return false;

			if (string.Equals(direction, ASCENDING, StringComparison.OrdinalIgnoreCase))
				order = new Order(key, false);

			if (string.Equals(direction, DESCENDING, StringComparison.OrdinalIgnoreCase))
				order = new Order(key, true);

			return order is not null;
		}
	}
}
