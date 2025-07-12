using System.Linq;

using XycloneDesigns.Apis.SAPS.Tables;

namespace XycloneDesigns.Apis.SAPS.Http.Rest
{
	public partial class PoliceStations 
	{
		public class Response : SAPSRest.Response<PoliceStation>
		{
			public Response() { }
			public Response(Request request, IQueryable<PoliceStation> queryable)
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

			public IQueryable<PoliceStation> Filter(Request request, IQueryable<PoliceStation> queryable)
			{
				queryable = base.Filter(request, queryable);

				if (request.PkDistrict is not null)
				{
					if (request.PkDistrict.Any(__ => __ > 0)) queryable = queryable.Where(_ => request.PkDistrict.Any(__ => __ == _.Pk));
					if (request.PkDistrict.Any(__ => __ < 0)) queryable = queryable.Where(_ => request.PkDistrict.All(__ => __ != -_.Pk));
					if (request.PkDistrict.Contains(0)) queryable = queryable.Concat(queryable.Where(_ => !_.PkDistrict.HasValue));
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
