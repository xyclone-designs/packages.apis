using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Tables;

namespace XycloneDesigns.Apis.General.Http.Rest
{
	public partial class Languages 
	{
		public static class OrderKeys 
		{
			public const string Code = "code";

			public static IOrderedQueryable<Language> Order(IQueryable<Language> queryable, string orderkey, bool reverse)
			{
				return (orderkey, reverse) switch
				{
					(Code, true) => queryable.OrderByDescending(_ => _.Code),
					(Code, false) => queryable.OrderBy(_ => _.Code),

					(_, _) => GeneralRest.OrderKeys.Order(queryable, orderkey, reverse)
				};
			}
			public static IQueryable<Language> Order(IQueryable<Language> queryable, bool reverse, params string[] orderkeys)
			{
				IOrderedQueryable<Language>? ordered = null;

				foreach (string orderkey in orderkeys)
					ordered = Order(ordered ?? queryable, orderkey, reverse);

				return ordered ?? queryable;
			}

			public static IEnumerable<string> AsEnumerable()
			{
				return GeneralRest.OrderKeys.AsEnumerable()
					.Append(Code);
			}
		}
	}
}
