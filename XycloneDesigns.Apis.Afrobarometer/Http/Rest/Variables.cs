using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.Afrobarometer.Tables;

namespace XycloneDesigns.Apis.Afrobarometer.Http.Rest
{
	public partial class Variables 
	{
		public static class OrderKeys 
		{
			public const string Id = "id";

			public static IOrderedQueryable<Variable> Order(IQueryable<Variable> queryable, string orderkey, bool reverse)
			{
				return (orderkey, reverse) switch
				{
					(Id, true) => queryable.OrderByDescending(_ => _.Id),
					(Id, false) => queryable.OrderBy(_ => _.Id),

					(_, _) => AfrobarometerRest.OrderKeys.Order(queryable, orderkey, reverse)
				};
			}
			public static IQueryable<Variable> Order(IQueryable<Variable> queryable, bool reverse, params string[] orderkeys)
			{
				IOrderedQueryable<Variable>? ordered = null;

				foreach (string orderkey in orderkeys)
					ordered = Order(ordered ?? queryable, orderkey, reverse);

				return ordered ?? queryable;
			}

			public static IEnumerable<string> AsEnumerable()
			{
				return AfrobarometerRest.OrderKeys.AsEnumerable()
					.Append(Id);
			}
		}
	}
}
