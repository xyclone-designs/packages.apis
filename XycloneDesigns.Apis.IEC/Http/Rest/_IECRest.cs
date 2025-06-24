using System.Collections.Generic;
using System.Linq;

using Table = XycloneDesigns.Apis.IEC.Tables._Table;

namespace XycloneDesigns.Apis.IEC.Http.Rest
{
	public partial class IECRest 
	{
		public class OrderKeys
		{
			public const string Pk = "pk";

			public static IOrderedQueryable<TTable> Order<TTable>(IQueryable<TTable> queryable, string orderkey, bool reverse) where TTable : Table
			{
				return (orderkey, reverse) switch
				{
					(_, true) => queryable.OrderBy(_ => _.Pk),
					(_, false) => queryable.OrderByDescending(_ => _.Pk)
				};
			}
			public static IQueryable<TTable> Order<TTable>(IQueryable<TTable> queryable, bool reverse, params string[] orderkeys) where TTable : Table
			{
				IOrderedQueryable<TTable>? ordered = null;

				foreach (string orderkey in orderkeys)
					ordered = Order(ordered ?? queryable, orderkey, reverse);

				return ordered ?? queryable;
			}
			public static IEnumerable<string> AsEnumerable()
			{
				return Enumerable.Empty<string>()
					.Append(Pk);
			}
		}
	}
}
