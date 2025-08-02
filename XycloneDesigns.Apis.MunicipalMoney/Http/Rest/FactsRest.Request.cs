using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;

namespace XycloneDesigns.Apis.MunicipalMoney.Http.Rest
{
	public partial class FactsRest
	{
		public static string Path(string cubename) => string.Format("/cubes/{1}/facts", cubename);

		public class Request(string cubename) : Facts.Request(cubename)
		{
			public static IEnumerable<string> ToUriParameters(Request request)
			{
				foreach (string uriparameter in MunicipalMoneyRest.Request.ToUriParameters(request))
					yield return uriparameter;

				if (request.Cut.Count > 0)
					yield return string.Format("{0}={1}", Parameters.Cut, string.Join('|', request.Cut.Select(_ => _.AsString())));
				
				if (request.Format is not null)
					yield return string.Format("{0}={1}", Parameters.Format, request.Format);

				if (request.PageSize.HasValue)
					yield return string.Format("{0}={1}", Parameters.PageSize, request.PageSize.Value);

				if (request.PageSize.HasValue)
					yield return string.Format("{0}={1}", Parameters.PageSize, request.PageSize.Value);

				if (request.Order.Count > 0)
					yield return string.Format("{0}={1}", Parameters.Order, string.Join('|', request.Order.Select(_ => _.AsString())));
			}

			public override HttpRequestMessage ToHttpRequestMessage(string? pathbase = null, string? path = null)
			{
				return new HttpRequestMessage
				{
					Method = HttpMethod.Get,
					RequestUri = new Uri(string.Format("{0}{1}?{2}", pathbase ?? MunicipalMoneyRest.PathBase, path ?? Path(CubeName), string.Join('&', ToUriParameters(this))))
				};
			}
		}
	}
}
