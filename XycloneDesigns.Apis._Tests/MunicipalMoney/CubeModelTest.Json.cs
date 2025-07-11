using Newtonsoft.Json.Linq;

using System.IO;

using Xunit;

using XycloneDesigns.Apis.MunicipalMoney.Http.Rest;

namespace XycloneDesigns.Apis._Tests.MunicipalMoney
{
	public partial class CubeModelTest
	{
		[Theory]
		[InlineData("aged_creditor_aggregate.json")]
		[InlineData("aged_creditor_v2_aggregate.json")]
		[InlineData("aged_debtor_aggregate.json")]
		[InlineData("aged_debtor_v2_aggregate.json")]
		[InlineData("audit_opinions_aggregate.json")]
		[InlineData("bsheet_aggregate.json")]
		[InlineData("capital_aggregate.json")]
		[InlineData("capital_v2_aggregate.json")]
		[InlineData("cflow_aggregate.json")]
		[InlineData("cflow_v2_aggregate.json")]
		[InlineData("conditional_grants_aggregate.json")]
		[InlineData("demarcation_changes_aggregate.json")]
		[InlineData("financial_position_v2_aggregate.json")]
		[InlineData("grants_v2_aggregate.json")]
		[InlineData("incexp_aggregate.json")]
		[InlineData("incexp_v2_aggregate.json")]
		[InlineData("municipalities_aggregate.json")]
		[InlineData("officials_aggregate.json")]
		[InlineData("repmaint_aggregate.json")]
		[InlineData("repmaint_v2_aggregate.json")]
		[InlineData("uifwexp_aggregate.json")]
		public async void JsonAggregate(string file)
		{
			string filepath = Path.Combine(Globals.CurrentDirectory, "MunicipalMoney", "datas", file);

			using FileStream filestream = File.OpenRead(filepath);
			using StreamReader streamreader = new (filestream);

			string json = await streamreader.ReadToEndAsync();

			JObject.Parse(json).ToObject<CubeAggregate.Response>();
		}


		[Theory]
		[InlineData("aged_creditor_facts.json")]
		[InlineData("aged_creditor_v2_facts.json")]
		[InlineData("aged_debtor_facts.json")]
		[InlineData("aged_debtor_v2_facts.json")]
		[InlineData("audit_opinions_facts.json")]
		[InlineData("bsheet_facts.json")]
		[InlineData("capital_facts.json")]
		[InlineData("capital_v2_facts.json")]
		[InlineData("cflow_facts.json")]
		[InlineData("cflow_v2_facts.json")]
		[InlineData("conditional_grants_facts.json")]
		[InlineData("demarcation_changes_facts.json")]
		[InlineData("financial_position_v2_facts.json")]
		[InlineData("grants_v2_facts.json")]
		[InlineData("incexp_facts.json")]
		[InlineData("incexp_v2_facts.json")]
		[InlineData("municipalities_facts.json")]
		[InlineData("officials_facts.json")]
		[InlineData("repmaint_facts.json")]
		[InlineData("repmaint_v2_facts.json")]
		[InlineData("uifwexp_facts.json")]
		public async void JsonFact(string file)
		{
			string filepath = Path.Combine(Globals.CurrentDirectory, "MunicipalMoney", "datas", file);

			using FileStream filestream = File.OpenRead(filepath);
			using StreamReader streamreader = new(filestream);

			string json = await streamreader.ReadToEndAsync();

			JObject.Parse(json).ToObject<CubeFacts.Response>();
		}


		[Theory]
		[InlineData("aged_creditor_demarcation.json")]
		public async void JsonMembersDemarcation(string file)
		{
			string filepath = Path.Combine(Globals.CurrentDirectory, "MunicipalMoney", "datas", file);

			using FileStream filestream = File.OpenRead(filepath);
			using StreamReader streamreader = new(filestream);

			string json = await streamreader.ReadToEndAsync();

			JObject.Parse(json).ToObject<CubeMembersDemarcation.Response>();
		}


		[Theory]
		[InlineData("aged_creditor_model.json")]
		[InlineData("aged_creditor_v2_model.json")]
		[InlineData("aged_debtor_model.json")]
		[InlineData("aged_debtor_v2_model.json")]
		[InlineData("audit_opinions_model.json")]
		[InlineData("bsheet_model.json")]
		[InlineData("capital_model.json")]
		[InlineData("capital_v2_model.json")]
		[InlineData("cflow_model.json")]
		[InlineData("cflow_v2_model.json")]
		[InlineData("conditional_grants_model.json")]
		[InlineData("demarcation_changes_model.json")]
		[InlineData("financial_position_v2_model.json")]
		[InlineData("grants_v2_model.json")]
		[InlineData("incexp_model.json")]
		[InlineData("incexp_v2_model.json")]
		[InlineData("municipalities_model.json")]
		[InlineData("officials_model.json")]
		[InlineData("repmaint_model.json")]
		[InlineData("repmaint_v2_model.json")]
		[InlineData("uifwexp_model.json")]
		public async void JsonModel(string file)
		{
			string filepath = Path.Combine(Globals.CurrentDirectory, "MunicipalMoney", "datas", file);

			using FileStream filestream = File.OpenRead(filepath);
			using StreamReader streamreader = new(filestream);

			string json = await streamreader.ReadToEndAsync();

			JObject.Parse(json).ToObject<CubeModel.Response>();
		}
	}
}