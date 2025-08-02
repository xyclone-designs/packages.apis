using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Rest;
using XycloneDesigns.Apis.SAPS.Tables;

namespace XycloneDesigns.Apis.SAPS.Http.Rest
{
	public partial class CategoriesRest
	{
		public class Response : Categories.Response
		{
			public Response() { }
			public Response(Request request, IEnumerable<Category> items)
			{
				IEnumerable<Category> enumerable = GeneralRest.Filter(items, (item, filter) => filter.Filter(item), request.Filter);

				request.PaginationValues(Count = enumerable.Count(), out int outpage, out int outpages, out int outskipcount, out int outpagesize);

				Page = outpage;
				Pages = outpages;
				Items = enumerable
					.Order([.. request.Order])
					.Skip(outskipcount)
					.Take(outpagesize);
			}
		}
	}
}
