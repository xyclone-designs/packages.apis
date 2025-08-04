using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Models;
using XycloneDesigns.Apis.General.Http;
using XycloneDesigns.Apis.IEC.Tables;

namespace XycloneDesigns.Apis.IEC.Http
{
	public static partial class VotingDistricts
	{
		public class Orders : GeneralBase.Orders
		{
			public const string Id = VotingDistrict.SQL.Column_Id;
			public const string PkCountry = VotingDistrict.SQL.Column_PkCountry;
			public const string PkDistrict = VotingDistrict.SQL.Column_PkDistrict;
			public const string PkMunicipality = VotingDistrict.SQL.Column_PkMunicipality;
			public const string PkProvince = VotingDistrict.SQL.Column_PkProvince;
			public const string PkWard = VotingDistrict.SQL.Column_PkWard;

			public new static IEnumerable<string> AsEnumerable()
			{
				return GeneralBase.Orders.AsEnumerable()
					.Append(Id)
					.Append(PkCountry)
					.Append(PkDistrict)
					.Append(PkMunicipality)
					.Append(PkProvince)
					.Append(PkWard);
			}
		}

		public static IOrderedEnumerable<VotingDistrict> Order(this IEnumerable<VotingDistrict> queryable, params Order[] orders)
		{
			IOrderedEnumerable<VotingDistrict>? orderedqueryable = null;

			foreach (Order order in orders)
				orderedqueryable = orderedqueryable is not null
					? orderedqueryable.Order(order)
					: (order.Key, order.Descending) switch
					{
						(Orders.Id, false) => queryable.OrderBy(_ => _.Id),
						(Orders.Id, true) => queryable.OrderByDescending(_ => _.Id),

						(Orders.PkCountry, false) => queryable.OrderBy(_ => _.PkCountry),
						(Orders.PkCountry, true) => queryable.OrderByDescending(_ => _.PkCountry),

						(Orders.PkDistrict, false) => queryable.OrderBy(_ => _.PkDistrict),
						(Orders.PkDistrict, true) => queryable.OrderByDescending(_ => _.PkDistrict),

						(Orders.PkMunicipality, false) => queryable.OrderBy(_ => _.PkMunicipality),
						(Orders.PkMunicipality, true) => queryable.OrderByDescending(_ => _.PkMunicipality),

						(Orders.PkProvince, false) => queryable.OrderBy(_ => _.PkProvince),
						(Orders.PkProvince, true) => queryable.OrderByDescending(_ => _.PkProvince),

						(Orders.PkWard, false) => queryable.OrderBy(_ => _.PkWard),
						(Orders.PkWard, true) => queryable.OrderByDescending(_ => _.PkWard),

						(_, _) => queryable.Order<VotingDistrict>(order)
					};

			return orderedqueryable ?? queryable.Order<VotingDistrict>(orders);
		}
		public static IOrderedEnumerable<VotingDistrict> Order(this IOrderedEnumerable<VotingDistrict> queryable, params Order[] orders)
		{
			IOrderedEnumerable<VotingDistrict>? orderedqueryable = null;

			foreach (Order order in orders)
				orderedqueryable = (order.Key, order.Descending) switch
				{
					(Orders.Id, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.Id),
					(Orders.Id, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.Id),

					(Orders.PkCountry, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.PkCountry),
					(Orders.PkCountry, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.PkCountry),

					(Orders.PkDistrict, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.PkDistrict),
					(Orders.PkDistrict, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.PkDistrict),

					(Orders.PkMunicipality, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.PkMunicipality),
					(Orders.PkMunicipality, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.PkMunicipality),

					(Orders.PkProvince, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.PkProvince),
					(Orders.PkProvince, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.PkProvince),

					(Orders.PkWard, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.PkWard),
					(Orders.PkWard, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.PkWard),

					(_, _) => (orderedqueryable ?? queryable).Order<VotingDistrict>(order)
				};

			return orderedqueryable ?? queryable;
		}
	}
}
