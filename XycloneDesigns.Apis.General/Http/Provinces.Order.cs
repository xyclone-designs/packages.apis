using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Models;
using XycloneDesigns.Apis.General.Tables;

namespace XycloneDesigns.Apis.General.Http
{
	public static partial class Provinces
	{
		public class Orders : Base.Orders
		{
			public const string Capital = Province.SQL.Column_Capital;
			public const string Code = Province.SQL.Column_Code;
			public const string Name = Province.SQL.Column_Name;
			public const string Population = Province.SQL.Column_Population;
			public const string PkCountry = Province.SQL.Column_PkCountry;
			public const string SquareKms = Province.SQL.Column_SquareKms;

			public new static IEnumerable<string> AsEnumerable()
			{
				return Base.Orders.AsEnumerable()
					.Append(Capital)
					.Append(Code)
					.Append(Name)
					.Append(Population)
					.Append(PkCountry)
					.Append(SquareKms);
			}
		}

		public static IOrderedEnumerable<Province> Order(this IEnumerable<Province> queryable, params Order[] orders)
		{
			IOrderedEnumerable<Province>? orderedqueryable = null;

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

						(Orders.PkCountry, false) => queryable.OrderBy(_ => _.PkCountry),
						(Orders.PkCountry, true) => queryable.OrderByDescending(_ => _.PkCountry),

						(Orders.SquareKms, false) => queryable.OrderBy(_ => _.SquareKms),
						(Orders.SquareKms, true) => queryable.OrderByDescending(_ => _.SquareKms),

						(_, _) => queryable.Order<Province>(order)
					};

			return orderedqueryable ?? queryable.Order<Province>(orders);
		}
		public static IOrderedEnumerable<Province> Order(this IOrderedEnumerable<Province> queryable, params Order[] orders)
		{
			IOrderedEnumerable<Province>? orderedqueryable = null;

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

					(Orders.PkCountry, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.PkCountry),
					(Orders.PkCountry, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.PkCountry),

					(Orders.SquareKms, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.SquareKms),
					(Orders.SquareKms, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.SquareKms),

					(_, _) => queryable.Order<Province>(order)
				};

			return orderedqueryable ?? queryable;
		}
	}
}
