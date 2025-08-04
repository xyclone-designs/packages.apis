using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Models;

namespace XycloneDesigns.Apis.General.Http
{
	public static partial class ApiFiles
	{
		public class Filters : GeneralBase.Filters
		{
			public const string DateCreated = "dateCreated";
			public const string DateEdited = "dateEdited";
			public const string Name = "name";

			public new static IEnumerable<string> AsEnumerable()
			{
				return GeneralBase.Filters.AsEnumerable()
					.Append(DateCreated)
					.Append(DateEdited)
					.Append(Name);
			}
		}

		public static bool Filter(this Filter filter, ApiFile apifile)
		{
			return filter.Key switch
			{
				Filters.DateCreated => filter.Passes(apifile.DateCreated),
				Filters.DateEdited => filter.Passes(apifile.DateEdited),
				Filters.Name or _ => filter.Passes(apifile.Name),
			};
		}
	}
}
