using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Models;
using XycloneDesigns.Apis.General.Http;
using XycloneDesigns.Apis.SAPS.Tables;

namespace XycloneDesigns.Apis.SAPS.Http
{
	public static partial class Records
	{
		public class Orders : Base.Orders
		{
			public const string List_PkCategoryValue = Record.SQL.Column_List_PkCategoryValue;
			public const string PkPoliceStation = Record.SQL.Column_PkPoliceStation;
			public const string Year = Record.SQL.Column_Year;
			
			public new static IEnumerable<string> AsEnumerable()
			{
				return Base.Orders.AsEnumerable()
					.Append(List_PkCategoryValue)
					.Append(PkPoliceStation)
					.Append(Year);
			}
		}

		public static IOrderedEnumerable<Record> Order(this IEnumerable<Record> queryable, params Order[] orders)
		{
			IOrderedEnumerable<Record>? orderedqueryable = null;

			foreach (Order order in orders)
				orderedqueryable = orderedqueryable is not null
					? orderedqueryable.Order(order)
					: (order.Key, order.Descending) switch
					{
						(Orders.List_PkCategoryValue, false) => queryable.OrderBy(_ => _.List_PkCategoryValue),
						(Orders.List_PkCategoryValue, true) => queryable.OrderByDescending(_ => _.List_PkCategoryValue),

						(Orders.PkPoliceStation, false) => queryable.OrderBy(_ => _.PkPoliceStation),
						(Orders.PkPoliceStation, true) => queryable.OrderByDescending(_ => _.PkPoliceStation),

						(Orders.Year, false) => queryable.OrderBy(_ => _.Year),
						(Orders.Year, true) => queryable.OrderByDescending(_ => _.Year),

						(_, _) => queryable.Order<Record>(order)
					};

			return orderedqueryable ?? queryable.Order<Record>(orders);
		}
		public static IOrderedEnumerable<Record> Order(this IOrderedEnumerable<Record> queryable, params Order[] orders)
		{
			IOrderedEnumerable<Record>? orderedqueryable = null;

			foreach (Order order in orders)
				orderedqueryable = (order.Key, order.Descending) switch
				{
					(Orders.List_PkCategoryValue, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.List_PkCategoryValue),
					(Orders.List_PkCategoryValue, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.List_PkCategoryValue),

					(Orders.PkPoliceStation, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.PkPoliceStation),
					(Orders.PkPoliceStation, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.PkPoliceStation),

					(Orders.Year, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.Year),
					(Orders.Year, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.Year),

					(_, _) => (orderedqueryable ?? queryable).Order<Record>(order)
				};

			return orderedqueryable ?? queryable;
		}
	}
}
