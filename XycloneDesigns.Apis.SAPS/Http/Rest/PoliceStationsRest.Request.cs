using System;
using System.Net.Http;

using XycloneDesigns.Apis.General.Http.Rest;

namespace XycloneDesigns.Apis.SAPS.Http.Rest
{
	public partial class PoliceStationsRest
	{
		public const string Path = "policestations";

		public class Request : PoliceStations.Request
		{
			public override HttpRequestMessage ToHttpRequestMessage(string? pathbase = null, string? path = null)
			{
				return new HttpRequestMessage
				{
					Method = HttpMethod.Get,
					RequestUri = new Uri(string.Format("{0}{1}?{2}", pathbase ?? SAPSRest.PathBase, path ?? Path, string.Join('&', GeneralRest.ToUriParameters(this))))
				};
			}
		}
	}
}
