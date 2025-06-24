using System.Linq;
using System.Collections.Generic;

namespace XycloneDesigns.Apis.IEC.Http.Rest
{
	public partial class Languages 
	{
		public class Request : IECRest.Request
		{
			public new class Parameters : IECRest.Request.Parameters
			{
				public new static IEnumerable<string> AsEnumerable()
				{
					return IECRest.Request.Parameters.AsEnumerable()
						.Append(PkElectoralEvent)
						.Append(PkMunicipality)
						.Append(PkProvince)
						.Append(PkVotingDistrict)
						.Append(PkWard)
						.Append(Type);
				}
			}

			public int[]? PkElectoralEvent { get; set; }
			public int[]? PkMunicipality { get; set; }
			public int[]? PkProvince { get; set; }
			public int[]? PkVotingDistrict { get; set; }
			public int[]? PkWard { get; set; }
			public string[]? Type { get; set; }
		}
	}
}
