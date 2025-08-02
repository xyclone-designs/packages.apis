using Newtonsoft.Json.Linq;

using System;
using System.Net.Http;

using Xunit;

using XycloneDesigns.Apis.General.Http;
using XycloneDesigns.Apis.General.Http.Rest;

using JsonSerializerSystem = System.Text.Json.JsonSerializer;

namespace XycloneDesigns.Apis._Tests.General
{
	public partial class CountriesTest
	{
		[Fact] public async void HttpRest()
		{
			CountriesRest.Request request = new()
			{
				Page = 1,
				PageSize = 1,
			};

			using HttpRequestMessage httprequestmessage = request.ToHttpRequestMessage();
			using HttpResponseMessage httpresponsemessage = await Globals.HttpClient.SendAsync(httprequestmessage);

			Console.WriteLine("CountriesTest.HttpRest.Uri: '{0}'", httprequestmessage.RequestUri);

			string json = await httpresponsemessage.Content.ReadAsStringAsync();

			JObject.Parse(json).ToObject<CountriesRest.Response>();
			JsonSerializerSystem.Deserialize<CountriesRest.Response>(json);
		}
	}
}