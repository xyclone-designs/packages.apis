using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.IEC.Tables;

namespace XycloneDesigns.Apis.IEC.Http.Rest
{
	public partial class ElectoralEvents 
	{
		public class OrderKeys : IECRest.OrderKeys
		{
			public const string Date = "date";
			public const string Type = "type";

			public static IOrderedQueryable<ElectoralEvent> Order(IQueryable<ElectoralEvent> queryable, string orderkey, bool reverse)
			{
				return (orderkey, reverse) switch
				{
					(Date, false) => queryable.OrderByDescending(_ => _.Date),
					(Date, true) => queryable.OrderBy(_ => _.Date),

					(Type, false) => queryable.OrderBy(_ => _.Type),
					(Type, true) => queryable.OrderByDescending(_ => _.Type),

					(_, _) => IECRest.OrderKeys.Order(queryable, orderkey, reverse)
				};
			}
			public static IQueryable<ElectoralEvent> Order(IQueryable<ElectoralEvent> queryable, bool reverse, params string[] orderkeys)
			{
				IOrderedQueryable<ElectoralEvent>? ordered = null;

				foreach (string orderkey in orderkeys)
					ordered = Order(ordered ?? queryable, orderkey, reverse);

				return ordered ?? queryable;
			}

			public new static IEnumerable<string> AsEnumerable()
			{
				return IECRest.OrderKeys.AsEnumerable()
					.Append(Date)
					.Append(Type);
			}
		}
	}
}
