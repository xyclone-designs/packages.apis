using System;
using System.Net.Http;

using XycloneDesigns.Apis.General.Http.Rest;

namespace XycloneDesigns.Apis.Afrobarometer.Http.Rest
{
	public partial class SurveysRest
	{
		public const string Path = "surveys";

		public class Request : Surveys.Request
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
