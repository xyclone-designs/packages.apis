using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Models;
using XycloneDesigns.Apis.General.Http;
using XycloneDesigns.Apis.IEC.Tables;

namespace XycloneDesigns.Apis.IEC.Http
{
	public static partial class ElectoralEvents
	{
		public class Orders : Base.Orders
		{
			public const string Abbr = ElectoralEvent.SQL.Column_Abbr;
			public const string Date = ElectoralEvent.SQL.Column_Date;
			public const string Name = ElectoralEvent.SQL.Column_Name;
			public const string Type = ElectoralEvent.SQL.Column_Type;

			public new static IEnumerable<string> AsEnumerable()
			{
				return Base.Orders.AsEnumerable()
					.Append(Abbr)
					.Append(Date)
					.Append(Name)
					.Append(Type);
			}
		}

		public static IOrderedEnumerable<ElectoralEvent> Order(this IEnumerable<ElectoralEvent> queryable, params Order[] orders)
		{
			IOrderedEnumerable<ElectoralEvent>? orderedqueryable = null;

			foreach (Order order in orders)
				orderedqueryable = orderedqueryable is not null
					? orderedqueryable.Order(order)
					: (order.Key, order.Descending) switch
					{
						(Orders.Abbr, false) => queryable.OrderBy(_ => _.Abbr),
						(Orders.Abbr, true) => queryable.OrderByDescending(_ => _.Abbr),

						(Orders.Date, false) => queryable.OrderBy(_ => _.Date),
						(Orders.Date, true) => queryable.OrderByDescending(_ => _.Date),

						(Orders.Name, false) => queryable.OrderBy(_ => _.Name),
						(Orders.Name, true) => queryable.OrderByDescending(_ => _.Name),

						(Orders.Type, false) => queryable.OrderBy(_ => _.Type),
						(Orders.Type, true) => queryable.OrderByDescending(_ => _.Type),

						(_, _) => queryable.Order<ElectoralEvent>(order)
					};

			return orderedqueryable ?? queryable.Order<ElectoralEvent>(orders);
		}
		public static IOrderedEnumerable<ElectoralEvent> Order(this IOrderedEnumerable<ElectoralEvent> queryable, params Order[] orders)
		{
			IOrderedEnumerable<ElectoralEvent>? orderedqueryable = null;

			foreach (Order order in orders)
				orderedqueryable = (order.Key, order.Descending) switch
				{
					(Orders.Abbr, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.Abbr),
					(Orders.Abbr, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.Abbr),

					(Orders.Date, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.Date),
					(Orders.Date, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.Date),
						
					(Orders.Name, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.Name),
					(Orders.Name, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.Name),

					(Orders.Type, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.Type),
					(Orders.Type, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.Type),

					(_, _) => (orderedqueryable ?? queryable).Order<ElectoralEvent>(order)
				};

			return orderedqueryable ?? queryable;
		}
	}
}
