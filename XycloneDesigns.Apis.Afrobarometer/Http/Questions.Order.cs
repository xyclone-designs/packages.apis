using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Models;
using XycloneDesigns.Apis.General.Http;
using XycloneDesigns.Apis.Afrobarometer.Tables;

namespace XycloneDesigns.Apis.Afrobarometer.Http
{
	public static partial class Questions
	{
		public class Orders : Base.Orders
		{
			public const string Id = Question.SQL.Column_Id;
			public const string List_PkSurvey = Question.SQL.Column_List_PkSurvey;
			public const string Note = Question.SQL.Column_Note;
			public const string PkLanguage = Question.SQL.Column_PkLanguage;
			public const string PkVariable = Question.SQL.Column_PkVariable;
			public const string Source = Question.SQL.Column_Source;
			public const string Text = Question.SQL.Column_Text;
			public const string VariableLabel = Question.SQL.Column_VariableLabel;

			public new static IEnumerable<string> AsEnumerable()
			{
				return Base.Orders.AsEnumerable()
					.Append(Id)
					.Append(List_PkSurvey)
					.Append(Note)
					.Append(PkLanguage)
					.Append(PkVariable)
					.Append(Source)
					.Append(Text)
					.Append(VariableLabel);
			}
		}

		public static IOrderedEnumerable<Question> Order(this IEnumerable<Question> queryable, params Order[] orders)
		{
			IOrderedEnumerable<Question>? orderedqueryable = null;

			foreach (Order order in orders)
				orderedqueryable = orderedqueryable is not null
					? orderedqueryable.Order(order)
					: (order.Key, order.Descending) switch
					{
						(Orders.Id, false) => queryable.OrderBy(_ => _.Id),
						(Orders.Id, true) => queryable.OrderByDescending(_ => _.Id),

						(Orders.List_PkSurvey, false) => queryable.OrderBy(_ => _.List_PkSurvey),
						(Orders.List_PkSurvey, true) => queryable.OrderByDescending(_ => _.List_PkSurvey),

						(Orders.Note, false) => queryable.OrderBy(_ => _.Note),
						(Orders.Note, true) => queryable.OrderByDescending(_ => _.Note),

						(Orders.PkLanguage, false) => queryable.OrderBy(_ => _.PkLanguage),
						(Orders.PkLanguage, true) => queryable.OrderByDescending(_ => _.PkLanguage),
						
						(Orders.PkVariable, false) => queryable.OrderBy(_ => _.PkVariable),
						(Orders.PkVariable, true) => queryable.OrderByDescending(_ => _.PkVariable),

						(Orders.Source, false) => queryable.OrderBy(_ => _.Source),
						(Orders.Source, true) => queryable.OrderByDescending(_ => _.Source),

						(Orders.Text, false) => queryable.OrderBy(_ => _.Text),
						(Orders.Text, true) => queryable.OrderByDescending(_ => _.Text),

						(Orders.VariableLabel, false) => queryable.OrderBy(_ => _.VariableLabel),
						(Orders.VariableLabel, true) => queryable.OrderByDescending(_ => _.VariableLabel),

						(_, _) => queryable.Order<Question>(order)
					};

			return orderedqueryable ?? queryable.Order<Question>(orders);
		}
		public static IOrderedEnumerable<Question> Order(this IOrderedEnumerable<Question> queryable, params Order[] orders)
		{
			IOrderedEnumerable<Question>? orderedqueryable = null;

			foreach (Order order in orders)
				orderedqueryable = (order.Key, order.Descending) switch
				{
					(Orders.Id, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.Id),
					(Orders.Id, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.Id),

					(Orders.List_PkSurvey, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.List_PkSurvey),
					(Orders.List_PkSurvey, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.List_PkSurvey),
						
					(Orders.Note, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.Note),
					(Orders.Note, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.Note),

					(Orders.PkLanguage, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.PkLanguage),
					(Orders.PkLanguage, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.PkLanguage),
						
					(Orders.PkVariable, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.PkVariable),
					(Orders.PkVariable, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.PkVariable),

					(Orders.Source, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.Source),
					(Orders.Source, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.Source),
						
					(Orders.Text, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.Text),
					(Orders.Text, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.Text),

					(Orders.VariableLabel, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.VariableLabel),
					(Orders.VariableLabel, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.VariableLabel),

					(_, _) => (orderedqueryable ?? queryable).Order<Question>(order)
				};

			return orderedqueryable ?? queryable;
		}
	}
}
