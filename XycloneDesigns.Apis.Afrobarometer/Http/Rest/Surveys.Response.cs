using System;
using System.Linq;
using System.Collections.Generic;

using XycloneDesigns.Apis.Afrobarometer.Tables;
using XycloneDesigns.Apis.Afrobarometer.Enums;

namespace XycloneDesigns.Apis.Afrobarometer.Http.Rest
{
	public partial class Surveys 
	{
		public class Response : AfrobarometerRest.Response<Survey>
		{
			public Response() { }
			public Response(Request request, IQueryable<Survey> queryable)
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

			public IQueryable<Survey> Filter(Request request, IQueryable<Survey> queryable)
			{
				queryable = base.Filter(request, queryable);

				if (request.PkCountry is not null)
				{
					if (request.PkCountry.Any(__ => __ > 0)) queryable = queryable.Where(_ => request.PkCountry.Any(__ => __ == _.PkCountry));
					if (request.PkCountry.Any(__ => __ < 0)) queryable = queryable.Where(_ => request.PkCountry.All(__ => __ != -_.PkCountry));
					if (request.PkCountry.Contains(0)) queryable = queryable.Concat(queryable.Where(_ => !_.PkCountry.HasValue));
				}

				if (request.PkLanguage is not null)
				{
					if (request.PkLanguage.Any(__ => __ > 0)) queryable = queryable.Where(_ => request.PkLanguage.Any(__ => __ == _.PkLanguage));
					if (request.PkLanguage.Any(__ => __ < 0)) queryable = queryable.Where(_ => request.PkLanguage.All(__ => __ != -_.PkLanguage));
					if (request.PkLanguage.Contains(0)) queryable = queryable.Concat(queryable.Where(_ => !_.PkLanguage.HasValue));
				}

				if (request.PkQuestion is not null)
				{
					if (request.PkQuestion.Any(__ => __ > 0))
						queryable = queryable.Where(_ => request.PkQuestion.Any(__ => _.List_PkQuestion != null && _.List_PkQuestion.Split(',', StringSplitOptions.None).Contains(__.ToString())));
					if (request.PkQuestion.Any(__ => __ < 0))
						queryable = queryable.Where(_ => request.PkQuestion.All(__ => _.List_PkQuestion != null && !_.List_PkQuestion.Split(',', StringSplitOptions.None).Contains(__.ToString())));
				}

				if (request.PkVariable is not null)
				{
					if (request.PkVariable.Any(__ => __ > 0))
						queryable = queryable.Where(_ => request.PkVariable.Any(__ => _.List_PkVariable != null && _.List_PkVariable.Split(',', StringSplitOptions.None).Contains(__.ToString())));
					if (request.PkVariable.Any(__ => __ < 0))
						queryable = queryable.Where(_ => request.PkVariable.All(__ => _.List_PkVariable != null && !_.List_PkVariable.Split(',', StringSplitOptions.None).Contains(__.ToString())));
				}

				if (request.Round?.Where(_ => _.StartsWith('-')).Select(_ => Enum.TryParse(_, out Rounds round) ? round : new Rounds?()).OfType<Rounds>() is IEnumerable<Rounds> roundsexcludes)
				{
					queryable = request.Round.Any(_ => _ == "-null")
						? queryable.Where(_ => _.Round != null && !roundsexcludes.Contains(_.Round.Value))
						: queryable.Where(_ => _.Round == null || !roundsexcludes.Contains(_.Round.Value));
				}

				if (request.Round?.Where(_ => !_.StartsWith('-')).Select(_ => Enum.TryParse(_, out Rounds round) ? round : new Rounds?()).OfType<Rounds>() is IEnumerable<Rounds> roundsincludes)
				{
					queryable = request.Round.Any(_ => _ == "null")
						? queryable.Where(_ => _.Round == null || roundsincludes.Contains(_.Round.Value))
						: queryable.Where(_ => _.Round != null && roundsincludes.Contains(_.Round.Value));
				}

				return queryable;
			}
		}
	}
}
