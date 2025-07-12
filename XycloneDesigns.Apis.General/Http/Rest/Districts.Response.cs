using System.Linq;
using System.Collections.Generic;

using XycloneDesigns.Apis.General.Tables;

namespace XycloneDesigns.Apis.General.Http.Rest
{
	public partial class Districts 
	{
		public class Response : GeneralRest.Response<District>
		{
			public Response() { }
			public Response(Request request, IQueryable<District> queryable)
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

			public IQueryable<District> Filter(Request request, IQueryable<District> queryable)
			{
				queryable = base.Filter(request, queryable);

				if (request.Code?.Select(_ => _.ToLower()) is IEnumerable<string> requesttype)
				{
					if (requesttype.Where(_ => _.StartsWith('-')) is IEnumerable<string> excludes && excludes.Any() && excludes.Any(_ => _ == "-null") is bool excludesnull)
						queryable = excludesnull
							? queryable.Where(_ => _.Code != null && excludes.All(__ => __ != '-' + _.Code.ToLower()))
							: queryable.Where(_ => _.Code == null || excludes.All(__ => __ != '-' + _.Code.ToLower()));

					if (requesttype.Where(_ => !_.StartsWith('-')) is IEnumerable<string> includes && includes.Any() && includes.Any(_ => _ == "null") is bool includesnull)
						queryable = includesnull
							? queryable.Where(_ => _.Code == null || includes.Any(__ => __ == _.Code.ToLower()))
							: queryable.Where(_ => _.Code != null && includes.Any(__ => __ == _.Code.ToLower()));
				}

				return queryable;
			}
		}
	}
}
