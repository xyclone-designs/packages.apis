using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Models;
using XycloneDesigns.Apis.General.Http;
using XycloneDesigns.Apis.IEC.Tables;

namespace XycloneDesigns.Apis.IEC.Http
{
	public static partial class Wards
	{
		public class Orders : GeneralBase.Orders
		{
			public const string Id = Ward.SQL.Column_Id;
			public const string PkCountry = Ward.SQL.Column_PkCountry;
			public const string PkDistrict = Ward.SQL.Column_PkDistrict;
			public const string PkMunicipality = Ward.SQL.Column_PkMunicipality;
			public const string PkProvince = Ward.SQL.Column_PkProvince;

			public new static IEnumerable<string> AsEnumerable()
			{
				return GeneralBase.Orders.AsEnumerable()
					.Append(Id)
					.Append(PkCountry)
					.Append(PkDistrict)
					.Append(PkMunicipality)
					.Append(PkProvince);
			}
		}

		public static IOrderedEnumerable<Ward> Order(this IEnumerable<Ward> queryable, params Order[] orders)
		{
			IOrderedEnumerable<Ward>? orderedqueryable = null;

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

						(_, _) => queryable.Order<Ward>(order)
					};

			return orderedqueryable ?? queryable.Order<Ward>(orders);
		}
		public static IOrderedEnumerable<Ward> Order(this IOrderedEnumerable<Ward> queryable, params Order[] orders)
		{
			IOrderedEnumerable<Ward>? orderedqueryable = null;

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

					(_, _) => (orderedqueryable ?? queryable).Order<Ward>(order)
				};

			return orderedqueryable ?? queryable;
		}
	}
}
