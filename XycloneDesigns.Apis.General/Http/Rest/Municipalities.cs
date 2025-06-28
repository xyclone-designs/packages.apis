using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Tables;

namespace XycloneDesigns.Apis.General.Http.Rest
{
	public partial class Municipalities 
	{
		public class OrderKeys 
		{
			public const string GeoLevel = "geoLevel";
			public const string GeoCode = "geoCode";
			public const string IsDisestablished = "isDisestablished";
			public const string MiifCategory = "miifCategory";
			public const string Name = "name";
			public const string NameLong = "nameLong";
			public const string Province = "province";
			public const string Population = "population";
			public const string SquareKms = "squareKms";
			public const string WardCount = "wardCount";

			public static IOrderedQueryable<Municipality> Order(IQueryable<Municipality> queryable, string orderkey, bool reverse)
			{
				return (orderkey, reverse) switch
				{
					(GeoLevel, false) => queryable.OrderBy(_ => _.GeoLevel),
					(GeoLevel, true) => queryable.OrderByDescending(_ => _.GeoLevel),

					(GeoCode, false) => queryable.OrderBy(_ => _.GeoCode),
					(GeoCode, true) => queryable.OrderByDescending(_ => _.GeoCode),

					(IsDisestablished, false) => queryable.OrderBy(_ => _.IsDisestablished),
					(IsDisestablished, true) => queryable.OrderByDescending(_ => _.IsDisestablished),

					(MiifCategory, false) => queryable.OrderBy(_ => _.MiifCategory),
					(MiifCategory, true) => queryable.OrderByDescending(_ => _.MiifCategory),

					(Name, false) => queryable.OrderBy(_ => _.Name),
					(Name, true) => queryable.OrderByDescending(_ => _.Name),

					(NameLong, false) => queryable.OrderBy(_ => _.NameLong),
					(NameLong, true) => queryable.OrderByDescending(_ => _.NameLong),

					(Province, false) => queryable.OrderBy(_ => _.PkProvince),
					(Province, true) => queryable.OrderByDescending(_ => _.PkProvince),

					(Population, false) => queryable.OrderByDescending(_ => _.Population),
					(Population, true) => queryable.OrderBy(_ => _.Population),

					(SquareKms, false) => queryable.OrderByDescending(_ => _.SquareKms),
					(SquareKms, true) => queryable.OrderBy(_ => _.SquareKms),

					(_, _) => GeneralRest.OrderKeys.Order(queryable, orderkey, reverse)
				};
			}
			public static IQueryable<Municipality> Order(IQueryable<Municipality> queryable, bool reverse, params string[] orderkeys)
			{
				IOrderedQueryable<Municipality>? ordered = null;

				foreach (string orderkey in orderkeys)
					ordered = Order(ordered ?? queryable, orderkey, reverse);

				return ordered ?? queryable;
			}

			public static IEnumerable<string> AsEnumerable()
			{
				return GeneralRest.OrderKeys.AsEnumerable()
					.Append(GeoCode)
					.Append(GeoLevel)
					.Append(IsDisestablished)
					.Append(MiifCategory)
					.Append(Name)
					.Append(NameLong)
					.Append(Province)
					.Append(Population)
					.Append(SquareKms)
					.Append(WardCount);
			}
		}
	}
}
