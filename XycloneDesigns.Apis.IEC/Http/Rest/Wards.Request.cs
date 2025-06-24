using System.Linq;
using System.Collections.Generic;

namespace XycloneDesigns.Apis.IEC.Http.Rest
{
	public partial class Wards 
	{
		public class Request : IECRest.Request
		{
			public new class Parameters : IECRest.Request.Parameters
			{
				public new static IEnumerable<string> AsEnumerable()
				{
					return IECRest.Request.Parameters.AsEnumerable()
						.Append(Id)
						.Append(PkMunicipality)
						.Append(PkProvince);
				}
			}

			public string[]? Id { get; set; }
			public int[]? PkMunicipality { get; set; }
			public int[]? PkProvince { get; set; }
		}
	}
}
