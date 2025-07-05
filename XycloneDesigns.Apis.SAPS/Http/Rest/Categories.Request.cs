using System.Linq;
using System.Collections.Generic;

namespace XycloneDesigns.Apis.SAPS.Http.Rest
{
	public partial class Categories 
	{
		public class Request : SAPSRest.Request
		{
			public new class Parameters : SAPSRest.Request.Parameters
			{
				public const string Name = "name";

				public new static IEnumerable<string> AsEnumerable()
				{
					return SAPSRest.Request.Parameters.AsEnumerable()
						.Append(Name);
				}
			}

			public string[]? Name { get; set; }
		}
	}
}
