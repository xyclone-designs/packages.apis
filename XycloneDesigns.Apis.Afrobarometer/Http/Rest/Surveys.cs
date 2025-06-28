using System;
using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.Afrobarometer.Tables;

namespace XycloneDesigns.Apis.Afrobarometer.Http.Rest
{
	public partial class Surveys 
	{
		public static class OrderKeys 
		{
			public const string InterviewCount = "interviewCount";
			public const string QuestionCount = "questionCount";
			public const string VariableCount = "variableCount";
			public const string Round = "round";

			public static IOrderedQueryable<Survey> Order(IQueryable<Survey> queryable, string orderkey, bool reverse)
			{
				return (orderkey, reverse) switch
				{
					(InterviewCount, false) => queryable.OrderBy(_ => _.InterviewCount),
					(InterviewCount, true) => queryable.OrderByDescending(_ => _.InterviewCount),

					(QuestionCount, false) => queryable.OrderBy(_ => _.List_PkQuestion == null ? 0 : _.List_PkQuestion.Split(',', StringSplitOptions.None).Count()),
					(QuestionCount, true) => queryable.OrderByDescending(_ => _.List_PkQuestion == null ? 0 : _.List_PkQuestion.Split(',', StringSplitOptions.None).Count()),

					(VariableCount, false) => queryable.OrderBy(_ => _.List_PkVariable == null ? 0 : _.List_PkVariable.Split(',', StringSplitOptions.None).Count()),
					(VariableCount, true) => queryable.OrderByDescending(_ => _.List_PkVariable == null ? 0 : _.List_PkVariable.Split(',', StringSplitOptions.None).Count()),

					(Round, false) => queryable.OrderBy(_ => _.Round),
					(Round, true) => queryable.OrderByDescending(_ => _.Round),

					(_, _) => AfrobarometerRest.OrderKeys.Order(queryable, orderkey, reverse)
				};
			}
			public static IQueryable<Survey> Order(IQueryable<Survey> queryable, bool reverse, params string[] orderkeys)
			{
				IOrderedQueryable<Survey>? ordered = null;

				foreach (string orderkey in orderkeys)
					ordered = Order(ordered ?? queryable, orderkey, reverse);

				return ordered ?? queryable;
			}

			public static IEnumerable<string> AsEnumerable()
			{
				return Surveys.OrderKeys.AsEnumerable()
					.Append(InterviewCount)
					.Append(QuestionCount)
					.Append(VariableCount)
					.Append(Round);
			}
		}
	}
}
