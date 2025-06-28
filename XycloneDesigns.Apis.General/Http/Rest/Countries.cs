using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Tables;

namespace XycloneDesigns.Apis.General.Http.Rest
{
	public partial class Countries 
	{
		public class OrderKeys 
		{
			public const string Id = "id";
			public const string Population = "population";
			public const string SquareKms = "squareKms";

			public static IOrderedQueryable<Country> Order(IQueryable<Country> queryable, string orderkey, bool reverse)
			{
				return (orderkey, reverse) switch
				{
					(Id, false) => queryable.OrderBy(_ => _.Code),
					(Id, true) => queryable.OrderByDescending(_ => _.Code),

					(Population, false) => queryable.OrderByDescending(_ => _.Population),
					(Population, true) => queryable.OrderBy(_ => _.Population),

					(SquareKms, false) => queryable.OrderByDescending(_ => _.SquareKms),
					(SquareKms, true) => queryable.OrderBy(_ => _.SquareKms),

					(_, _) => GeneralRest.OrderKeys.Order(queryable, orderkey, reverse)
				};
			}
			public static IQueryable<Country> Order(IQueryable<Country> queryable, bool reverse, params string[] orderkeys)
			{
				IOrderedQueryable<Country>? ordered = null;

				foreach (string orderkey in orderkeys)
					ordered = Order(ordered ?? queryable, orderkey, reverse);

				return ordered ?? queryable;
			}

			public static IEnumerable<string> AsEnumerable()
			{
				return GeneralRest.OrderKeys.AsEnumerable()
					.Append(Id)
					.Append(Population)
					.Append(SquareKms);
			}
		}
	}
}
