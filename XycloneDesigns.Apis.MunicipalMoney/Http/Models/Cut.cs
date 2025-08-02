using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Enums;
using XycloneDesigns.Apis.General.Http.Models;

namespace XycloneDesigns.Apis.MunicipalMoney.Http.Models
{
	public class Cut(string key, params object[] values) : Filter(key, null), IParsable<Cut>
	{
		public override string AsString()
		{
			return string.Format("{0}:{1}", Key, string.Join(';', Values));
		}

		public List<object> Values { get; set; } = [ ..values ];

		public static new Cut Parse(string? value, IFormatProvider? provider)
		{
			if (TryParse(value, provider, out Cut? cut) && cut is not null)
				return cut;

			return new Cut(string.Empty, string.Empty);
		}
		public static bool TryParse([NotNullWhen(true)] string? value, IFormatProvider? _, [MaybeNullWhen(false)] out Cut cut)
		{
			cut = null;

			if (value?.Split(':', 2, StringSplitOptions.TrimEntries) is not string[] str)
				return false;

			if (str.ElementAtOrDefault(0) is not string key)
				return false;

			if (str.ElementAtOrDefault(1)?.Split(';') is not string[] vals)
				return false;

			cut = new Cut(key, vals);

			return true;
		}
	}
}
