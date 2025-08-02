using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Models;
using XycloneDesigns.Apis.General.Tables;

namespace XycloneDesigns.Apis.General.Http
{
	public static partial class Base
	{
		public class Filters
		{
			public const string Pk = "pk";

			public static IEnumerable<string> AsEnumerable()
			{
				return Enumerable.Empty<string>()
					.Append(Pk);
			}
		}

		public static bool Filter<TTable>(this Filter filter, TTable ttable) where TTable : _Table
		{
			return filter.Key switch
			{
				Filters.Pk or _ => filter.Passes(ttable.Pk),
			};
		}
	}
}
