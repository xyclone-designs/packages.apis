using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Rest;
using XycloneDesigns.Apis.IEC.Tables;

namespace XycloneDesigns.Apis.IEC.Http.Rest
{
	public partial class BallotsRest
	{
		public class Response : Ballots.Response
		{
			public Response() { }
			public Response(Request request, IEnumerable<Ballot> items)
			{
				IEnumerable<Ballot> enumerable = GeneralRest.Filter(items, (item, filter) => filter.Filter(item), request.Filter);

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
