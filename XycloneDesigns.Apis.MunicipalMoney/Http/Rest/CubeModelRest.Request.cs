using System;
using System.Net.Http;

namespace XycloneDesigns.Apis.MunicipalMoney.Http.Rest
{
	public partial class CubeModelRest
	{
		public static string Path(string cubename) => string.Format("/cubes/{0}/model", cubename);

		public class Request : CubeModel.Request
		{
			public Request(string cubename) : base(cubename) { }

			public override HttpRequestMessage ToHttpRequestMessage(string? pathbase = null, string? path = null)
			{
				return new HttpRequestMessage
				{
					Method = HttpMethod.Get,
					RequestUri = new Uri(string.Format("{0}{1}", pathbase ?? MunicipalMoneyRest.PathBase, path ?? Path(CubeName), CubeName))
				};
			}
		}
	}
}
