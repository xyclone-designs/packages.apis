using System.Collections.Generic;

using XycloneDesigns.Apis.General.Http.Rest;

namespace XycloneDesigns.Apis.IEC.Http.Rest
{
	public partial class IECRest
	{
		public class Request : GeneralRest.Request
		{
			public new class Parameters : GeneralRest.Request.Parameters
			{
				public const string Abbr = "Abbr";
				public const string GeoCode = "GeoCode";
				public const string Id = "Id";
				public const string PkElectoralEvent = "PkElectoralEvent";
				public const string PkMunicipality = "PkMunicipality";
				public const string PkProvince = "PkProvince";
				public const string PkVotingDistrict = "PkVotingDistrict";
				public const string PkWard = "PkWard";
				public const string Type = "Type";

				public new static IEnumerable<string> AsEnumerable()
				{
					return GeneralRest.Request.Parameters.AsEnumerable();
				}
			}
		}
	}
}
