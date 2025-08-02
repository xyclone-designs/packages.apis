using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Enums;
using XycloneDesigns.Apis.General.Http.Models;
using XycloneDesigns.Apis.General.Tables;

namespace XycloneDesigns.Apis.General.Http
{
	public static partial class Provinces
	{
		public class Filters : Base.Filters
		{
			public const string Capital = Province.SQL.Column_Capital;
			public const string Code = Province.SQL.Column_Code;
			public const string Name = Province.SQL.Column_Name;
			public const string Population = Province.SQL.Column_Population;
			public const string PkCountry = Province.SQL.Column_PkCountry;
			public const string SquareKms = Province.SQL.Column_SquareKms;
			public const string UrlCoatOfArms = Province.SQL.Column_UrlCoatOfArms;
			public const string UrlWebsite = Province.SQL.Column_UrlWebsite;

			public new static IEnumerable<string> AsEnumerable()
			{
				return Base.Filters.AsEnumerable()
					.Append(Capital)
					.Append(Code)
					.Append(Name)
					.Append(Population)
					.Append(PkCountry)
					.Append(SquareKms)
					.Append(UrlCoatOfArms)
					.Append(UrlWebsite);
			}
		}

		public static bool Filter(this Filter filter, Province province)
		{
			return filter.Key switch
			{
				Filters.Capital => filter.Passes(province.Capital),
				Filters.Code => filter.Passes(province.Code),
				Filters.Name => filter.Passes(province.Name),
				Filters.Population => filter.Passes(province.Population),
				Filters.SquareKms => filter.Passes(province.SquareKms),
				Filters.UrlCoatOfArms => filter.Passes(province.UrlCoatOfArms),
				Filters.UrlWebsite => filter.Passes(province.UrlWebsite),

				_ => filter.Filter<Province>(province),
			};
		}
	}
}
