using System;
using System.Collections.Generic;
using System.Linq;

namespace XycloneDesigns.Apis.ETenders.Http
{
	public static partial class OCDSReleases
	{
		public abstract class Request : ETenders.Request 
		{
			public class Parameters
			{
				public const string DateFrom = "dateFrom";
				public const string DateTo = "dateTo";
				public const string PageNumber = "pageNumber";
				public const string PageSize = "pageSize";

				public static IEnumerable<string> AsEnumerable()
				{
					return Enumerable.Empty<string>()
						.Append(DateFrom)
						.Append(DateTo)
						.Append(PageNumber)
						.Append(PageSize);
				}
			}

			public DateTime? DateFrom { get; set; }
			public DateTime? DateTo { get; set; }
			public int? PageNumber { get; set; }
			public int? PageSize { get; set; }
		}
	}
}
