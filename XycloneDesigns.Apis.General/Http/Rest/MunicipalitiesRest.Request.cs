using System;
using System.Net.Http;

namespace XycloneDesigns.Apis.General.Http.Rest
{
	public partial class MunicipalitiesRest
	{
		public const string Path = "municipalities";

		public class Request : Municipalities.Request
		{
			public override HttpRequestMessage ToHttpRequestMessage(string? pathbase = null, string? path = null)
			{
				return new HttpRequestMessage
				{
					Method = HttpMethod.Get,
					RequestUri = new Uri(string.Format("{0}/{1}?{2}", pathbase ?? GeneralRest.PathBase, path ?? Path, string.Join('&', GeneralRest.ToUriParameters(this))))
				};
			}
		}
	}
}
