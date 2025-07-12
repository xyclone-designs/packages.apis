using Newtonsoft.Json;

using System.Collections.Generic;
using System.Linq;
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

		public static IEnumerable<string> KeysEnumerable
		{
			get => Enumerable.Empty<string>()
				.Append(Keys.Demarcation.Code)
				.Append(Keys.Demarcation.Label)
				.Append(Keys.FinancialYearEnd.Year)
				.Append(Keys.Item.Code)
				.Append(Keys.Item.Label);
		}
	}
}