using System.Linq;
using System.Collections.Generic;
using XycloneDesigns.Apis.IEC.Tables;

namespace XycloneDesigns.Apis.IEC.Http.Rest
{
	public partial class Wards 
	{
		public class Response : IECRest.Response
		{
			public Response() { }
			public Response(Request request, IQueryable<Ward> queryable)
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

			public IQueryable<Ward> Filter(Request request, IQueryable<Ward> queryable)
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

				return queryable;
			}
		}
	}
}
