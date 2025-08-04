using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Models;
using XycloneDesigns.Apis.General.Http;
using XycloneDesigns.Apis.Afrobarometer.Tables;

namespace XycloneDesigns.Apis.Afrobarometer.Http
{
	public static partial class Variables
	{
		public class Orders : GeneralBase.Orders
		{
			public const string Id = Variable.SQL.Column_Id;
			public const string Label = Variable.SQL.Column_Label;
			public const string ValueLabels = Variable.SQL.Column_ValueLabels;

			public new static IEnumerable<string> AsEnumerable()
			{
				return GeneralBase.Orders.AsEnumerable()
					.Append(Id)
					.Append(Label)
					.Append(ValueLabels);
			}
		}

		public static IOrderedEnumerable<Variable> Order(this IEnumerable<Variable> queryable, params Order[] orders)
		{
			IOrderedEnumerable<Variable>? orderedqueryable = null;

			foreach (Order order in orders)
				orderedqueryable = orderedqueryable is not null
					? orderedqueryable.Order(order)
					: (order.Key, order.Descending) switch
					{
						(Orders.Id, false) => queryable.OrderBy(_ => _.Id),
						(Orders.Id, true) => queryable.OrderByDescending(_ => _.Id),

						(Orders.Label, false) => queryable.OrderBy(_ => _.Label),
						(Orders.Label, true) => queryable.OrderByDescending(_ => _.Label),

						(Orders.ValueLabels, false) => queryable.OrderBy(_ => _.ValueLabels),
						(Orders.ValueLabels, true) => queryable.OrderByDescending(_ => _.ValueLabels),

						(_, _) => queryable.Order<Variable>(order)
					};

			return orderedqueryable ?? queryable.Order<Variable>(orders);
		}
		public static IOrderedEnumerable<Variable> Order(this IOrderedEnumerable<Variable> queryable, params Order[] orders)
		{
			IOrderedEnumerable<Variable>? orderedqueryable = null;

			foreach (Order order in orders)
				orderedqueryable = (order.Key, order.Descending) switch
				{
					(Orders.Id, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.Id),
					(Orders.Id, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.Id),

					(Orders.Label, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.Label),
					(Orders.Label, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.Label),

					(Orders.ValueLabels, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.ValueLabels),
					(Orders.ValueLabels, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.ValueLabels),

					(_, _) => (orderedqueryable ?? queryable).Order<Variable>(order)
				};

			return orderedqueryable ?? queryable;
		}
	}
}
