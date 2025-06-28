using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.IEC.Tables;

namespace XycloneDesigns.Apis.IEC.Http.Rest
{
	public partial class Parties 
	{
		public class OrderKeys : IECRest.OrderKeys
		{
			public const string Abbr = "abbr";
			public const string DateEstablished = "dateEstablished";
			public const string DateDisestablished = "dateDisestablished";
			public const string Name = "name";

			public static IOrderedQueryable<Party> Order(IQueryable<Party> queryable, string orderkey, bool reverse)
			{
				return (orderkey, reverse) switch
				{
					(Abbr, false) => queryable.OrderBy(_ => _.Abbr),
					(Abbr, true) => queryable.OrderByDescending(_ => _.Abbr),

					(DateEstablished, false) => queryable.OrderByDescending(_ => _.DateEstablished),
					(DateEstablished, true) => queryable.OrderBy(_ => _.DateEstablished),

					(DateDisestablished, false) => queryable.OrderByDescending(_ => _.DateDisestablished),
					(DateDisestablished, true) => queryable.OrderBy(_ => _.DateDisestablished),

					(Name, false) => queryable.OrderBy(_ => _.Name),
					(Name, true) => queryable.OrderByDescending(_ => _.Name),

					(_, _) => IECRest.OrderKeys.Order(queryable, orderkey, reverse)
				};
			}
			public static IQueryable<Party> Order(IQueryable<Party> queryable, bool reverse, params string[] orderkeys)
			{
				IOrderedQueryable<Party>? ordered = null;

				foreach (string orderkey in orderkeys)
					ordered = Order(ordered ?? queryable, orderkey, reverse);

				return ordered ?? queryable;
			}

			public new static IEnumerable<string> AsEnumerable()
			{
				return IECRest.OrderKeys.AsEnumerable()
					.Append(Abbr)
					.Append(DateEstablished)
					.Append(DateDisestablished)
					.Append(Name);
			}
		}
	}
}
