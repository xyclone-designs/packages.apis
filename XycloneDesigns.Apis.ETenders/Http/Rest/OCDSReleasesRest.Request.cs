using System;
using System.Collections.Generic;
using System.Net.Http;

namespace XycloneDesigns.Apis.ETenders.Http.Rest
{
	public partial class OCDSReleasesRest
	{
		public const string Path = "OCDSReleases/release";

		public static IEnumerable<string> ToUriParameters(Request request)
		{
			if (request.DateFrom.HasValue)
				yield return string.Format("{0}={1:yyyy-MM-dd}", OCDSReleases.Request.Parameters.DateFrom, request.DateFrom.Value);

			if (request.DateTo.HasValue)
				yield return string.Format("{0}={1:yyyy-MM-dd}", OCDSReleases.Request.Parameters.DateTo, request.DateTo.Value);

			if (request.PageNumber.HasValue)
				yield return string.Format("{0}={1}", OCDSReleases.Request.Parameters.PageNumber, request.PageNumber.Value);

			if (request.PageSize.HasValue)
				yield return string.Format("{0}={1}", OCDSReleases.Request.Parameters.PageSize, request.PageSize.Value);
		}

		public class Request : OCDSReleases.Request
		{
			public override HttpRequestMessage ToHttpRequestMessage(string? pathbase = null, string? path = null)
			{
				return new HttpRequestMessage
				{
					Method = HttpMethod.Get,
					RequestUri = new Uri(string.Format("{0}/{1}?{2}", pathbase ?? ETendersRest.Path, path ?? Path, string.Join('&', ToUriParameters(this))))
				};
			}
		}
	}
}
