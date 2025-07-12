using System.Linq;
using System.Collections.Generic;

using XycloneDesigns.Apis.Afrobarometer.Tables;

namespace XycloneDesigns.Apis.Afrobarometer.Http.Rest
{
	public partial class Variables 
	{
		public class Response : AfrobarometerRest.Response<Variable>
		{
			public Response() { }
			public Response(Request request, IQueryable<Variable> queryable)
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

			public IQueryable<Variable> Filter(Request request, IQueryable<Variable> queryable)
			{
				queryable = base.Filter(request, queryable);

				if (request.Id?.Select(_ => _.ToLower()) is IEnumerable<string> requestid)
				{
					if (requestid.Where(_ => _.StartsWith('-')) is IEnumerable<string> excludes && excludes.Any() && excludes.Any(_ => _ == "-null") is bool excludesnull)
						queryable = excludesnull
							? queryable.Where(_ => _.Id != null && excludes.All(__ => __ != '-' + _.Id.ToLower()))
							: queryable.Where(_ => _.Id == null || excludes.All(__ => __ != '-' + _.Id.ToLower()));

					if (requestid.Where(_ => !_.StartsWith('-')) is IEnumerable<string> includes && includes.Any() && includes.Any(_ => _ == "null") is bool includesnull)
						queryable = includesnull
							? queryable.Where(_ => _.Id == null || includes.Any(__ => __ == _.Id.ToLower()))
							: queryable.Where(_ => _.Id != null && includes.Any(__ => __ == _.Id.ToLower()));
				}

				return queryable;
			}
		}
	}
}
