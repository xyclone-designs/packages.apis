using System;
using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.Afrobarometer.Tables;

namespace XycloneDesigns.Apis.Afrobarometer.Http.Rest
{
	public partial class Interviews 
	{
		public class OrderKeys 
		{
			public const string Round = "round";
			public const string VariableCount = "variableCount";

			public static IOrderedQueryable<Interview> Order(IQueryable<Interview> queryable, string orderkey, bool reverse)
			{
				return (orderkey, reverse) switch
				{
					(Round, false) => queryable.OrderByDescending(_ => _.Round),
					(Round, true) => queryable.OrderBy(_ => _.Round),

					(VariableCount, false) => queryable.OrderBy(_ => _.List_PkVariable_Record == null ? 0 : _.List_PkVariable_Record.Split(',', StringSplitOptions.None).Count()),
					(VariableCount, true) => queryable.OrderByDescending(_ => _.List_PkVariable_Record == null ? 0 : _.List_PkVariable_Record.Split(',', StringSplitOptions.None).Count()),

					(_, _) => AfrobarometerRest.OrderKeys.Order(queryable, orderkey, reverse)
				};
			}
			public static IQueryable<Interview> Order(IQueryable<Interview> queryable, bool reverse, params string[] orderkeys)
			{
				IOrderedQueryable<Interview>? ordered = null;

				foreach (string orderkey in orderkeys)
					ordered = Order(ordered ?? queryable, orderkey, reverse);

				return ordered ?? queryable;
			}

			public static IEnumerable<string> AsEnumerable()
			{
				return AfrobarometerRest.OrderKeys.AsEnumerable()
					.Append(Round)
					.Append(VariableCount);
			}
		}
	}
}
