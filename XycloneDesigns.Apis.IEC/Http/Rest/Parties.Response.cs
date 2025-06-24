using System.Linq;
using System.Collections.Generic;
using XycloneDesigns.Apis.IEC.Tables;

namespace XycloneDesigns.Apis.IEC.Http.Rest
{
	public partial class Parties 
	{
		public class Response : IECRest.Response
		{
			public Response() { }
			public Response(Request request, IQueryable<Party> queryable)
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

			public IQueryable<Party> Filter(Request request, IQueryable<Party> queryable)
			{
				queryable = base.Filter(request, queryable);

				if (request.Abbr?.Select(_ => _.ToLower()) is IEnumerable<string> requestabbr)
				{
					if (requestabbr.Where(_ => _.StartsWith('-')) is IEnumerable<string> excludes && excludes.Any() && excludes.Any(_ => _ == "-null") is bool excludesnull)
						queryable = excludesnull
							? queryable.Where(_ => _.Abbr != null && excludes.All(__ => __ != '-' + _.Abbr.ToLower()))
							: queryable.Where(_ => _.Abbr == null || excludes.All(__ => __ != '-' + _.Abbr.ToLower()));

					if (requestabbr.Where(_ => !_.StartsWith('-')) is IEnumerable<string> includes && includes.Any() && includes.Any(_ => _ == "null") is bool includesnull)
						queryable = includesnull
							? queryable.Where(_ => _.Abbr == null || includes.Any(__ => __ == _.Abbr.ToLower()))
							: queryable.Where(_ => _.Abbr != null && includes.Any(__ => __ == _.Abbr.ToLower()));
				}

				return queryable;
			}
		}
	}
}
