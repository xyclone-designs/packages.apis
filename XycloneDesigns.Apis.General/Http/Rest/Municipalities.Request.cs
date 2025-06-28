using System.Linq;
using System.Collections.Generic;

namespace XycloneDesigns.Apis.General.Http.Rest
{
	public partial class Municipalities 
	{
		public class Request : GeneralRest.Request
		{
			public new class Parameters : GeneralRest.Request.Parameters
			{
				public const string GeoCode = "geoCode";

				public new static IEnumerable<string> AsEnumerable()
				{
					return GeneralRest.Request.Parameters.AsEnumerable()
						.Append(GeoCode);
				}
			}

			public string[]? GeoCode { get; set; }
		}
	}
}
