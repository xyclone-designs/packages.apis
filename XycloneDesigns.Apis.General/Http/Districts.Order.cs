using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Enums;
using XycloneDesigns.Apis.General.Http.Models;
using XycloneDesigns.Apis.General.Tables;

namespace XycloneDesigns.Apis.General.Http
{
	public static partial class Districts
	{
		public class Orders : GeneralBase.Orders
		{
			public const string Code = District.SQL.Column_Code;
			public const string Name = District.SQL.Column_Name;
			public const string PkProvince = District.SQL.Column_PkProvince;
			public const string PkCountry = District.SQL.Column_PkCountry;

			public new static IEnumerable<string> AsEnumerable()
			{
				return GeneralBase.Orders.AsEnumerable()
					.Append(Code)
					.Append(Name)
					.Append(PkProvince)
					.Append(PkCountry);
			}
		}

		public static IOrderedEnumerable<District> Order(this IEnumerable<District> queryable, params Order[] orders)
		{
			IOrderedEnumerable<District>? orderedqueryable = null;

			foreach (Order order in orders)
				orderedqueryable = orderedqueryable is not null
					? orderedqueryable.Order(order)
					: (order.Key, order.Descending) switch
					{
						(Orders.Code, false) => queryable.OrderBy(_ => _.Code),
						(Orders.Code, true) => queryable.OrderByDescending(_ => _.Code),

						(Orders.Name, false) => queryable.OrderBy(_ => _.Name),
						(Orders.Name, true) => queryable.OrderByDescending(_ => _.Name),

						(Orders.PkProvince, false) => queryable.OrderBy(_ => _.PkProvince),
						(Orders.PkProvince, true) => queryable.OrderByDescending(_ => _.PkProvince),

						(Orders.PkCountry, false) => queryable.OrderBy(_ => _.PkCountry),
						(Orders.PkCountry, true) => queryable.OrderByDescending(_ => _.PkCountry),

						(_, _) => queryable.Order<District>(order)
					};

			return orderedqueryable ?? queryable.Order<District>(orders);
		}
		public static IOrderedEnumerable<District> Order(this IOrderedEnumerable<District> queryable, params Order[] orders)
		{
			IOrderedEnumerable<District>? orderedqueryable = null;

			foreach (Order order in orders)
				orderedqueryable = (order.Key, order.Descending) switch
				{
					(Orders.Code, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.Code),
					(Orders.Code, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.Code),

					(Orders.Name, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.Name),
					(Orders.Name, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.Name),

					(Orders.PkProvince, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.PkProvince),
					(Orders.PkProvince, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.PkProvince),

					(Orders.PkCountry, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.PkCountry),
					(Orders.PkCountry, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.PkCountry),

					(_, _) => (orderedqueryable ?? queryable).Order<District>(order)
				};

			return orderedqueryable ?? queryable;
		}
	}
}
