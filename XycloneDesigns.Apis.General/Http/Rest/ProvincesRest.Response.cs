using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Tables;

namespace XycloneDesigns.Apis.General.Http.Rest
{
	public partial class ProvincesRest
	{
		public class Response : Provinces.Response
		{
			public Response() { }
			public Response(Request request, IEnumerable<Province> items) 
			{
				IEnumerable<Province> enumerable = GeneralRest.Filter(items, (item, filter) => filter.Filter(item), request.Filter);

				request.PaginationValues(Count = enumerable.Count(), out int outpage, out int outpages, out int outskipcount, out int outpagesize);

				Page = outpage;
				Pages = outpages;
				Items = enumerable
					.Order([.. request.Order])
					.Skip(outskipcount)
					.Take(outpagesize);
			}
		}
	}
}
