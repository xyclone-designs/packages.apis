using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.IEC.Tables;

namespace XycloneDesigns.Apis.IEC.Http.Rest
{
	public partial class VotingDistricts 
	{
		public class OrderKeys : IECRest.OrderKeys
		{
			public const string Id = "id";
			public const string Municipality = "municipality";
			public const string Province = "province";
			public const string Ward = "ward";

			public static IOrderedQueryable<VotingDistrict> Order(IQueryable<VotingDistrict> queryable, string orderkey, bool reverse)
			{
				return (orderkey, reverse) switch
				{
					(Id, false) => queryable.OrderBy(_ => _.Id),
					(Id, true) => queryable.OrderByDescending(_ => _.Id),

					(Municipality, false) => queryable.OrderBy(_ => _.PkMunicipality),
					(Municipality, true) => queryable.OrderByDescending(_ => _.PkMunicipality),

					(Province, false) => queryable.OrderBy(_ => _.PkProvince),
					(Province, true) => queryable.OrderByDescending(_ => _.PkProvince),

					(Ward, false) => queryable.OrderBy(_ => _.PkWard),
					(Ward, true) => queryable.OrderByDescending(_ => _.PkWard),

					(_, _) => IECRest.OrderKeys.Order(queryable, orderkey, reverse)
				};
			}
			public static IQueryable<VotingDistrict> Order(IQueryable<VotingDistrict> queryable, bool reverse, params string[] orderkeys)
			{
				IOrderedQueryable<VotingDistrict>? ordered = null;

				foreach (string orderkey in orderkeys)
					ordered = Order(ordered ?? queryable, orderkey, reverse);

				return ordered ?? queryable;
			}

			public new static IEnumerable<string> AsEnumerable()
			{
				return IECRest.OrderKeys.AsEnumerable()
					.Append(Id)
					.Append(Municipality)
					.Append(Province)
					.Append(Ward);
			}
		}
	}
}
