using System.Linq;
using System.Collections.Generic;
using XycloneDesigns.Apis.SAPS.Tables;

namespace XycloneDesigns.Apis.SAPS.Http.Rest
{
	public partial class Categories 
	{
		public class Response : SAPSRest.Response
		{
			public Response() { }
			public Response(Request request, IQueryable<Category> queryable)
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

			public IQueryable<Category> Filter(Request request, IQueryable<Category> queryable)
			{
				queryable = base.Filter(request, queryable);

				if (request.Name?.Select(_ => _.ToLower()) is IEnumerable<string> requestName)
				{
					if (requestName.Where(_ => _.StartsWith('-')) is IEnumerable<string> excludes && excludes.Any() && excludes.Any(_ => _ == "-null") is bool excludesnull)
						queryable = excludesnull
							? queryable.Where(_ => _.Name != null && excludes.All(__ => __ != '-' + _.Name.ToLower()))
							: queryable.Where(_ => _.Name == null || excludes.All(__ => __ != '-' + _.Name.ToLower()));

					if (requestName.Where(_ => !_.StartsWith('-')) is IEnumerable<string> includes && includes.Any() && includes.Any(_ => _ == "null") is bool includesnull)
						queryable = includesnull
							? queryable.Where(_ => _.Name == null || includes.Any(__ => __ == _.Name.ToLower()))
							: queryable.Where(_ => _.Name != null && includes.Any(__ => __ == _.Name.ToLower()));
				}

				return queryable;
			}
		}
	}
}
