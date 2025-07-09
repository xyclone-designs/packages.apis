using Newtonsoft.Json;

using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.MunicipalMoney.Cubes.V1
{
	public class AuditOpinions : Cube
	{
		[JsonProperty(Keys.Demarcation.Code), JsonPropertyName(Keys.Demarcation.Code)] public string? DemarcationCode { get; set; }
		[JsonProperty(Keys.Demarcation.Label), JsonPropertyName(Keys.Demarcation.Label)] public string? DemarcationLabel { get; set; }
		[JsonProperty(Keys.FinancialYearEnd.Year), JsonPropertyName(Keys.FinancialYearEnd.Year)] public string? FinancialYearEndYear { get; set; }
		[JsonProperty(Keys.Opinion.AuditorGeneralsReportURL), JsonPropertyName(Keys.Opinion.AuditorGeneralsReportURL)] public string? OpinionAuditorGeneralsReportURL { get; set; }
		[JsonProperty(Keys.Opinion.Code), JsonPropertyName(Keys.Opinion.Code)] public string? OpinionCode { get; set; }
		[JsonProperty(Keys.Opinion.Label), JsonPropertyName(Keys.Opinion.Label)] public string? OpinionLabel { get; set; }
	}
}