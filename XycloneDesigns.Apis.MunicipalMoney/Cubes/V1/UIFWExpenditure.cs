using Newtonsoft.Json;

using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.MunicipalMoney.Cubes.V1
{
	public class UIFWExpenditure : Cube
	{
		[JsonProperty(Keys.Demarcation.Code), JsonPropertyName(Keys.Demarcation.Code)] public string? DemarcationCode { get; set; }
		[JsonProperty(Keys.Demarcation.Label), JsonPropertyName(Keys.Demarcation.Label)] public string? DemarcationLabel { get; set; }
		[JsonProperty(Keys.FinancialYearEnd.Year), JsonPropertyName(Keys.FinancialYearEnd.Year)] public string? FinancialYearEndYear { get; set; }
		[JsonProperty(Keys.Item.Code), JsonPropertyName(Keys.Item.Code)] public string? ItemCode { get; set; }
		[JsonProperty(Keys.Item.Label), JsonPropertyName(Keys.Item.Label)] public string? ItemLabel { get; set; }
	}
}