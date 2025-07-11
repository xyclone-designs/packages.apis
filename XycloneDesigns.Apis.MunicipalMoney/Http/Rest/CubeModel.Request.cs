using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

using XycloneDesigns.Apis.MunicipalMoney.Http.Rest;

namespace XycloneDesigns.Apis.MunicipalMoney.Http.Rest
{
	public partial class CubeModel
	{
		public class Request : MunicipalMoneyRest.Request
		{
			public Request(string cubename) : base()
			{
				CubeName = cubename;
			}

			public string CubeName { get; set; }

			public override HttpRequestMessage ToHttpRequestMessage()
			{
				return new HttpRequestMessage
				{
					Method = HttpMethod.Get,
					RequestUri = new Uri(string.Format("{0}/{1}/model", Path, CubeName)),
				};
			}
		}
	}
}
