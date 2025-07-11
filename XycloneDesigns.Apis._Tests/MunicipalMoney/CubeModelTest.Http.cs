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
		[InlineData("aged_creditor_aggregate")]
		[InlineData("aged_creditor_v2_aggregate")]
		[InlineData("aged_debtor_aggregate")]
		[InlineData("aged_debtor_v2_aggregate")]
		[InlineData("audit_opinions_aggregate")]
		[InlineData("bsheet_aggregate")]
		[InlineData("capital_aggregate")]
		[InlineData("capital_v2_aggregate")]
		[InlineData("cflow_aggregate")]
		[InlineData("cflow_v2_aggregate")]
		[InlineData("conditional_grants_aggregate")]
		[InlineData("demarcation_changes_aggregate")]
		[InlineData("financial_position_v2_aggregate")]
		[InlineData("grants_v2_aggregate")]
		[InlineData("incexp_aggregate")]
		[InlineData("incexp_v2_aggregate")]
		[InlineData("municipalities_aggregate")]
		[InlineData("officials_aggregate")]
		[InlineData("repmaint_aggregate")]
		[InlineData("repmaint_v2_aggregate")]
		[InlineData("uifwexp_aggregate")]
		public async void HttpAggregate(string cubename)
		{
			CubeAggregate.Request request = new (cubename);

			using HttpRequestMessage httprequestmessage = request.ToHttpRequestMessage();
			using HttpResponseMessage httpresponsemessage = await _HttpClient.SendAsync(httprequestmessage);

			string json = await httpresponsemessage.Content.ReadAsStringAsync();

			JObject.Parse(json).ToObject<CubeAggregate.Response>();
		}


		[Theory]
		[InlineData("aged_creditor_aggregate")]
		[InlineData("aged_creditor_v2_aggregate")]
		[InlineData("aged_debtor_aggregate")]
		[InlineData("aged_debtor_v2_aggregate")]
		[InlineData("audit_opinions_aggregate")]
		[InlineData("bsheet_aggregate")]
		[InlineData("capital_aggregate")]
		[InlineData("capital_v2_aggregate")]
		[InlineData("cflow_aggregate")]
		[InlineData("cflow_v2_aggregate")]
		[InlineData("conditional_grants_aggregate")]
		[InlineData("demarcation_changes_aggregate")]
		[InlineData("financial_position_v2_aggregate")]
		[InlineData("grants_v2_aggregate")]
		[InlineData("incexp_aggregate")]
		[InlineData("incexp_v2_aggregate")]
		[InlineData("municipalities_aggregate")]
		[InlineData("officials_aggregate")]
		[InlineData("repmaint_aggregate")]
		[InlineData("repmaint_v2_aggregate")]
		[InlineData("uifwexp_aggregate")]
		public async void HttpFact(string cubename)
		{
			CubeFacts.Request request = new(cubename);

			using HttpRequestMessage httprequestmessage = request.ToHttpRequestMessage();
			using HttpResponseMessage httpresponsemessage = await _HttpClient.SendAsync(httprequestmessage);

			string json = await httpresponsemessage.Content.ReadAsStringAsync();

			JObject.Parse(json).ToObject<CubeFacts.Response>();
		}


		[Theory]
		[InlineData("aged_creditor_aggregate", "TODO")]
		[InlineData("aged_creditor_v2_aggregate", "TODO")]
		[InlineData("aged_debtor_aggregate", "TODO")]
		[InlineData("aged_debtor_v2_aggregate", "TODO")]
		[InlineData("audit_opinions_aggregate", "TODO")]
		[InlineData("bsheet_aggregate", "TODO")]
		[InlineData("capital_aggregate", "TODO")]
		[InlineData("capital_v2_aggregate", "TODO")]
		[InlineData("cflow_aggregate", "TODO")]
		[InlineData("cflow_v2_aggregate", "TODO")]
		[InlineData("conditional_grants_aggregate", "TODO")]
		[InlineData("demarcation_changes_aggregate", "TODO")]
		[InlineData("financial_position_v2_aggregate", "TODO")]
		[InlineData("grants_v2_aggregate", "TODO")]
		[InlineData("incexp_aggregate", "TODO")]
		[InlineData("incexp_v2_aggregate", "TODO")]
		[InlineData("municipalities_aggregate", "TODO")]
		[InlineData("officials_aggregate", "TODO")]
		[InlineData("repmaint_aggregate", "TODO")]
		[InlineData("repmaint_v2_aggregate", "TODO")]
		[InlineData("uifwexp_aggregate", "TODO")]
		public async void HttpMembersDemarcation(string cubename, string cubemembername)
		{
			CubeMembersDemarcation.Request request = new(cubename, cubemembername);

			using HttpRequestMessage httprequestmessage = request.ToHttpRequestMessage();
			using HttpResponseMessage httpresponsemessage = await _HttpClient.SendAsync(httprequestmessage);

			string json = await httpresponsemessage.Content.ReadAsStringAsync();

			JObject.Parse(json).ToObject<CubeMembersDemarcation.Response>();
		}


		[Theory]
		[InlineData("aged_creditor_aggregate")]
		[InlineData("aged_creditor_v2_aggregate")]
		[InlineData("aged_debtor_aggregate")]
		[InlineData("aged_debtor_v2_aggregate")]
		[InlineData("audit_opinions_aggregate")]
		[InlineData("bsheet_aggregate")]
		[InlineData("capital_aggregate")]
		[InlineData("capital_v2_aggregate")]
		[InlineData("cflow_aggregate")]
		[InlineData("cflow_v2_aggregate")]
		[InlineData("conditional_grants_aggregate")]
		[InlineData("demarcation_changes_aggregate")]
		[InlineData("financial_position_v2_aggregate")]
		[InlineData("grants_v2_aggregate")]
		[InlineData("incexp_aggregate")]
		[InlineData("incexp_v2_aggregate")]
		[InlineData("municipalities_aggregate")]
		[InlineData("officials_aggregate")]
		[InlineData("repmaint_aggregate")]
		[InlineData("repmaint_v2_aggregate")]
		[InlineData("uifwexp_aggregate")]
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