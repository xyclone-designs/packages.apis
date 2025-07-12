using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System.IO;
using System.Linq;
using System.Net.Http;

using Xunit;

using XycloneDesigns.Apis.MunicipalMoney.Http.Rest;

using JsonSerializerSystem = System.Text.Json.JsonSerializer;

namespace XycloneDesigns.Apis._Tests.MunicipalMoney
{
	public partial class CubeModelTest
	{
		[InlineData(GlobalsMunicipalMoney.CubeNames)]
		[Theory] public async void Http(string cubename)
		{
			CubeModel.Request request = new(cubename);

			using HttpRequestMessage httprequestmessage = request.ToHttpRequestMessage();
			using HttpResponseMessage httpresponsemessage = await Globals.HttpClient.SendAsync(httprequestmessage);

			string json = await httpresponsemessage.Content.ReadAsStringAsync();

			JObject.Parse(json).ToObject<CubeModel.Response>();
			JsonSerializerSystem.Deserialize<CubeModel.Response>(json);
		}

		[InlineData(GlobalsMunicipalMoney.CubeNames.Select(_ => string.Format("{0}_model.json", _)))]
		[Theory] public async void Json(string file)
		{
			string filepath = Path.Combine(GlobalsMunicipalMoney.Directory_Datas, file);

			using FileStream filestream = File.OpenRead(filepath);
			using StreamReader streamreader = new(filestream);

			string json = await streamreader.ReadToEndAsync();

			JObject.Parse(json).ToObject<CubeModel.Response>();
			JsonSerializerSystem.Deserialize<CubeModel.Response>(json);
		}
	}
}