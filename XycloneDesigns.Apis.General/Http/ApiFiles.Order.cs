using System;
using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Enums;
using XycloneDesigns.Apis.General.Http.Models;

namespace XycloneDesigns.Apis.General.Http
{
	public static partial class ApiFiles
	{
		public class Orders : Base.Orders
		{
			public const string DateCreated = "dateCreated";
			public const string DateEdited = "dateEdited";
			public const string Name = "name";

			public new static IEnumerable<string> AsEnumerable()
			{
				return Base.Orders.AsEnumerable()
					.Append(DateCreated)
					.Append(DateEdited)
					.Append(Name);
			}
		}

		public static IOrderedEnumerable<ApiFile> Order(this IEnumerable<ApiFile> queryable, params Order[] orders)
		{
			IOrderedEnumerable<ApiFile>? orderedqueryable = null;

			foreach (Order order in orders)
				orderedqueryable = orderedqueryable is not null
					? orderedqueryable.Order(order)
					: (order.Key, order.Descending) switch
					{
						(Orders.DateCreated, false) => queryable.OrderBy(_ => _.DateCreated),
						(Orders.DateCreated, true) => queryable.OrderByDescending(_ => _.DateCreated),

						(Orders.DateEdited, false) => queryable.OrderBy(_ => _.DateEdited),
						(Orders.DateEdited, true) => queryable.OrderByDescending(_ => _.DateEdited),

						(Orders.Name or _, false) => queryable.OrderBy(_ => _.Name),
						(Orders.Name or _, true) => queryable.OrderByDescending(_ => _.Name),
					};

			return orderedqueryable ?? queryable.OrderBy(_ => _.Name);
		}
		public static IOrderedEnumerable<ApiFile> Order(this IOrderedEnumerable<ApiFile> queryable, params Order[] orders)
		{
			IOrderedEnumerable<ApiFile>? orderedqueryable = null;

			foreach (Order order in orders)
				orderedqueryable = (order.Key, order.Descending) switch
				{
					(Orders.DateCreated, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.DateCreated),
					(Orders.DateCreated, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.DateCreated),

					(Orders.DateEdited, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.DateEdited),
					(Orders.DateEdited, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.DateEdited),

					(Orders.Name or _, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.Name),
					(Orders.Name or _, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.Name),
				};

			return orderedqueryable ?? queryable;
		}
	}
}
