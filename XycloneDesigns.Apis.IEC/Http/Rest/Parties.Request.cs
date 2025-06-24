using System.Linq;
using System.Collections.Generic;

namespace XycloneDesigns.Apis.IEC.Http.Rest
{
	public partial class Parties 
	{
		public class Request : IECRest.Request
		{
			public new class Parameters : IECRest.Request.Parameters
			{
				public new static IEnumerable<string> AsEnumerable()
				{
					return IECRest.Request.Parameters.AsEnumerable()
						.Append(Abbr);
				}
			}

			public string[]? Abbr { get; set; }
		}
	}
}
