using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.SAPS.Tables;

namespace XycloneDesigns.Apis.SAPS.Http.Rest
{
	public partial class PoliceStations 
	{
		public class OrderKeys : SAPSRest.OrderKeys
		{
			public const string District = "district";
			public const string Municipality = "municipality";
			public const string Name = "name";
			public const string Province = "province";

			public static IOrderedQueryable<PoliceStation> Order(IQueryable<PoliceStation> queryable, string orderkey, bool reverse)
			{
				return (orderkey, reverse) switch
				{
					(District, false) => queryable.OrderBy(_ => _.PkDistrict),
					(District, true) => queryable.OrderByDescending(_ => _.PkDistrict),

					(Municipality, false) => queryable.OrderBy(_ => _.PkMunicipality),
					(Municipality, true) => queryable.OrderByDescending(_ => _.PkMunicipality),

					(Name, false) => queryable.OrderBy(_ => _.Name),
					(Name, true) => queryable.OrderByDescending(_ => _.Name),

					(Province, false) => queryable.OrderBy(_ => _.PkProvince),
					(Province, true) => queryable.OrderByDescending(_ => _.PkProvince),

					(_, _) => SAPSRest.OrderKeys.Order(queryable, orderkey, reverse)
				};
			}
			public static IQueryable<PoliceStation> Order(IQueryable<PoliceStation> queryable, bool reverse, params string[] orderkeys)
			{
				IOrderedQueryable<PoliceStation>? ordered = null;

				foreach (string orderkey in orderkeys)
					ordered = Order(ordered ?? queryable, orderkey, reverse);

				return ordered ?? queryable;
			}

			public new static IEnumerable<string> AsEnumerable()
			{
				return SAPSRest.OrderKeys.AsEnumerable()
					.Append(District)
					.Append(Municipality)
					.Append(Name)
					.Append(Province);
			}
		}
	}
}
