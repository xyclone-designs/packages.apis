using System;
using System.Diagnostics.CodeAnalysis;
using XycloneDesigns.Apis.MunicipalMoney.Http.Enums;

namespace XycloneDesigns.Apis.MunicipalMoney.Http.Models
{
	public class Drilldown(string key) : IParsable<Drilldown>
	{
		public string Key { get; set; } = key;

		public string AsString()
		{
			return Key;
		}

		public static Drilldown Parse(string s, IFormatProvider? provider)
		{
			return new Drilldown(s);
		}
		public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out Drilldown result)
		{
			result = s is null ? null : new Drilldown(s);

			return result is not null; 
		}
	}
}
