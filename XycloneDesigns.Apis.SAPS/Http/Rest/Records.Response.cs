using System.Linq;

using XycloneDesigns.Apis.SAPS.Tables;

namespace XycloneDesigns.Apis.SAPS.Http.Rest
{
	public partial class Records 
	{
		public class Response : SAPSRest.Response
		{
			public Response() { }
			public Response(Request request, IQueryable<Record> queryable)
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

			public IQueryable<Record> Filter(Request request, IQueryable<Record> queryable)
			{
				queryable = base.Filter(request, queryable);

				if (request.PkPoliceStation is not null)
				{
					if (request.PkPoliceStation.Any(__ => __ > 0)) queryable = queryable.Where(_ => request.PkPoliceStation.Any(__ => __ == _.Pk));
					if (request.PkPoliceStation.Any(__ => __ < 0)) queryable = queryable.Where(_ => request.PkPoliceStation.All(__ => __ != -_.Pk));
					if (request.PkPoliceStation.Contains(0)) queryable = queryable.Concat(queryable.Where(_ => !_.PkPoliceStation.HasValue));
				}

				if (request.Year is not null)
				{
					if (request.Year.Any(__ => __ > 0)) queryable = queryable.Where(_ => request.Year.Any(__ => __ == _.Pk));
					if (request.Year.Any(__ => __ < 0)) queryable = queryable.Where(_ => request.Year.All(__ => __ != -_.Pk));
					if (request.Year.Contains(0)) queryable = queryable.Concat(queryable.Where(_ => !_.Year.HasValue));
				}

				return queryable;
			}
		}
	}
}
