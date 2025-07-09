using Newtonsoft.Json;

using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.MunicipalMoney.Cubes.V2
{
	public class Grants : Cube
	{
		[JsonProperty(Keys.AmountType.Code), JsonPropertyName(Keys.AmountType.Code)] public string? AmountTypeCode { get; set; }
		[JsonProperty(Keys.AmountType.Label), JsonPropertyName(Keys.AmountType.Label)] public string? AmountTypeLabel { get; set; }
		[JsonProperty(Keys.Demarcation.Code), JsonPropertyName(Keys.Demarcation.Code)] public string? DemarcationCode { get; set; }
		[JsonProperty(Keys.Demarcation.Label), JsonPropertyName(Keys.Demarcation.Label)] public string? DemarcationLabel { get; set; }
		[JsonProperty(Keys.FinancialPeriod.Period), JsonPropertyName(Keys.FinancialPeriod.Period)] public string? FinancialPeriodPeriod { get; set; }
		[JsonProperty(Keys.FinancialYearEnd.Year), JsonPropertyName(Keys.FinancialYearEnd.Year)] public string? FinancialYearEndYear { get; set; }
		[JsonProperty(Keys.Grant.Code), JsonPropertyName(Keys.Grant.Code)] public string? GrantCode { get; set; }
		[JsonProperty(Keys.Grant.Label), JsonPropertyName(Keys.Grant.Label)] public string? GrantLabel { get; set; }
		[JsonProperty(Keys.PeriodLength.Length), JsonPropertyName(Keys.PeriodLength.Length)] public string? PeriodLength { get; set; }
	}
}