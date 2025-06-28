using System.Collections.Generic;

using XycloneDesigns.Apis.General.Http.Rest;

namespace XycloneDesigns.Apis.Afrobarometer.Http.Rest
{
	public partial class AfrobarometerRest
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
