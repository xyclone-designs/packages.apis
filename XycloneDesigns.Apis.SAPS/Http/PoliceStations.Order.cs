using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Models;
using XycloneDesigns.Apis.General.Http;
using XycloneDesigns.Apis.SAPS.Tables;

namespace XycloneDesigns.Apis.SAPS.Http
{
	public static partial class PoliceStations
	{
		public class Orders : Base.Orders
		{
			public const string Name = PoliceStation.SQL.Column_Name;
			public const string PkCountry = PoliceStation.SQL.Column_PkCountry;
			public const string PkDistrict = PoliceStation.SQL.Column_PkDistrict;
			public const string PkMunicipality = PoliceStation.SQL.Column_PkMunicipality;
			public const string PkProvince = PoliceStation.SQL.Column_PkProvince;

			public new static IEnumerable<string> AsEnumerable()
			{
				return Base.Orders.AsEnumerable()
					.Append(Name)
					.Append(PkCountry)
					.Append(PkDistrict)
					.Append(PkMunicipality)
					.Append(PkProvince);
			}
		}

		public static IOrderedEnumerable<PoliceStation> Order(this IEnumerable<PoliceStation> queryable, params Order[] orders)
		{
			IOrderedEnumerable<PoliceStation>? orderedqueryable = null;

			foreach (Order order in orders)
				orderedqueryable = orderedqueryable is not null
					? orderedqueryable.Order(order)
					: (order.Key, order.Descending) switch
					{
						(Orders.Name, false) => queryable.OrderBy(_ => _.Name),
						(Orders.Name, true) => queryable.OrderByDescending(_ => _.Name),

						(Orders.PkCountry, false) => queryable.OrderBy(_ => _.PkCountry),
						(Orders.PkCountry, true) => queryable.OrderByDescending(_ => _.PkCountry),

						(Orders.PkDistrict, false) => queryable.OrderBy(_ => _.PkDistrict),
						(Orders.PkDistrict, true) => queryable.OrderByDescending(_ => _.PkDistrict),

						(Orders.PkMunicipality, false) => queryable.OrderBy(_ => _.PkMunicipality),
						(Orders.PkMunicipality, true) => queryable.OrderByDescending(_ => _.PkMunicipality),

						(Orders.PkProvince, false) => queryable.OrderBy(_ => _.PkProvince),
						(Orders.PkProvince, true) => queryable.OrderByDescending(_ => _.PkProvince),

						(_, _) => queryable.Order<PoliceStation>(order)
					};

			return orderedqueryable ?? queryable.Order<PoliceStation>(orders);
		}
		public static IOrderedEnumerable<PoliceStation> Order(this IOrderedEnumerable<PoliceStation> queryable, params Order[] orders)
		{
			IOrderedEnumerable<PoliceStation>? orderedqueryable = null;

			foreach (Order order in orders)
				orderedqueryable = (order.Key, order.Descending) switch
				{
					(Orders.Name, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.Name),
					(Orders.Name, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.Name),

					(Orders.PkCountry, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.PkCountry),
					(Orders.PkCountry, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.PkCountry),

					(Orders.PkDistrict, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.PkDistrict),
					(Orders.PkDistrict, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.PkDistrict),

					(Orders.PkMunicipality, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.PkMunicipality),
					(Orders.PkMunicipality, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.PkMunicipality),

					(Orders.PkProvince, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.PkProvince),
					(Orders.PkProvince, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.PkProvince),

					(_, _) => (orderedqueryable ?? queryable).Order<PoliceStation>(order)
				};

			return orderedqueryable ?? queryable;
		}
	}
}
