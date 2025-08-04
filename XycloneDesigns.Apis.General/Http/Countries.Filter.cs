using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Models;
using XycloneDesigns.Apis.General.Tables;

namespace XycloneDesigns.Apis.General.Http
{
	public static partial class Countries
	{
		public class Filters : GeneralBase.Filters
		{
			public const string Capital = Country.SQL.Column_Capital;
			public const string Code = Country.SQL.Column_Code;
			public const string Name = Country.SQL.Column_Name;
			public const string Population = Country.SQL.Column_Population;
			public const string SquareKms = Country.SQL.Column_SquareKms;
			public const string UrlCoatOfArms = Country.SQL.Column_UrlCoatOfArms;
			public const string UrlWebsite = Country.SQL.Column_UrlWebsite;

			public new static IEnumerable<string> AsEnumerable()
			{
				return GeneralBase.Filters.AsEnumerable()
					.Append(Capital)
					.Append(Code)
					.Append(Name)
					.Append(Population)
					.Append(SquareKms)
					.Append(UrlCoatOfArms)
					.Append(UrlWebsite);
			}
		}

		public static bool Filter(this Filter filter, Country country)
		{
			return filter.Key switch
			{
				Filters.Capital => filter.Passes(country.Capital),
				Filters.Code => filter.Passes(country.Code),
				Filters.Name => filter.Passes(country.Name),
				Filters.Population => filter.Passes(country.Population),
				Filters.SquareKms => filter.Passes(country.SquareKms),
				Filters.UrlCoatOfArms => filter.Passes(country.UrlCoatOfArms),
				Filters.UrlWebsite => filter.Passes(country.UrlWebsite),

				_ => filter.Filter<Country>(country),
			};
		}
	}
}
