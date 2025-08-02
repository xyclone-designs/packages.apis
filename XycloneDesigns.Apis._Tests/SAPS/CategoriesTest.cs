using Newtonsoft.Json.Linq;

using System.Net.Http;

using Xunit;

using XycloneDesigns.Apis.SAPS.Http.Rest;

using JsonSerializerSystem = System.Text.Json.JsonSerializer;

namespace XycloneDesigns.Apis._Tests.SAPS
{
	public class CategoriesTest
	{
		[Fact] public async void Http()
		{
			CategoriesRest.Request request = new()
			{
				PageSize = 1
			};

			using HttpRequestMessage httprequestmessage = request.ToHttpRequestMessage();
			using HttpResponseMessage httpresponsemessage = await Globals.HttpClient.SendAsync(httprequestmessage);

			string json = await httpresponsemessage.Content.ReadAsStringAsync();

			JObject.Parse(json).ToObject<CategoriesRest.Response>();
			JsonSerializerSystem.Deserialize<CategoriesRest.Response>(json);
		}
	}
}