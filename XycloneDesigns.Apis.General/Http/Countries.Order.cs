using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Models;
using XycloneDesigns.Apis.General.Tables;

namespace XycloneDesigns.Apis.General.Http
{
	public static partial class Countries
	{
		public class Orders : Base.Orders
		{
			public const string Capital = Country.SQL.Column_Capital;
			public const string Code = Country.SQL.Column_Code;
			public const string Name = Country.SQL.Column_Name;
			public const string Population = Country.SQL.Column_Population;
			public const string SquareKms = Country.SQL.Column_SquareKms;

			public new static IEnumerable<string> AsEnumerable()
			{
				return Base.Orders.AsEnumerable()
					.Append(Capital)
					.Append(Code)
					.Append(Name)
					.Append(Population)
					.Append(SquareKms);
			}
		}

		public static IOrderedEnumerable<Country> Order(this IEnumerable<Country> queryable, params Order[] orders)
		{
			IOrderedEnumerable<Country>? orderedqueryable = null;

			foreach (Order order in orders)
				orderedqueryable = orderedqueryable is not null
					? orderedqueryable.Order(order)
					: (order.Key, order.Descending) switch
					{
						(Orders.Capital, false) => queryable.OrderBy(_ => _.Capital),
						(Orders.Capital, true) => queryable.OrderByDescending(_ => _.Capital),

						(Orders.Code, false) => queryable.OrderBy(_ => _.Code),
						(Orders.Code, true) => queryable.OrderByDescending(_ => _.Code),

						(Orders.Name, false) => queryable.OrderBy(_ => _.Name),
						(Orders.Name, true) => queryable.OrderByDescending(_ => _.Name),

						(Orders.Population, false) => queryable.OrderBy(_ => _.Population),
						(Orders.Population, true) => queryable.OrderByDescending(_ => _.Population),

						(Orders.SquareKms, false) => queryable.OrderBy(_ => _.SquareKms),
						(Orders.SquareKms, true) => queryable.OrderByDescending(_ => _.SquareKms),

						(_, _) => queryable.Order<Country>(order)
					};

			return orderedqueryable ?? queryable.Order<Country>(orders);
		}
		public static IOrderedEnumerable<Country> Order(this IOrderedEnumerable<Country> queryable, params Order[] orders)
		{
			IOrderedEnumerable<Country>? orderedqueryable = null;

			foreach (Order order in orders)
				orderedqueryable = (order.Key, order.Descending) switch
				{
					(Orders.Capital, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.Capital),
					(Orders.Capital, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.Capital),

					(Orders.Code, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.Code),
					(Orders.Code, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.Code),

					(Orders.Name, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.Name),
					(Orders.Name, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.Name),

					(Orders.Population, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.Population),
					(Orders.Population, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.Population),

					(Orders.SquareKms, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.SquareKms),
					(Orders.SquareKms, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.SquareKms),

					(_, _) => (orderedqueryable ?? queryable).Order<Country>(order)
				};

			return orderedqueryable ?? queryable;
		}
	}
}
