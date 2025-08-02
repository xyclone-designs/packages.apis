using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Models;
using XycloneDesigns.Apis.General.Http;
using XycloneDesigns.Apis.SAPS.Tables;

namespace XycloneDesigns.Apis.SAPS.Http
{
	public static partial class Categories
	{
		public class Orders : Base.Orders
		{
			public const string Name = Category.SQL.Column_Name;
			
			public new static IEnumerable<string> AsEnumerable()
			{
				return Base.Orders.AsEnumerable()
					.Append(Name);
			}
		}

		public static IOrderedEnumerable<Category> Order(this IEnumerable<Category> queryable, params Order[] orders)
		{
			IOrderedEnumerable<Category>? orderedqueryable = null;

			foreach (Order order in orders)
				orderedqueryable = orderedqueryable is not null
					? orderedqueryable.Order(order)
					: (order.Key, order.Descending) switch
					{
						(Orders.Name, false) => queryable.OrderBy(_ => _.Name),
						(Orders.Name, true) => queryable.OrderByDescending(_ => _.Name),

						(_, _) => queryable.Order<Category>(order)
					};

			return orderedqueryable ?? queryable.Order<Category>(orders);
		}
		public static IOrderedEnumerable<Category> Order(this IOrderedEnumerable<Category> queryable, params Order[] orders)
		{
			IOrderedEnumerable<Category>? orderedqueryable = null;

			foreach (Order order in orders)
				orderedqueryable = (order.Key, order.Descending) switch
				{
					(Orders.Name, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.Name),
					(Orders.Name, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.Name),

					(_, _) => (orderedqueryable ?? queryable).Order<Category>(order)
				};

			return orderedqueryable ?? queryable;
		}
	}
}
