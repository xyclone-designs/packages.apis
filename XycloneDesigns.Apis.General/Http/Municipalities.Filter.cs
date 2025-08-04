using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Enums;
using XycloneDesigns.Apis.General.Http.Models;
using XycloneDesigns.Apis.General.Tables;

namespace XycloneDesigns.Apis.General.Http
{
	public static partial class Municipalities
	{
		public class Filters : GeneralBase.Filters
		{
			public const string AddressEmail = Municipality.SQL.Column_AddressEmail;
			public const string AddressPostal = Municipality.SQL.Column_AddressPostal;
			public const string AddressStreet = Municipality.SQL.Column_AddressStreet;
			public const string Category = Municipality.SQL.Column_Category;
			public const string GeoCode = Municipality.SQL.Column_GeoCode;
			public const string GeoLevel = Municipality.SQL.Column_GeoLevel;
			public const string IsDisestablished = Municipality.SQL.Column_IsDisestablished;
			public const string MiifCategory = Municipality.SQL.Column_MiifCategory;
			public const string Name = Municipality.SQL.Column_Name;
			public const string NameLong = Municipality.SQL.Column_NameLong;
			public const string NumberFax = Municipality.SQL.Column_NumberFax;
			public const string NumberPhone = Municipality.SQL.Column_NumberPhone;
			public const string PkCountry = Municipality.SQL.Column_PkCountry;
			public const string PkDistrict = Municipality.SQL.Column_PkDistrict;
			public const string PkProvince = Municipality.SQL.Column_PkProvince;
			public const string Population = Municipality.SQL.Column_Population;
			public const string SquareKms = Municipality.SQL.Column_SquareKms;
			public const string UrlLogo = Municipality.SQL.Column_UrlLogo;
			public const string UrlWebsite = Municipality.SQL.Column_UrlWebsite;

			public new static IEnumerable<string> AsEnumerable()
			{
				return GeneralBase.Filters.AsEnumerable()
					.Append(AddressEmail)
					.Append(AddressPostal)
					.Append(AddressStreet)
					.Append(Category)
					.Append(GeoCode)
					.Append(GeoLevel)
					.Append(IsDisestablished)
					.Append(MiifCategory)
					.Append(Name)
					.Append(NameLong)
					.Append(NumberFax)
					.Append(NumberPhone)
					.Append(PkCountry)
					.Append(PkDistrict)
					.Append(PkProvince)
					.Append(Population)
					.Append(SquareKms)
					.Append(UrlLogo)
					.Append(UrlWebsite);
			}
		}

		public static bool Filter(this Filter filter, Municipality municipality)
		{
			return filter.Key switch
			{
				Filters.AddressEmail => filter.Passes(municipality.AddressEmail),
				Filters.AddressPostal => filter.Passes(municipality.AddressPostal),
				Filters.AddressStreet => filter.Passes(municipality.AddressStreet),
				Filters.Category => filter.Passes(municipality.Category),
				Filters.GeoCode => filter.Passes(municipality.GeoCode),
				Filters.GeoLevel => filter.Passes(municipality.GeoLevel),
				Filters.IsDisestablished => filter.Passes(municipality.IsDisestablished),
				Filters.MiifCategory => filter.Passes(municipality.MiifCategory),
				Filters.Name => filter.Passes(municipality.Name),
				Filters.NameLong => filter.Passes(municipality.NameLong),
				Filters.NumberFax => filter.Passes(municipality.NumberFax),
				Filters.NumberPhone => filter.Passes(municipality.NumberPhone),
				Filters.PkCountry => filter.Passes(municipality.PkCountry),
				Filters.PkDistrict => filter.Passes(municipality.PkDistrict),
				Filters.PkProvince => filter.Passes(municipality.PkProvince),
				Filters.Population => filter.Passes(municipality.Population),
				Filters.SquareKms => filter.Passes(municipality.SquareKms),
				Filters.UrlLogo => filter.Passes(municipality.UrlLogo),
				Filters.UrlWebsite => filter.Passes(municipality.UrlWebsite),

				_ => filter.Filter<Municipality>(municipality),
			};
		}
	}
}
