using Newtonsoft.Json;

using System.Collections.Generic;
using System.Linq;
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

		public static IEnumerable<string> KeysEnumerable
		{
			get => Enumerable.Empty<string>()
				.Append(Keys.Demarcation.Code)
				.Append(Keys.Demarcation.Label)
				.Append(Keys.FinancialYearEnd.Year)
				.Append(Keys.Opinion.AuditorGeneralsReportURL)
				.Append(Keys.Opinion.Code)
				.Append(Keys.Opinion.Label);
		}
	}
}