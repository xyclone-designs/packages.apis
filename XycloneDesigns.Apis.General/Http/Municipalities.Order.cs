using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Models;
using XycloneDesigns.Apis.General.Tables;

namespace XycloneDesigns.Apis.General.Http
{
	public static partial class Municipalities
	{
		public class Orders : Base.Orders
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
				return Base.Orders.AsEnumerable()
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

		public static IOrderedEnumerable<Municipality> Order(this IEnumerable<Municipality> queryable, params Order[] orders)
		{
			IOrderedEnumerable<Municipality>? orderedqueryable = null;

			foreach (Order order in orders)
				orderedqueryable = orderedqueryable is not null
					? orderedqueryable.Order(order)
					: (order.Key, order.Descending) switch
					{
						(Orders.AddressEmail, false) => queryable.OrderBy(_ => _.AddressEmail),
						(Orders.AddressEmail, true) => queryable.OrderByDescending(_ => _.AddressEmail),

						(Orders.AddressPostal, false) => queryable.OrderBy(_ => _.AddressPostal),
						(Orders.AddressPostal, true) => queryable.OrderByDescending(_ => _.AddressPostal),

						(Orders.AddressStreet, false) => queryable.OrderBy(_ => _.AddressStreet),
						(Orders.AddressStreet, true) => queryable.OrderByDescending(_ => _.AddressStreet),

						(Orders.Category, false) => queryable.OrderBy(_ => _.Category),
						(Orders.Category, true) => queryable.OrderByDescending(_ => _.Category),

						(Orders.GeoCode, false) => queryable.OrderBy(_ => _.GeoCode),
						(Orders.GeoCode, true) => queryable.OrderByDescending(_ => _.GeoCode),

						(Orders.GeoLevel, false) => queryable.OrderBy(_ => _.GeoLevel),
						(Orders.GeoLevel, true) => queryable.OrderByDescending(_ => _.GeoLevel),

						(Orders.IsDisestablished, false) => queryable.OrderBy(_ => _.IsDisestablished),
						(Orders.IsDisestablished, true) => queryable.OrderByDescending(_ => _.IsDisestablished),

						(Orders.MiifCategory, false) => queryable.OrderBy(_ => _.MiifCategory),
						(Orders.MiifCategory, true) => queryable.OrderByDescending(_ => _.MiifCategory),

						(Orders.Name, false) => queryable.OrderBy(_ => _.Name),
						(Orders.Name, true) => queryable.OrderByDescending(_ => _.Name),

						(Orders.NameLong, false) => queryable.OrderBy(_ => _.NameLong),
						(Orders.NameLong, true) => queryable.OrderByDescending(_ => _.NameLong),

						(Orders.NumberFax, false) => queryable.OrderBy(_ => _.NumberFax),
						(Orders.NumberFax, true) => queryable.OrderByDescending(_ => _.NumberFax),

						(Orders.NumberPhone, false) => queryable.OrderBy(_ => _.NumberPhone),
						(Orders.NumberPhone, true) => queryable.OrderByDescending(_ => _.NumberPhone),

						(Orders.PkCountry, false) => queryable.OrderBy(_ => _.PkCountry),
						(Orders.PkCountry, true) => queryable.OrderByDescending(_ => _.PkCountry),

						(Orders.PkDistrict, false) => queryable.OrderBy(_ => _.PkDistrict),
						(Orders.PkDistrict, true) => queryable.OrderByDescending(_ => _.PkDistrict),

						(Orders.PkProvince, false) => queryable.OrderBy(_ => _.PkProvince),
						(Orders.PkProvince, true) => queryable.OrderByDescending(_ => _.PkProvince),

						(Orders.Population, false) => queryable.OrderBy(_ => _.Population),
						(Orders.Population, true) => queryable.OrderByDescending(_ => _.Population),

						(Orders.SquareKms, false) => queryable.OrderBy(_ => _.SquareKms),
						(Orders.SquareKms, true) => queryable.OrderByDescending(_ => _.SquareKms),

						(Orders.UrlLogo, false) => queryable.OrderBy(_ => _.UrlLogo),
						(Orders.UrlLogo, true) => queryable.OrderByDescending(_ => _.UrlLogo),

						(Orders.UrlWebsite, false) => queryable.OrderBy(_ => _.UrlWebsite),
						(Orders.UrlWebsite, true) => queryable.OrderByDescending(_ => _.UrlWebsite),

						(_, _) => queryable.Order<Municipality>(order)
					};

			return orderedqueryable ?? queryable.Order<Municipality>(orders);
		}
		public static IOrderedEnumerable<Municipality> Order(this IOrderedEnumerable<Municipality> queryable, params Order[] orders)
		{
			IOrderedEnumerable<Municipality>? orderedqueryable = null;

			foreach (Order order in orders)
				orderedqueryable = (order.Key, order.Descending) switch
				{
					(Orders.AddressEmail, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.AddressEmail),
					(Orders.AddressEmail, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.AddressEmail),

					(Orders.AddressPostal, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.AddressPostal),
					(Orders.AddressPostal, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.AddressPostal),

					(Orders.AddressStreet, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.AddressStreet),
					(Orders.AddressStreet, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.AddressStreet),

					(Orders.Category, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.Category),
					(Orders.Category, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.Category),

					(Orders.GeoCode, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.GeoCode),
					(Orders.GeoCode, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.GeoCode),

					(Orders.GeoLevel, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.GeoLevel),
					(Orders.GeoLevel, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.GeoLevel),

					(Orders.IsDisestablished, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.IsDisestablished),
					(Orders.IsDisestablished, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.IsDisestablished),

					(Orders.MiifCategory, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.MiifCategory),
					(Orders.MiifCategory, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.MiifCategory),

					(Orders.Name, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.Name),
					(Orders.Name, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.Name),

					(Orders.NameLong, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.NameLong),
					(Orders.NameLong, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.NameLong),

					(Orders.NumberFax, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.NumberFax),
					(Orders.NumberFax, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.NumberFax),

					(Orders.NumberPhone, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.NumberPhone),
					(Orders.NumberPhone, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.NumberPhone),

					(Orders.PkCountry, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.PkCountry),
					(Orders.PkCountry, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.PkCountry),

					(Orders.PkDistrict, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.PkDistrict),
					(Orders.PkDistrict, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.PkDistrict),

					(Orders.PkProvince, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.PkProvince),
					(Orders.PkProvince, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.PkProvince),

					(Orders.Population, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.Population),
					(Orders.Population, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.Population),

					(Orders.SquareKms, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.SquareKms),
					(Orders.SquareKms, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.SquareKms),

					(Orders.UrlLogo, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.UrlLogo),
					(Orders.UrlLogo, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.UrlLogo),

					(Orders.UrlWebsite, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.UrlWebsite),
					(Orders.UrlWebsite, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.UrlWebsite),

					(_, _) => (orderedqueryable ?? queryable).Order<Municipality>(order)
				};

			return orderedqueryable ?? queryable;
		}
	}
}
