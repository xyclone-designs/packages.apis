using System;
using System.Net.Http;

namespace XycloneDesigns.Apis.MunicipalMoney.Http.Rest
{
	public partial class CubesRest
	{
		public class Request : Cubes.Request
		{
			public const string Path = "cubes";

			public override HttpRequestMessage ToHttpRequestMessage(string? pathbase = null, string? path = null)
			{
				return new HttpRequestMessage
				{
					Method = HttpMethod.Get,
					RequestUri = new Uri(string.Format("{0}{1}", pathbase ?? MunicipalMoneyRest.PathBase, path ?? Path))
				};
			}
		}
	}
}
