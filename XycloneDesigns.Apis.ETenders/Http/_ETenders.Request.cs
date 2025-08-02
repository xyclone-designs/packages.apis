using System.Net.Http;

namespace XycloneDesigns.Apis.ETenders.Http
{
	public static partial class ETenders
	{
		public abstract class Request
		{
			public abstract HttpRequestMessage ToHttpRequestMessage(string? pathbase = null, string? path = null);
		}
	}
}
