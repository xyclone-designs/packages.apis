using System;
using System.Net.Http;

using XycloneDesigns.Apis.MunicipalMoney.Http.Rest;

namespace XycloneDesigns.Apis.ETenders.Http.Rest
{
	public partial class Cube
	{
		public class Request : MunicipalMoneyRest.Request 
		{
			public new const string Path = MunicipalMoneyRest.Request.Path + "/cubes";

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
