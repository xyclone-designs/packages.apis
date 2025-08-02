using System;
using System.IO;
using System.Net.Http;

using XycloneDesigns.Apis.General.Http.Rest;

namespace XycloneDesigns.Apis.Afrobarometer.Http.Rest
{
	public partial class VariablesRest
	{
		public const string Path = "variables";

		public class Request : Variables.Request
		{
			public override HttpRequestMessage ToHttpRequestMessage(string? pathbase = null, string? path = null)
			{
				return new HttpRequestMessage
				{
					Method = HttpMethod.Get,
					RequestUri = new Uri(string.Format("{0}{1}?{2}", pathbase ?? AfrobarometerRest.PathBase, path ?? Path, string.Join('&', GeneralRest.ToUriParameters(this))))
				};
			}
		}
	}
}