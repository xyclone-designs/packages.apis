using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Models;
using XycloneDesigns.Apis.General.Tables;

namespace XycloneDesigns.Apis.General.Http
{
	public static partial class GeneralBase
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

		public static bool Filter<TGeneralBase>(this Filter filter, TGeneralBase tgeneralbase) where TGeneralBase : GeneralTable
		{
			return filter.Key switch
			{
				Filters.Pk or _ => filter.Passes(tgeneralbase.Pk),
			};
		}
	}
}
