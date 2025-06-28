using System.Collections.Generic;
using System.Linq;

namespace XycloneDesigns.Apis.General.Http.Rest
{
	public partial class ApiFiles
	{
		public class OrderKeys 
		{
			public const string DateCreated = "dateCreated";
			public const string DateEdited = "dateEdited";
			public const string Name = "name";
			
			public static IOrderedQueryable<ApiFile> Order(IQueryable<ApiFile> queryable, string orderkey, bool reverse)
			{
				return (orderkey, reverse) switch
				{
					(DateCreated, false) => queryable.OrderBy(_ => _.DateCreated),
					(DateCreated, true) => queryable.OrderByDescending(_ => _.DateCreated),

					(DateEdited, false) => queryable.OrderByDescending(_ => _.DateEdited),
					(DateEdited, true) => queryable.OrderBy(_ => _.DateEdited),

					(Name, false) => queryable.OrderByDescending(_ => _.Name),
					(Name, true) => queryable.OrderBy(_ => _.Name),

					(_, _) => queryable.Order()
				};
			}
			public static IQueryable<ApiFile> Order(IQueryable<ApiFile> queryable, bool reverse, params string[] orderkeys)
			{
				IOrderedQueryable<ApiFile>? ordered = null;

				foreach (string orderkey in orderkeys)
					ordered = Order(ordered ?? queryable, orderkey, reverse);

				return ordered ?? queryable;
			}

			public static IEnumerable<string> AsEnumerable()
			{
				return GeneralRest.OrderKeys.AsEnumerable()
					.Append(DateCreated)
					.Append(DateEdited)
					.Append(Name);
			}
		}
	}
}
