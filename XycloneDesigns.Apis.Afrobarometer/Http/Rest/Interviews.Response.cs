using System.Linq;
using System.Collections.Generic;

using XycloneDesigns.Apis.Afrobarometer.Enums;
using XycloneDesigns.Apis.Afrobarometer.Tables;
using System;

namespace XycloneDesigns.Apis.Afrobarometer.Http.Rest
{
	public partial class Interviews 
	{
		public class Response : AfrobarometerRest.Response<Interview>
		{
			public Response() { }
			public Response(Request request, IQueryable<Interview> queryable)
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

			public IQueryable<Interview> Filter(Request request, IQueryable<Interview> queryable)
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
					if (request.PkSurvey.Any(__ => __ > 0)) queryable = queryable.Where(_ => request.PkSurvey.Any(__ => __ == _.PkSurvey));
					if (request.PkSurvey.Any(__ => __ < 0)) queryable = queryable.Where(_ => request.PkSurvey.All(__ => __ != -_.PkSurvey));
					if (request.PkSurvey.Contains(0)) queryable = queryable.Concat(queryable.Where(_ => !_.PkSurvey.HasValue));
				}

				if (request.PkVariable is not null)
				{
					if (request.PkVariable.Any(__ => __ > 0))
						queryable = queryable.Where(_ => request.PkVariable.Any(__ => _.List_PkVariable_Record != null && _.List_PkVariable_Record.Contains(string.Format("{0}:", __))));
					if (request.PkVariable.Any(__ => __ < 0))
						queryable = queryable.Where(_ => request.PkVariable.Any(__ => _.List_PkVariable_Record != null && !_.List_PkVariable_Record.Contains(string.Format("{0}:", __))));
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
