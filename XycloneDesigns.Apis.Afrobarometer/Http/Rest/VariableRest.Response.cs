using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Rest;
using XycloneDesigns.Apis.Afrobarometer.Tables;

namespace XycloneDesigns.Apis.Afrobarometer.Http.Rest
{
	public partial class VariablesRest
	{
		public class Response : Variables.Response
		{
			public Response() { }
			public Response(Request request, IEnumerable<Variable> items) 
			{
				IEnumerable<Variable> enumerable = GeneralRest.Filter(items, (item, filter) => filter.Filter(item), request.Filter);

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
