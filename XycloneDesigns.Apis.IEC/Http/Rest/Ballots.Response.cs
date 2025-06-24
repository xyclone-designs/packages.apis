using System.Linq;
using System.Collections.Generic;
using XycloneDesigns.Apis.IEC.Tables;

namespace XycloneDesigns.Apis.IEC.Http.Rest
{
	public partial class Ballots 
	{
		public class Response : IECRest.Response
		{
			public Response() { }
			public Response(Request request, IQueryable<Ballot> queryable)
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

			public IQueryable<Ballot> Filter(Request request, IQueryable<Ballot> queryable)
			{
				queryable = base.Filter(request, queryable);

				if (request.PkElectoralEvent is not null)
				{
					if (request.PkElectoralEvent.Any(__ => __ > 0)) queryable = queryable.Where(_ => request.PkElectoralEvent.Any(__ => __ == _.Pk));
					if (request.PkElectoralEvent.Any(__ => __ < 0)) queryable = queryable.Where(_ => request.PkElectoralEvent.All(__ => __ != -_.Pk));
					if (request.PkElectoralEvent.Contains(0)) queryable = queryable.Concat(queryable.Where(_ => !_.PkElectoralEvent.HasValue));
				}

				if (request.PkMunicipality is not null)
				{
					if (request.PkMunicipality.Any(__ => __ > 0)) queryable = queryable.Where(_ => request.PkMunicipality.Any(__ => __ == _.Pk));
					if (request.PkMunicipality.Any(__ => __ < 0)) queryable = queryable.Where(_ => request.PkMunicipality.All(__ => __ != -_.Pk));
					if (request.PkMunicipality.Contains(0)) queryable = queryable.Concat(queryable.Where(_ => !_.PkMunicipality.HasValue));
				}

				if (request.PkProvince is not null)
				{
					if (request.PkProvince.Any(__ => __ > 0)) queryable = queryable.Where(_ => request.PkProvince.Any(__ => __ == _.Pk));
					if (request.PkProvince.Any(__ => __ < 0)) queryable = queryable.Where(_ => request.PkProvince.All(__ => __ != -_.Pk));
					if (request.PkProvince.Contains(0)) queryable = queryable.Concat(queryable.Where(_ => !_.PkProvince.HasValue));
				}

				if (request.PkVotingDistrict is not null)
				{
					if (request.PkVotingDistrict.Any(__ => __ > 0)) queryable = queryable.Where(_ => request.PkVotingDistrict.Any(__ => __ == _.Pk));
					if (request.PkVotingDistrict.Any(__ => __ < 0)) queryable = queryable.Where(_ => request.PkVotingDistrict.All(__ => __ != -_.Pk));
					if (request.PkVotingDistrict.Contains(0)) queryable = queryable.Concat(queryable.Where(_ => !_.PkVotingDistrict.HasValue));
				}

				if (request.PkWard is not null)
				{
					if (request.PkWard.Any(__ => __ > 0)) queryable = queryable.Where(_ => request.PkWard.Any(__ => __ == _.Pk));
					if (request.PkWard.Any(__ => __ < 0)) queryable = queryable.Where(_ => request.PkWard.All(__ => __ != -_.Pk));
					if (request.PkWard.Contains(0)) queryable = queryable.Concat(queryable.Where(_ => !_.PkWard.HasValue));
				}

				if (request.Type?.Select(_ => _.ToLower()) is IEnumerable<string> requesttype)
				{
					if (requesttype.Where(_ => _.StartsWith('-')) is IEnumerable<string> excludes && excludes.Any() && excludes.Any(_ => _ == "-null") is bool excludesnull)
						queryable = excludesnull
							? queryable.Where(_ => _.Type != null && excludes.All(__ => __ != '-' + _.Type.ToLower()))
							: queryable.Where(_ => _.Type == null || excludes.All(__ => __ != '-' + _.Type.ToLower()));

					if (requesttype.Where(_ => !_.StartsWith('-')) is IEnumerable<string> includes && includes.Any() && includes.Any(_ => _ == "null") is bool includesnull)
						queryable = includesnull
							? queryable.Where(_ => _.Type == null || includes.Any(__ => __ == _.Type.ToLower()))
							: queryable.Where(_ => _.Type != null && includes.Any(__ => __ == _.Type.ToLower()));
				}

				return queryable;
			}
		}
	}
}
