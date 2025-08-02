using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Models;
using XycloneDesigns.Apis.General.Http;
using XycloneDesigns.Apis.Afrobarometer.Tables;

namespace XycloneDesigns.Apis.Afrobarometer.Http
{
	public static partial class Surveys
	{
		public class Orders : Base.Orders
		{
			public const string InterviewCount = Survey.SQL.Column_InterviewCount;
			public const string List_PkQuestion = Survey.SQL.Column_List_PkQuestion;
			public const string List_PkVariable = Survey.SQL.Column_List_PkVariable;
			public const string PkCountry = Survey.SQL.Column_PkCountry;
			public const string PkLanguage = Survey.SQL.Column_PkLanguage;
			public const string Round = Survey.SQL.Column_Round;

			public new static IEnumerable<string> AsEnumerable()
			{
				return Base.Orders.AsEnumerable()
					.Append(InterviewCount)
					.Append(List_PkQuestion)
					.Append(List_PkVariable)
					.Append(PkCountry)
					.Append(PkLanguage)
					.Append(Round);
			}
		}

		public static IOrderedEnumerable<Survey> Order(this IEnumerable<Survey> queryable, params Order[] orders)
		{
			IOrderedEnumerable<Survey>? orderedqueryable = null;

			foreach (Order order in orders)
				orderedqueryable = orderedqueryable is not null
					? orderedqueryable.Order(order)
					: (order.Key, order.Descending) switch
					{
						(Orders.InterviewCount, false) => queryable.OrderBy(_ => _.InterviewCount),
						(Orders.InterviewCount, true) => queryable.OrderByDescending(_ => _.InterviewCount),

						(Orders.List_PkQuestion, false) => queryable.OrderBy(_ => _.List_PkQuestion),
						(Orders.List_PkQuestion, true) => queryable.OrderByDescending(_ => _.List_PkQuestion),

						(Orders.List_PkVariable, false) => queryable.OrderBy(_ => _.List_PkVariable),
						(Orders.List_PkVariable, true) => queryable.OrderByDescending(_ => _.List_PkVariable),

						(Orders.PkCountry, false) => queryable.OrderBy(_ => _.PkCountry),
						(Orders.PkCountry, true) => queryable.OrderByDescending(_ => _.PkCountry),

						(Orders.PkLanguage, false) => queryable.OrderBy(_ => _.PkLanguage),
						(Orders.PkLanguage, true) => queryable.OrderByDescending(_ => _.PkLanguage),

						(Orders.Round, false) => queryable.OrderBy(_ => _.Round),
						(Orders.Round, true) => queryable.OrderByDescending(_ => _.Round),

						(_, _) => queryable.Order<Survey>(order)
					};

			return orderedqueryable ?? queryable.Order<Survey>(orders);
		}
		public static IOrderedEnumerable<Survey> Order(this IOrderedEnumerable<Survey> queryable, params Order[] orders)
		{
			IOrderedEnumerable<Survey>? orderedqueryable = null;

			foreach (Order order in orders)
				orderedqueryable = (order.Key, order.Descending) switch
				{
					(Orders.InterviewCount, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.InterviewCount),
					(Orders.InterviewCount, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.InterviewCount),

					(Orders.List_PkQuestion, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.List_PkQuestion),
					(Orders.List_PkQuestion, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.List_PkQuestion),

					(Orders.List_PkVariable, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.List_PkVariable),
					(Orders.List_PkVariable, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.List_PkVariable),

					(Orders.PkCountry, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.PkCountry),
					(Orders.PkCountry, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.PkCountry),

					(Orders.PkLanguage, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.PkLanguage),
					(Orders.PkLanguage, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.PkLanguage),

					(Orders.Round, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.Round),
					(Orders.Round, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.Round),

					(_, _) => (orderedqueryable ?? queryable).Order<Survey>(order)
				};

			return orderedqueryable ?? queryable;
		}
	}
}
