using System.Collections.Generic;
using System.Linq;

namespace XycloneDesigns.Apis.General.Http.Rest
{
	public partial class GeneralRest
	{
		public class Response : ApiResponse 
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
		public class Response<T> : Response
		{
			public class TypeObject
			{
				public object Page = new { Type = "integer" };
				public object Pages = new { Type = "integer" };
				public object Count = new { Type = "integer" };
				public object? Items { get; set; }
			}

			public int Count { get; set; } = 1;
			public int Page { get; set; } = 1;
			public int Pages { get; set; } = 1;
			public IEnumerable<T> Items { get; set; } = Enumerable.Empty<T>();
		}        
    }
}
