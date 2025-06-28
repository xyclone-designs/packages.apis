using System;
using System.Linq;
using System.Collections.Generic;

using XycloneDesigns.Apis.Afrobarometer.Tables;

namespace XycloneDesigns.Apis.Afrobarometer.Http.Rest
{
	public partial class Questions 
	{
		public class Response : AfrobarometerRest.Response
		{
			public Response() { }
			public Response(Request request, IQueryable<Question> queryable)
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

			public IQueryable<Question> Filter(Request request, IQueryable<Question> queryable)
			{
				queryable = base.Filter(request, queryable);

				if (request.PkLanguage is not null)
				{
					if (request.PkLanguage.Any(__ => __ > 0)) queryable = queryable.Where(_ => request.PkLanguage.Any(__ => __ == _.PkLanguage));
					if (request.PkLanguage.Any(__ => __ < 0)) queryable = queryable.Where(_ => request.PkLanguage.All(__ => __ != -_.PkLanguage));
					if (request.PkLanguage.Contains(0)) queryable = queryable.Concat(queryable.Where(_ => !_.PkLanguage.HasValue));
				}
				
				if (request.PkSurvey is not null)
				{
					if (request.PkSurvey.Any(__ => __ > 0)) 
						queryable = queryable.Where(_ => request.PkSurvey.Any(__ => _.List_PkSurvey != null && _.List_PkSurvey.Split(',', StringSplitOptions.None).Contains(__.ToString())));
					if (request.PkSurvey.Any(__ => __ < 0)) 
						queryable = queryable.Where(_ => request.PkSurvey.All(__ => _.List_PkSurvey != null && !_.List_PkSurvey.Split(',', StringSplitOptions.None).Contains(__.ToString())));
				}

				if (request.PkVariable is not null)
				{
					if (request.PkVariable.Any(__ => __ > 0)) queryable = queryable.Where(_ => request.PkVariable.Any(__ => __ == _.PkVariable));
					if (request.PkVariable.Any(__ => __ < 0)) queryable = queryable.Where(_ => request.PkVariable.All(__ => __ != -_.PkVariable));
					if (request.PkVariable.Contains(0)) queryable = queryable.Concat(queryable.Where(_ => !_.PkVariable.HasValue));
				}

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
