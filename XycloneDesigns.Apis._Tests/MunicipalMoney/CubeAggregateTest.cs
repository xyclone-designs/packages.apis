using Newtonsoft.Json.Linq;

using System.Collections.Generic;
using System.IO;
using System.Net.Http;

using Xunit;

using XycloneDesigns.Apis.MunicipalMoney.Http.Rest;

using JsonSerializerSystem = System.Text.Json.JsonSerializer;

namespace XycloneDesigns.Apis._Tests.MunicipalMoney
{
	public partial class CubeAggregateTest
	{
		public static IEnumerable<object[]> CubeNames()
		{
			return GlobalsMunicipalMoney.CubeNames;
		}
		public static IEnumerable<object[]> CubeJsons()
		{
			return GlobalsMunicipalMoney.CubeJsons;
		}

		[MemberData(nameof(CubeNames))]
		[Theory] public async void Http(string cubename)
		{
			AggregateRest.Request request = new(cubename)
			{
				PageSize = 1,
			};

			using HttpRequestMessage httprequestmessage = request.ToHttpRequestMessage();
			using HttpResponseMessage httpresponsemessage = await Globals.HttpClient.SendAsync(httprequestmessage);

			string json = await httpresponsemessage.Content.ReadAsStringAsync();

			JObject.Parse(json).ToObject<AggregateRest.Response>();
			JsonSerializerSystem.Deserialize<AggregateRest.Response>(json);
		}

		[MemberData(nameof(CubeJsons))]
		[Theory] public async void Json(string file)
		{
			string filepath = Path.Combine(GlobalsMunicipalMoney.Directory_Datas, file);

			using FileStream filestream = File.OpenRead(filepath);
			using StreamReader streamreader = new(filestream);

			string json = await streamreader.ReadToEndAsync();

			JObject.Parse(json).ToObject<AggregateRest.Response>();
			JsonSerializerSystem.Deserialize<AggregateRest.Response>(json);
		}
	}
}