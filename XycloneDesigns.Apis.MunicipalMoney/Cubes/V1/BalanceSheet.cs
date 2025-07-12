using Newtonsoft.Json;

using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.MunicipalMoney.Cubes.V1
{
	public class BalanceSheet : Cube
	{
		[JsonProperty(Keys.AmountType.Code), JsonPropertyName(Keys.AmountType.Code)] public string? AmountTypeCode { get; set; }
		[JsonProperty(Keys.AmountType.Label), JsonPropertyName(Keys.AmountType.Label)] public string? AmountTypeLabel { get; set; }
		[JsonProperty(Keys.Demarcation.Code), JsonPropertyName(Keys.Demarcation.Code)] public string? DemarcationCode { get; set; }
		[JsonProperty(Keys.Demarcation.Label), JsonPropertyName(Keys.Demarcation.Label)] public string? DemarcationLabel { get; set; }
		[JsonProperty(Keys.FinancialPeriod.Period), JsonPropertyName(Keys.FinancialPeriod.Period)] public string? FinancialPeriodPeriod { get; set; }
		[JsonProperty(Keys.FinancialYearEnd.Year), JsonPropertyName(Keys.FinancialYearEnd.Year)] public string? FinancialYearEndYear { get; set; }
		[JsonProperty(Keys.Function.Code), JsonPropertyName(Keys.Function.Code)] public string? FunctionCode { get; set; }
		[JsonProperty(Keys.Function.Label), JsonPropertyName(Keys.Function.Label)] public string? FunctionLabel { get; set; }
		[JsonProperty(Keys.Item.Code), JsonPropertyName(Keys.Item.Code)] public string? ItemCode { get; set; }
		[JsonProperty(Keys.Item.Composition), JsonPropertyName(Keys.Item.Composition)] public string? ItemComposition { get; set; }
		[JsonProperty(Keys.Item.Label), JsonPropertyName(Keys.Item.Label)] public string? ItemLabel { get; set; }
		[JsonProperty(Keys.Item.PositionInReturnForm), JsonPropertyName(Keys.Item.PositionInReturnForm)] public string? ItemPositionInReturnForm { get; set; }
		[JsonProperty(Keys.Item.ReturnFormStructure), JsonPropertyName(Keys.Item.ReturnFormStructure)] public string? ItemReturnFormStructure { get; set; }
		[JsonProperty(Keys.PeriodLength.Length), JsonPropertyName(Keys.PeriodLength.Length)] public string? PeriodLength { get; set; }

		public static IEnumerable<string> KeysEnumerable
		{
			get => Enumerable.Empty<string>()
				.Append(Keys.AmountType.Code)
				.Append(Keys.AmountType.Label)
				.Append(Keys.Demarcation.Code)
				.Append(Keys.Demarcation.Label)
				.Append(Keys.FinancialPeriod.Period)
				.Append(Keys.FinancialYearEnd.Year)
				.Append(Keys.Function.Code)
				.Append(Keys.Function.Label)
				.Append(Keys.Item.Code)
				.Append(Keys.Item.Composition)
				.Append(Keys.Item.Label)
				.Append(Keys.Item.PositionInReturnForm)
				.Append(Keys.Item.ReturnFormStructure)
				.Append(Keys.PeriodLength.Length);
		}
	}
}