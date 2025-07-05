using System.Collections.Generic;

using XycloneDesigns.Apis.General.Http.Rest;

namespace XycloneDesigns.Apis.SAPS.Http.Rest
{
	public partial class SAPSRest
	{
		public class Request : GeneralRest.Request
		{
			public new class Parameters : GeneralRest.Request.Parameters
			{
				public new static IEnumerable<string> AsEnumerable()
				{
					return GeneralRest.Request.Parameters.AsEnumerable();
				}
			}
		}
	}
}
