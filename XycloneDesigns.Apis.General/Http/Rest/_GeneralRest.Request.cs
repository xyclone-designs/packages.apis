using System.Collections.Generic;
using System.Linq;

namespace XycloneDesigns.Apis.General.Http.Rest
{
	public partial class GeneralRest
	{
		public class Request : ApiRequest 
		{
			public class Parameters
			{
				public const string Page = "Page";
				public const string PageSize = "PageSize";
				public const string OrderBy = "OrderBy";
				public const string Reverse = "Reverse";
				public const string Pk = "Pk";

				public static IEnumerable<string> AsEnumerable()
				{
					return Enumerable.Empty<string>()
						.Append(Page)
						.Append(PageSize)
						.Append(OrderBy)
						.Append(Reverse)
						.Append(Pk);
				}
			}

			public int Page { get; set; } = 1;
			public int PageSize { get; set; } = 10;
			public string[] OrderBy { get; set; } = [];
			public int[] Pk { get; set; } = [];
			public bool Reverse { get; set; } = false;

			public void PaginationValues(int itemscount, out int page, out int pages, out int skipcount, out int pagesize)
			{
				page = Page < 1 ? 1 : Page;
				pages = (int)decimal.Ceiling(itemscount / PageSize) + 1;
				pagesize = PageSize < 1 ? 10 : PageSize;
				skipcount = Page == 1 ? 0 : (Page - 1) * PageSize;

				if (pages == 0) pages = 1;
			}
		}
		public class Request<T> : ApiRequest<T>
		{
			public Request(T @default) : base(@default)
			{
				Page = @default;
				PageSize = @default;
				OrderBy = @default;
                Pk = @default;
                Reverse = @default;
			}

			public T Page { get; set; } 
			public T PageSize { get; set; }
			public T OrderBy { get; set; } 
			public T Pk { get; set; } 
			public T Reverse { get; set; } 
		}
    }
}
