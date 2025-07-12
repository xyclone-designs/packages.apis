using Newtonsoft.Json.Linq;

using System.IO;
using System.Net.Http;

using Xunit;

using XycloneDesigns.Apis.MunicipalMoney.Http.Rest;

using JsonSerializerSystem = System.Text.Json.JsonSerializer;

namespace XycloneDesigns.Apis._Tests.MunicipalMoney
{
	public partial class CubeMembersDemarcationTest
	{
		[InlineData(GlobalsMunicipalMoney.CubeNamesDemarcated)]
		[Theory] public async void Http(string cubename, string cubemembername)
		{
			CubeMembersDemarcation.Request request = new(cubename, cubemembername)
			{
				PageSize = 1,
			};

			using HttpRequestMessage httprequestmessage = request.ToHttpRequestMessage();
			using HttpResponseMessage httpresponsemessage = await Globals.HttpClient.SendAsync(httprequestmessage);

			string json = await httpresponsemessage.Content.ReadAsStringAsync();

			JObject.Parse(json).ToObject<CubeMembersDemarcation.Response>();
			JsonSerializerSystem.Deserialize<CubeMembersDemarcation.Response>(json);
		}

		[InlineData("aged_creditor_demarcation.json")]
		[Theory] public async void Json(string file)
		{
			string filepath = Path.Combine(GlobalsMunicipalMoney.Directory_Datas, file);

			using FileStream filestream = File.OpenRead(filepath);
			using StreamReader streamreader = new(filestream);

			string json = await streamreader.ReadToEndAsync();

			JObject.Parse(json).ToObject<CubeMembersDemarcation.Response>();
			JsonSerializerSystem.Deserialize<CubeMembersDemarcation.Response>(json);
		}
	}
}