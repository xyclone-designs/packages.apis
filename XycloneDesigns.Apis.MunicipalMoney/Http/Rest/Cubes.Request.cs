using System;
using System.Net.Http;

using XycloneDesigns.Apis.MunicipalMoney.Http.Rest;

namespace XycloneDesigns.Apis.MunicipalMoney.Http.Rest
{
	public partial class Cube
	{
		public class Request : MunicipalMoneyRest.Request
		{
			public override HttpRequestMessage ToHttpRequestMessage()
			{
				return new HttpRequestMessage
				{
					Method = HttpMethod.Get,
					RequestUri = new Uri(Path)
				};
			}
		}
	}
}
