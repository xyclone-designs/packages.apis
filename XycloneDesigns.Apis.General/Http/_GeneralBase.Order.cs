using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Models;
using XycloneDesigns.Apis.General.Tables;

namespace XycloneDesigns.Apis.General.Http
{
	public static partial class GeneralBase
	{
		public class Orders
		{
			public const string Pk = "pk";

			public static IEnumerable<string> AsEnumerable()
			{
				return Enumerable.Empty<string>()
					.Append(Pk);
			}
		}

		public static IOrderedEnumerable<TGeneralTable> Order<TGeneralTable>(this IEnumerable<TGeneralTable> queryable, params Order[] orders) where TGeneralTable : GeneralTable
		{
			IOrderedEnumerable<TGeneralTable>? orderedqueryable = null;

			foreach (Order order in orders)
				orderedqueryable = orderedqueryable is not null
					? orderedqueryable.Order(order)
					: (order.Key, order.Descending) switch
					{
						(_, false) => queryable.OrderBy(_ => _.Pk),
						(_, true) => queryable.OrderByDescending(_ => _.Pk)
					};

			return orderedqueryable ?? queryable.OrderBy(_ => _.Pk);
		}
		public static IOrderedEnumerable<TGeneralTable> Order<TGeneralTable>(this IOrderedEnumerable<TGeneralTable> queryable, params Order[] orders) where TGeneralTable : GeneralTable
		{
			IOrderedEnumerable<TGeneralTable>? orderedqueryable = null;

			foreach (Order order in orders)
				orderedqueryable = (order.Key, order.Descending) switch
				{
					(_, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.Pk),
					(_, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.Pk)
				};

			return orderedqueryable ?? queryable;
		}
	}
}
