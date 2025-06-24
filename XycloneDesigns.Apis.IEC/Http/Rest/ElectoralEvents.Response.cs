using System.Linq;
using System.Collections.Generic;
using XycloneDesigns.Apis.IEC.Tables;

namespace XycloneDesigns.Apis.IEC.Http.Rest
{
	public partial class ElectoralEvents 
	{
		public class Response : IECRest.Response
		{
			public Response() { }
			public Response(Request request, IQueryable<ElectoralEvent> queryable)
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

			public IQueryable<ElectoralEvent> Filter(Request request, IQueryable<ElectoralEvent> queryable)
			{
				queryable = base.Filter(request, queryable);

				return queryable;
			}
		}
	}
}
