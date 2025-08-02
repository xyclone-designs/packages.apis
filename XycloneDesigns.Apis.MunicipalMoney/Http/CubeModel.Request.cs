using System.Collections.Generic;

namespace XycloneDesigns.Apis.MunicipalMoney.Http
{
	public partial class CubeModel
	{
		public abstract class Request(string cubename) : MunicipalMoney.Request
		{
			public new class Parameters : MunicipalMoney.Request.Parameters
			{
				public new static IEnumerable<string> AsEnumerable()
				{
					return MunicipalMoney.Request.Parameters.AsEnumerable();
				}
			}

			public string CubeName { get; set; } = cubename;
		}
	}
}