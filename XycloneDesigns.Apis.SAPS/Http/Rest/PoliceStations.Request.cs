using System.Linq;
using System.Collections.Generic;

namespace XycloneDesigns.Apis.SAPS.Http.Rest
{
	public partial class PoliceStations 
	{
		public class Request : SAPSRest.Request
		{
			public new class Parameters : SAPSRest.Request.Parameters
			{
				public const string PkDistrict = "pkDistrict";
				public const string PkMunicipality = "pkMunicipality";
				public const string PkProvince = "pkProvince";

				public new static IEnumerable<string> AsEnumerable()
				{
					return SAPSRest.Request.Parameters.AsEnumerable()
						.Append(PkDistrict)
						.Append(PkMunicipality)
						.Append(PkProvince);
				}
			}

			public int[]? PkDistrict { get; set; }
			public int[]? PkMunicipality { get; set; }
			public int[]? PkProvince { get; set; }
		}
	}
}
