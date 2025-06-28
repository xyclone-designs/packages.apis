using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Rest;

using TableAfrobarometer = XycloneDesigns.Apis.Afrobarometer.Tables._Table;

namespace XycloneDesigns.Apis.Afrobarometer.Http.Rest
{
	public partial class AfrobarometerRest 
	{
		public class OrderKeys 
		{
			public static IOrderedQueryable<TTable> Order<TTable>(IQueryable<TTable> queryable, string orderkey, bool reverse) where TTable : TableAfrobarometer
			{
				return GeneralRest.OrderKeys.Order(queryable, orderkey, reverse);
			}
			public static IQueryable<TTable> Order<TTable>(IQueryable<TTable> queryable, bool reverse, params string[] orderkeys) where TTable : TableAfrobarometer
			{
				return GeneralRest.OrderKeys.Order(queryable, reverse, orderkeys);
			}
			public static IEnumerable<string> AsEnumerable()
			{
				return GeneralRest.OrderKeys.AsEnumerable();
			}
		}
	}
}
