using System.Linq;

using XycloneDesigns.Apis.General.Http.Rest;

namespace XycloneDesigns.Apis.IEC.Http.Rest
{
	public partial class IECRest
	{
		public class Response : GeneralRest.Response<object>
		{
			public virtual IQueryable<T> Filter<T>(Request request, IQueryable<T> queryable) where T : Tables._Table
			{
				if (request.Pk is null || request.Pk.Length == 0)
					return queryable;

				if (request.Pk.Any(__ => __ > 0)) queryable = queryable.Where(_ => request.Pk.Any(__ => __ == _.Pk));
				if (request.Pk.Any(__ => __ < 0)) queryable = queryable.Where(_ => request.Pk.All(__ => __ != -_.Pk));

				return queryable;
			}
		}
	}
}
