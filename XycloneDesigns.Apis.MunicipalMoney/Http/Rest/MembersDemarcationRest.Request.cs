using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace XycloneDesigns.Apis.MunicipalMoney.Http.Rest
{
	public partial class MembersDemarcationRest
	{
		public static string Path(string cubename, string cubemembername) => string.Format("/cubes/{0}/members/{1}", cubename, cubemembername);

		public class Request(string cubename, string cubemembername) : MembersDemarcation.Request(cubename, cubemembername)
		{
			public static IEnumerable<string> ToUriParameters(Request request)
			{
				foreach (string uriparameter in MunicipalMoneyRest.Request.ToUriParameters(request))
					yield return uriparameter;

				if (request.Cut.Count > 0)
					yield return string.Format("{0}={1}", Parameters.Cut, string.Join('|', request.Cut.Select(_ => _.AsString())));

				if (request.Format is not null)
					yield return string.Format("{0}={1}", Parameters.Format, request.Format);

				if (request.Page.HasValue)
					yield return string.Format("{0}={1}", Parameters.Page, request.Page.Value);

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
					RequestUri = new Uri(string.Format("{0}{1}?{2}", pathbase ?? MunicipalMoneyRest.PathBase, path ?? Path(CubeName, CubeMemberName), string.Join('&', ToUriParameters(this))))
				};
			}
		}
	}
}
