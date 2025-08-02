using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

using XycloneDesigns.Apis.MunicipalMoney.Http.Enums;

namespace XycloneDesigns.Apis.MunicipalMoney.Http.Models
{
	public class Aggregate(string key, string operation = Aggregate.Operation_Sum) : IParsable<Aggregate>
	{
		public const string Operation_Sum = "sum";

		public string Key { get; set; } = key;
		public string Operation { get; set; } = operation;

		public string AsString()
		{
			return string.Format("{0}.{1}", Key, Operation);
		}
		
		public static Aggregate Parse(string s, IFormatProvider? provider)
		{
			string[] _str = s.Split('.', StringSplitOptions.TrimEntries);

			return _str.ElementAtOrDefault(1) is not string operation
				? new Aggregate(_str[0])
				: new Aggregate(_str[0], operation);
		}
		public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out Aggregate aggregate)
		{
			aggregate = null;

			if (s?.Split('|', 2, StringSplitOptions.TrimEntries) is not string[] str)
				return false;

			if (str.ElementAtOrDefault(0) is not string key)
				return false;

			if (str.ElementAtOrDefault(1) is not string operation)
				return false;

			aggregate = new Aggregate(key, operation);

			return true;
		}
	}
}
