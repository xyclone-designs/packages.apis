using System.Linq;
using System.Collections.Generic;

namespace XycloneDesigns.Apis.SAPS.Http.Rest
{
	public partial class Records 
	{
		public class Request : SAPSRest.Request
		{
			public new class Parameters : SAPSRest.Request.Parameters
			{
				public const string PkPoliceStation = "pkPoliceStation";
				public const string Year = "year";

				public new static IEnumerable<string> AsEnumerable()
				{
					return SAPSRest.Request.Parameters.AsEnumerable()
						.Append(PkPoliceStation)
						.Append(Year);
				}
			}

			public int[]? PkPoliceStation { get; set; }
			public int[]? Year { get; set; }
		}
	}
}
