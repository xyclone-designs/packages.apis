using System.Linq;
using System;

namespace XycloneDesigns.Apis.General.Http.Rest
{
	public partial class ApiFiles
	{
		public class Response : GeneralRest.Response<ApiFile>
		{
			public Response() { }
			public Response(Request request, IQueryable<ApiFile> queryable)
			{
				queryable = Filter(request, queryable);

				request.PaginationValues(Count = queryable.Count(), out int outpage, out int outpages, out int outskipcount, out int outpagesize);

				Page = outpage;
				Pages = outpages;
				Items = OrderKeys
					.Order(queryable, request.Reverse, request.OrderBy)
					.Skip(outskipcount)
					.Take(outpagesize);
			}

			public IQueryable<ApiFile> Filter(Request request, IQueryable<ApiFile> queryable)
			{
				return queryable;
			}
		}
	}
}
