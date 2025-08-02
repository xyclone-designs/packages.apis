using System;
using System.Net.Http;

using XycloneDesigns.Apis.General.Http.Rest;

namespace XycloneDesigns.Apis.IEC.Http.Rest
{
	public partial class BallotsRest
	{
		public const string Path = "ballots";

		public class Request : Ballots.Request
		{
			public override HttpRequestMessage ToHttpRequestMessage(string? pathbase = null, string? path = null)
			{
				return new HttpRequestMessage
				{
					Method = HttpMethod.Get,
					RequestUri = new Uri(string.Format("{0}{1}?{2}", pathbase ?? IECRest.PathBase, path ?? Path, string.Join('&', GeneralRest.ToUriParameters(this))))
				};
			}
		}
	}
}
