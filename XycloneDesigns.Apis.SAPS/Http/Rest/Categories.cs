using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.SAPS.Tables;

namespace XycloneDesigns.Apis.SAPS.Http.Rest
{
	public partial class Categories 
	{
		public class OrderKeys : SAPSRest.OrderKeys
		{
			public const string Name = "name";

			public static IOrderedQueryable<Category> Order(IQueryable<Category> queryable, string orderkey, bool reverse)
			{
				return (orderkey, reverse) switch
				{
					(Name, false) => queryable.OrderBy(_ => _.Name),
					(Name, true) => queryable.OrderByDescending(_ => _.Name),

					(_, _) => SAPSRest.OrderKeys.Order(queryable, orderkey, reverse)
				};
			}
			public static IQueryable<Category> Order(IQueryable<Category> queryable, bool reverse, params string[] orderkeys)
			{
				IOrderedQueryable<Category>? ordered = null;

				foreach (string orderkey in orderkeys)
					ordered = Order(ordered ?? queryable, orderkey, reverse);

				return ordered ?? queryable;
			}

			public new static IEnumerable<string> AsEnumerable()
			{
				return SAPSRest.OrderKeys.AsEnumerable()
					.Append(Name);
			}
		}
	}
}
