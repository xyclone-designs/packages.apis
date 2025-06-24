using System.Collections.Generic;
using System.Linq;

namespace XycloneDesigns.Apis.General.Http.Rest
{
	public partial class GeneralRest
	{
		public class Response : ApiResponse { }
		public class Response<T>
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
