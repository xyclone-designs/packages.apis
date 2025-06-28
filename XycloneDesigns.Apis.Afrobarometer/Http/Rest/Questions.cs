using System;
using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.Afrobarometer.Tables;

namespace XycloneDesigns.Apis.Afrobarometer.Http.Rest
{
	public partial class Questions 
	{
		public static class OrderKeys 
		{
			public const string Id = "id";
			public const string SurveyCount = "surveyCount";
			public const string VariableLabel = "variableLabel";

			public static IOrderedQueryable<Question> Order(IQueryable<Question> queryable, string orderkey, bool reverse)
			{
				return (orderkey, reverse) switch
				{
					(Id, false) => queryable.OrderByDescending(_ => _.Id),
					(Id, true) => queryable.OrderBy(_ => _.Id),

					(SurveyCount, false) => queryable.OrderBy(_ => _.List_PkSurvey == null ? 0 : _.List_PkSurvey.Split(',', StringSplitOptions.None).Count()),
					(SurveyCount, true) => queryable.OrderByDescending(_ => _.List_PkSurvey== null ? 0 : _.List_PkSurvey.Split(',', StringSplitOptions.None).Count()),

					(VariableLabel, false) => queryable.OrderBy(_ => _.VariableLabel),
					(VariableLabel, true) => queryable.OrderByDescending(_ => _.VariableLabel),

					(_, _) => AfrobarometerRest.OrderKeys.Order(queryable, orderkey, reverse)
				};
			}
			public static IQueryable<Question> Order(IQueryable<Question> queryable, bool reverse, params string[] orderkeys)
			{
				IOrderedQueryable<Question>? ordered = null;

				foreach (string orderkey in orderkeys)
					ordered = Order(ordered ?? queryable, orderkey, reverse);

				return ordered ?? queryable;
			}

			public static IEnumerable<string> AsEnumerable()
			{
				return AfrobarometerRest.OrderKeys.AsEnumerable()
					.Append(Id)
					.Append(SurveyCount)
					.Append(VariableLabel);
			}
		}
	}
}
