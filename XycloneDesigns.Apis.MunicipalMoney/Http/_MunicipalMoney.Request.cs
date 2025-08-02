using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace XycloneDesigns.Apis.MunicipalMoney.Http
{
	public partial class MunicipalMoney
	{
		public abstract class Request
		{
			public class Parameters 
			{
				public static IEnumerable<string> AsEnumerable()
				{
					return Enumerable.Empty<string>();
				}
			}

			public abstract HttpRequestMessage ToHttpRequestMessage(string? pathbase = null, string? path = null);
		}
	}
}
