using System;
using System.Net.Http;

using Xunit;

using XycloneDesigns.Apis.ETenders.Http.Rest;

namespace XycloneDesigns.Apis._Tests.ETenders
{
	public class OCDSReleasesTest
	{
		[Theory]
		[InlineData(1, 50, "2024-01-01", "2024-03-31")]
		public async void RequestMultiple(int pageNumber, int pageSize, string dateFrom, string dateTo)
		{
			OCDSReleases.RequestMultiple requestmultiple = new() 
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

			OCDSReleases.ResponseMultiple responsemultiple = new(response);

			Console.WriteLine(responsemultiple);
		}

		[Theory]
		[InlineData("Nothing")]
		[InlineData("ocds-9t57fa-86364")]
		public async void RequestSingle(string ocid)
		{
			OCDSReleases.RequestSingle requestsingle = new(ocid);

			using HttpClient httpclient = new();
			using HttpRequestMessage httprequestmessage = requestsingle.ToHttpRequestMessage();
			using HttpResponseMessage httpresponsemessage = await httpclient.SendAsync(httprequestmessage);

			string response = await httpresponsemessage.Content.ReadAsStringAsync();

			OCDSReleases.ResponseSingle responsesingle = new(response);

			Console.WriteLine(responsesingle);
		}
	}
}