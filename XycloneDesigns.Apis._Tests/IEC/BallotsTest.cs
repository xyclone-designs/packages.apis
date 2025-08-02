using Newtonsoft.Json.Linq;

using System.Net.Http;

using Xunit;

using XycloneDesigns.Apis.IEC.Http.Rest;

using JsonSerializerSystem = System.Text.Json.JsonSerializer;

namespace XycloneDesigns.Apis._Tests.IEC
{
	public partial class BallotsTest
	{
		[Fact] public async void Http()
		{
			BallotsRest.Request request = new()
			{
				PageSize = 1
			};

			using HttpRequestMessage httprequestmessage = request.ToHttpRequestMessage();
			using HttpResponseMessage httpresponsemessage = await Globals.HttpClient.SendAsync(httprequestmessage);

			string json = await httpresponsemessage.Content.ReadAsStringAsync();

			JObject.Parse(json).ToObject<BallotsRest.Response>();
			JsonSerializerSystem.Deserialize<BallotsRest.Response>(json);
		}
	}
}