using System.Collections.Generic;

namespace XycloneDesigns.Apis.MunicipalMoney.Http
{
	public partial class Cubes
	{
		public abstract class Request : MunicipalMoney.Request
		{
			public new class Parameters : MunicipalMoney.Request.Parameters
			{
				public new static IEnumerable<string> AsEnumerable()
				{
					return MunicipalMoney.Request.Parameters.AsEnumerable();
				}
			}
		}
	}
}
