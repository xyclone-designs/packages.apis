using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.IEC.Tables;

namespace XycloneDesigns.Apis.IEC.Http.Rest
{
	public partial class Wards 
	{
		public class OrderKeys : IECRest.OrderKeys
		{
			public const string Id = "id";
			public const string Municipality = "municipality";
			public const string Province = "province";

			public static IOrderedQueryable<Ward> Order(IQueryable<Ward> queryable, string orderkey, bool reverse)
			{
				return (orderkey, reverse) switch
				{
					(Id, true) => queryable.OrderByDescending(_ => _.Id),
					(Id, false) => queryable.OrderBy(_ => _.Id),

					(Municipality, false) => queryable.OrderBy(_ => _.PkMunicipality),
					(Municipality, true) => queryable.OrderByDescending(_ => _.PkMunicipality),

					(Province, false) => queryable.OrderBy(_ => _.PkProvince),
					(Province, true) => queryable.OrderByDescending(_ => _.PkProvince),

					(_, _) => IECRest.OrderKeys.Order(queryable, orderkey, reverse)
				};
			}
			public static IQueryable<Ward> Order(IQueryable<Ward> queryable, bool reverse, params string[] orderkeys)
			{
				IOrderedQueryable<Ward>? ordered = null;

				foreach (string orderkey in orderkeys)
					ordered = Order(ordered ?? queryable, orderkey, reverse);

				return ordered ?? queryable;
			}

			public new static IEnumerable<string> AsEnumerable()
			{
				return IECRest.OrderKeys.AsEnumerable()
					.Append(Id)
					.Append(Municipality)
					.Append(Province);
			}
		}
	}
}
