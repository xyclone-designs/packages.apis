using Newtonsoft.Json.Linq;

using System.IO;
using System.Net.Http;

using Xunit;

using XycloneDesigns.Apis.MunicipalMoney.Http.Rest;

namespace XycloneDesigns.Apis._Tests.MunicipalMoney
{
	public partial class CubeModelTest
	{
		private readonly static HttpClient _HttpClient = new();

		[Theory]
		[InlineData("aged_creditor")]
		[InlineData("aged_creditor_v2")]
		[InlineData("aged_debtor")]
		[InlineData("aged_debtor_v2")]
		[InlineData("audit_opinions")]
		[InlineData("bsheet")]
		[InlineData("capital")]
		[InlineData("capital_v2")]
		[InlineData("cflow")]
		[InlineData("cflow_v2")]
		[InlineData("conditional_grants")]
		[InlineData("demarcation_changes")]
		[InlineData("financial_position_v2")]
		[InlineData("grants_v2")]
		[InlineData("incexp")]
		[InlineData("incexp_v2")]
		[InlineData("municipalities")]
		[InlineData("officials")]
		[InlineData("repmaint")]
		[InlineData("repmaint_v2")]
		[InlineData("uifwexp")]
		public async void HttpAggregate(string cubename)
		{
			CubeAggregate.Request request = new (cubename)
			{
				PageSize = 20,
			};

			using HttpRequestMessage httprequestmessage = request.ToHttpRequestMessage();
			using HttpResponseMessage httpresponsemessage = await _HttpClient.SendAsync(httprequestmessage);

			string json = await httpresponsemessage.Content.ReadAsStringAsync();

			JObject.Parse(json).ToObject<CubeAggregate.Response>();
		}


		[Theory]
		[InlineData("aged_creditor")]
		[InlineData("aged_creditor_v2")]
		[InlineData("aged_debtor")]
		[InlineData("aged_debtor_v2")]
		[InlineData("audit_opinions")]
		[InlineData("bsheet")]
		[InlineData("capital")]
		[InlineData("capital_v2")]
		[InlineData("cflow")]
		[InlineData("cflow_v2")]
		[InlineData("conditional_grants")]
		[InlineData("demarcation_changes")]
		[InlineData("financial_position_v2")]
		[InlineData("grants_v2")]
		[InlineData("incexp")]
		[InlineData("incexp_v2")]
		[InlineData("municipalities")]
		[InlineData("officials")]
		[InlineData("repmaint")]
		[InlineData("repmaint_v2")]
		[InlineData("uifwexp")]
		public async void HttpFact(string cubename)
		{
			CubeFacts.Request request = new(cubename)
			{
				PageSize = 20,
			};

			using HttpRequestMessage httprequestmessage = request.ToHttpRequestMessage();
			using HttpResponseMessage httpresponsemessage = await _HttpClient.SendAsync(httprequestmessage);

			string json = await httpresponsemessage.Content.ReadAsStringAsync();

			JObject.Parse(json).ToObject<CubeFacts.Response>();
		}


		[Theory]
		[InlineData("aged_creditor", "demarcation")]
		[InlineData("aged_creditor_v2", "demarcation")]
		[InlineData("aged_debtor", "demarcation")]
		[InlineData("aged_debtor_v2", "demarcation")]
		[InlineData("audit_opinions", "demarcation")]
		[InlineData("bsheet", "demarcation")]
		[InlineData("capital", "demarcation")]
		[InlineData("capital_v2", "demarcation")]
		[InlineData("cflow", "demarcation")]
		[InlineData("cflow_v2", "demarcation")]
		[InlineData("conditional_grants", "demarcation")]
		[InlineData("demarcation_changes", "new_demarcation")]
		[InlineData("financial_position_v2", "demarcation")]
		[InlineData("grants_v2", "demarcation")]
		[InlineData("incexp", "demarcation")]
		[InlineData("incexp_v2", "demarcation")]
		[InlineData("municipalities", "municipality")]
		[InlineData("officials", "contact_details")]
		[InlineData("repmaint", "demarcation")]
		[InlineData("repmaint_v2", "demarcation")]
		[InlineData("uifwexp", "demarcation")]
		public async void HttpMembersDemarcation(string cubename, string cubemembername)
		{
			CubeMembersDemarcation.Request request = new(cubename, cubemembername)
			{
				PageSize = 20,
			};

			using HttpRequestMessage httprequestmessage = request.ToHttpRequestMessage();
			using HttpResponseMessage httpresponsemessage = await _HttpClient.SendAsync(httprequestmessage);

			string json = await httpresponsemessage.Content.ReadAsStringAsync();

			JObject.Parse(json).ToObject<CubeMembersDemarcation.Response>();
		}


		[Theory]
		[InlineData("aged_creditor")]
		[InlineData("aged_creditor_v2")]
		[InlineData("aged_debtor")]
		[InlineData("aged_debtor_v2")]
		[InlineData("audit_opinions")]
		[InlineData("bsheet")]
		[InlineData("capital")]
		[InlineData("capital_v2")]
		[InlineData("cflow")]
		[InlineData("cflow_v2")]
		[InlineData("conditional_grants")]
		[InlineData("demarcation_changes")]
		[InlineData("financial_position_v2")]
		[InlineData("grants_v2")]
		[InlineData("incexp")]
		[InlineData("incexp_v2")]
		[InlineData("municipalities")]
		[InlineData("officials")]
		[InlineData("repmaint")]
		[InlineData("repmaint_v2")]
		[InlineData("uifwexp")]
		public async void HttpModel(string cubename)
		{
			CubeModel.Request request = new(cubename);

			using HttpRequestMessage httprequestmessage = request.ToHttpRequestMessage();
			using HttpResponseMessage httpresponsemessage = await _HttpClient.SendAsync(httprequestmessage);

			string json = await httpresponsemessage.Content.ReadAsStringAsync();

			JObject.Parse(json).ToObject<CubeModel.Response>();
		}
	}
}