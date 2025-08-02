using System.Net.Http;

using Xunit;

using XycloneDesigns.Apis.MunicipalMoney.Cubes;
using XycloneDesigns.Apis.MunicipalMoney.Http.Models;
using XycloneDesigns.Apis.MunicipalMoney.Http.Rest;

namespace XycloneDesigns.Apis._Tests.MunicipalMoney
{
	public partial class UriTests
	{
		[Fact] public void _Aggregate()
		{
			AggregateRest.Request request = new(Cube.Names.IncomeAndExpenditure)
			{
				Aggregates = 
				[
					new Aggregate("amount", Aggregate.Operation_Sum)   // amount.sum
				],
				Drilldown =											
				[
					new Drilldown(Cube.Keys.Demarcation.Code),			// demarcation.code
					new Drilldown(Cube.Keys.Demarcation.Label),         // demarcation.label		
					new Drilldown(Cube.Keys.Item.Code),                 // item.code
					new Drilldown(Cube.Keys.Item.Label),				// item.label
					new Drilldown(Cube.Keys.Item.ReturnFormStructure),	// item.return_form_structure
				],
				Cut = 
				[
					new Cut(Cube.Keys.FinancialYearEnd.Year, 2015),     // financial_year_end.year:2015
					new Cut(Cube.Keys.AmountType.Code, "AUDA"),         // amount_type.code:AUDA
					new Cut(Cube.Keys.FinancialPeriod.Period, 2015),    // financial_period.period:2015
					new Cut(Cube.Keys.Demarcation.Code, "TSH"),         // demarcation.code:TSH
				],
			};

			using HttpRequestMessage httprequestmessage = request.ToHttpRequestMessage();

			Assert.Equal(
				$"https://municipaldata.treasury.gov.za/api/cubes/incexp/aggregate" +
				"?aggregates=amount.sum" +
				"&cut=financial_year_end.year:2015|amount_type.code:AUDA|financial_period.period:2015|demarcation.code:TSH" +
				"&drilldown=demarcation.code|demarcation.label|item.code|item.label|item.return_form_structure", 
				httprequestmessage.RequestUri?.ToString());
		}
	}
}