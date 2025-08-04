using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

using XycloneDesigns.Apis.General.Http.Models;

namespace XycloneDesigns.Apis.General.Http
{
	public static partial class GeneralBase
	{
		public abstract class Request
		{
			public class Parameters
			{
				public const string Page = "Page";
				public const string PageSize = "PageSize";
				public const string Filter = "filter";
				public const string Orders = "orders";

				public static IEnumerable<string> AsEnumerable()
				{
					return Enumerable.Empty<string>()
						.Append(Page)
						.Append(PageSize)
						.Append(Filter)
						.Append(Orders);
				}
			}

			public abstract HttpRequestMessage ToHttpRequestMessage(string? pathbase = null, string? path = null);

			public int Page { get; set; } = 1;
			public int PageSize { get; set; } = 10;
			public Filter[] Filter { get; set; } = [];
			public Order[] Order { get; set; } = [];

			public void PaginationValues(int itemscount, out int page, out int pages, out int skipcount, out int pagesize)
			{
				page = Page < 1 ? 1 : Page;
				pages = (int)decimal.Ceiling(itemscount / PageSize) + 1;
				pagesize = PageSize < 1 ? 10 : PageSize;
				skipcount = Page == 1 ? 0 : (Page - 1) * PageSize;

				if (pages == 0) pages = 1;
			}
		}
	}
}
