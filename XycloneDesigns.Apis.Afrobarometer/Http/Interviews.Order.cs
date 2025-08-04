using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Models;
using XycloneDesigns.Apis.General.Http;
using XycloneDesigns.Apis.Afrobarometer.Tables;

namespace XycloneDesigns.Apis.Afrobarometer.Http
{
	public static partial class Interviews
	{
		public class Orders : GeneralBase.Orders
		{
			public const string List_PkVariable_Record = Interview.SQL.Column_List_PkVariable_Record;
			public const string PkLanguage = Interview.SQL.Column_PkLanguage;
			public const string PkSurvey = Interview.SQL.Column_PkSurvey;
			public const string Round = Interview.SQL.Column_Round;

			public new static IEnumerable<string> AsEnumerable()
			{
				return GeneralBase.Orders.AsEnumerable()
					.Append(List_PkVariable_Record)
					.Append(PkLanguage)
					.Append(PkSurvey)
					.Append(Round);
			}
		}

		public static IOrderedEnumerable<Interview> Order(this IEnumerable<Interview> queryable, params Order[] orders)
		{
			IOrderedEnumerable<Interview>? orderedqueryable = null;

			foreach (Order order in orders)
				orderedqueryable = orderedqueryable is not null
					? orderedqueryable.Order(order)
					: (order.Key, order.Descending) switch
					{
						(Orders.List_PkVariable_Record, false) => queryable.OrderBy(_ => _.List_PkVariable_Record),
						(Orders.List_PkVariable_Record, true) => queryable.OrderByDescending(_ => _.List_PkVariable_Record),

						(Orders.PkLanguage, false) => queryable.OrderBy(_ => _.PkLanguage),
						(Orders.PkLanguage, true) => queryable.OrderByDescending(_ => _.PkLanguage),

						(Orders.PkSurvey, false) => queryable.OrderBy(_ => _.PkSurvey),
						(Orders.PkSurvey, true) => queryable.OrderByDescending(_ => _.PkSurvey),

						(Orders.Round, false) => queryable.OrderBy(_ => _.Round),
						(Orders.Round, true) => queryable.OrderByDescending(_ => _.Round),

						(_, _) => queryable.Order<Interview>(order)
					};

			return orderedqueryable ?? queryable.Order<Interview>(orders);
		}
		public static IOrderedEnumerable<Interview> Order(this IOrderedEnumerable<Interview> queryable, params Order[] orders)
		{
			IOrderedEnumerable<Interview>? orderedqueryable = null;

			foreach (Order order in orders)
				orderedqueryable = (order.Key, order.Descending) switch
				{
					(Orders.List_PkVariable_Record, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.List_PkVariable_Record),
					(Orders.List_PkVariable_Record, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.List_PkVariable_Record),

					(Orders.PkLanguage, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.PkLanguage),
					(Orders.PkLanguage, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.PkLanguage),

					(Orders.PkSurvey, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.PkSurvey),
					(Orders.PkSurvey, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.PkSurvey),

					(Orders.Round, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.Round),
					(Orders.Round, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.Round),

					(_, _) => (orderedqueryable ?? queryable).Order<Interview>(order)
				};

			return orderedqueryable ?? queryable;
		}
	}
}
