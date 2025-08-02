using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System.Collections.Generic;
using System.IO;
using System.Net.Http;

using Xunit;

using XycloneDesigns.Apis.MunicipalMoney.Http.Rest;

using JsonSerializerSystem = System.Text.Json.JsonSerializer;

namespace XycloneDesigns.Apis._Tests.MunicipalMoney
{
	public partial class CubeModelTest
	{
		public static IEnumerable<object[]> CubeNames()
		{
			return GlobalsMunicipalMoney.CubeNames;
		}
		public static IEnumerable<object[]> CubeJsons()
		{
			return GlobalsMunicipalMoney.CubeNamesModel;
		}

		[MemberData(nameof(CubeNames))]
		[Theory] public async void Http(string cubename)
		{
			CubeModelRest.Request request = new(cubename);

			using HttpRequestMessage httprequestmessage = request.ToHttpRequestMessage();
			using HttpResponseMessage httpresponsemessage = await Globals.HttpClient.SendAsync(httprequestmessage);

			string json = await httpresponsemessage.Content.ReadAsStringAsync();

			JObject.Parse(json).ToObject<CubeModelRest.Response>();
			JsonSerializerSystem.Deserialize<CubeModelRest.Response>(json);
		}

		[MemberData(nameof(CubeJsons))]
		[Theory] public async void Json(string file)
		{
			string filepath = Path.Combine(GlobalsMunicipalMoney.Directory_Datas, file);

			using FileStream filestream = File.OpenRead(filepath);
			using StreamReader streamreader = new(filestream);

			string json = await streamreader.ReadToEndAsync();

			JObject.Parse(json).ToObject<CubeModelRest.Response>();
			JsonSerializerSystem.Deserialize<CubeModelRest.Response>(json);
		}
	}
}