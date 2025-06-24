using System.Collections.Generic;

namespace XycloneDesigns.Apis.IEC.Http.Rest
{
	public partial class ElectoralEvents 
	{
		public class Request : IECRest.Request
		{
			public new class Parameters : IECRest.Request.Parameters
			{
				public new static IEnumerable<string> AsEnumerable()
				{
					return IECRest.Request.Parameters.AsEnumerable();
				}
			}
		}
	}
}
