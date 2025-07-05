using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.SAPS.Tables;

namespace XycloneDesigns.Apis.SAPS.Http.Rest
{
	public partial class Records 
	{
		public class OrderKeys : SAPSRest.OrderKeys
		{
			public const string PoliceStation = "policeStation";
			public const string Year = "year";
			
			public static IOrderedQueryable<Record> Order(IQueryable<Record> queryable, string orderkey, bool reverse)
			{
				return (orderkey, reverse) switch
				{
					(PoliceStation, false) => queryable.OrderBy(_ => _.PkPoliceStation),
					(PoliceStation, true) => queryable.OrderByDescending(_ => _.PkPoliceStation),

					(Year, false) => queryable.OrderBy(_ => _.Year),
					(Year, true) => queryable.OrderByDescending(_ => _.Year),

					(_, _) => SAPSRest.OrderKeys.Order(queryable, orderkey, reverse)
				};
			}
			public static IQueryable<Record> Order(IQueryable<Record> queryable, bool reverse, params string[] orderkeys)
			{
				IOrderedQueryable<Record>? ordered = null;

				foreach (string orderkey in orderkeys)
					ordered = Order(ordered ?? queryable, orderkey, reverse);

				return ordered ?? queryable;
			}

			public new static IEnumerable<string> AsEnumerable()
			{
				return SAPSRest.OrderKeys.AsEnumerable()
					.Append(PoliceStation)
					.Append(Year);
			}
		}
	}
}
