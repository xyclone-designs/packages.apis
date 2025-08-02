using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Enums;
using XycloneDesigns.Apis.General.Http.Models;
using XycloneDesigns.Apis.General.Tables;

namespace XycloneDesigns.Apis.General.Http
{
	public static partial class Languages
	{
		public class Orders : Base.Orders
		{
			public const string Code = Language.SQL.Column_Code;
			public const string Name = Language.SQL.Column_Name;

			public new static IEnumerable<string> AsEnumerable()
			{
				return Base.Orders.AsEnumerable()
					.Append(Code)
					.Append(Name);
			}
		}

		public static IOrderedEnumerable<Language> Order(this IEnumerable<Language> queryable, params Order[] orders)
		{
			IOrderedEnumerable<Language>? orderedqueryable = null;

			foreach (Order order in orders)
				orderedqueryable = orderedqueryable is not null
					? orderedqueryable.Order(order)
					: (order.Key, order.Descending) switch
					{
						(Orders.Code, false) => queryable.OrderBy(_ => _.Code),
						(Orders.Code, true) => queryable.OrderByDescending(_ => _.Code),

						(Orders.Name, false) => queryable.OrderBy(_ => _.Name),
						(Orders.Name, true) => queryable.OrderByDescending(_ => _.Name),

						(_, _) => queryable.Order<Language>(order)
					};

			return orderedqueryable ?? queryable.Order<Language>(orders);
		}
		public static IOrderedEnumerable<Language> Order(this IOrderedEnumerable<Language> queryable, params Order[] orders)
		{
			IOrderedEnumerable<Language>? orderedqueryable = null;

			foreach (Order order in orders)
				orderedqueryable = (order.Key, order.Descending) switch
				{
					(Orders.Code, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.Code),
					(Orders.Code, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.Code),

					(Orders.Name, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.Name),
					(Orders.Name, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.Name),

					(_, _) => (orderedqueryable ?? queryable).Order<Language>(order)
				};

			return orderedqueryable ?? queryable;
		}
	}
}
