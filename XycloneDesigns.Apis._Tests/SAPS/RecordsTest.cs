using Newtonsoft.Json.Linq;

using System.Net.Http;

using Xunit;

using XycloneDesigns.Apis.SAPS.Http.Rest;

using JsonSerializerSystem = System.Text.Json.JsonSerializer;

namespace XycloneDesigns.Apis._Tests.SAPS
{
	public class RecordsTest
	{
		[Fact] public async void Http()
		{
			RecordsRest.Request request = new()
			{
				PageSize = 1
			};

			using HttpRequestMessage httprequestmessage = request.ToHttpRequestMessage();
			using HttpResponseMessage httpresponsemessage = await Globals.HttpClient.SendAsync(httprequestmessage);

			string json = await httpresponsemessage.Content.ReadAsStringAsync();

			JObject.Parse(json).ToObject<RecordsRest.Response>();
			JsonSerializerSystem.Deserialize<RecordsRest.Response>(json);
		}
	}
}