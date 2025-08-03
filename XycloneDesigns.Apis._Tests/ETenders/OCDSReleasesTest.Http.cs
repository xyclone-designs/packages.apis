using Newtonsoft.Json.Linq;

using System;
using System.Net.Http;

using Xunit;

using XycloneDesigns.Apis.ETenders.Http.Rest;

using JsonSerializerSystem = System.Text.Json.JsonSerializer;

namespace XycloneDesigns.Apis._Tests.ETenders
{
	public partial class OCDSReleasesTest
	{
		[Theory]
		[InlineData(1, 50, "2024-01-01", "2024-03-20")]
		public async void HttpMultiple(int pageNumber, int pageSize, string dateFrom, string dateTo)
		{
			OCDSReleasesRest.Request requestmultiple = new() 
			{
				PageNumber = pageNumber,
				PageSize = pageSize,
				DateFrom = DateTime.Parse(dateFrom),
				DateTo = DateTime.Parse(dateTo),
			};

			using HttpClient httpclient = new();
			using HttpRequestMessage httprequestmessage = requestmultiple.ToHttpRequestMessage();
			using HttpResponseMessage httpresponsemessage = await httpclient.SendAsync(httprequestmessage);

			string response = await httpresponsemessage.Content.ReadAsStringAsync();

			JObject.Parse(response).ToObject<OCDSReleasesRest.Response>();
			JsonSerializerSystem.Deserialize<OCDSReleasesRest.Response>(response);
		}

		[Theory]
		[InlineData("ocds-9t57fa-86364")]
		public async void HttpSingle(string ocid)
		{
			OCDSReleaseRest.Request requestsingle = new(ocid);

			using HttpClient httpclient = new();
			using HttpRequestMessage httprequestmessage = requestsingle.ToHttpRequestMessage();
			using HttpResponseMessage httpresponsemessage = await httpclient.SendAsync(httprequestmessage);

			string response = await httpresponsemessage.Content.ReadAsStringAsync();

			JObject.Parse(response).ToObject<OCDSReleaseRest.Response>();
			JsonSerializerSystem.Deserialize<OCDSReleaseRest.Response>(response);
		}
	}
}