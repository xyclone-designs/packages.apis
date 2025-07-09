using Newtonsoft.Json;

using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.MunicipalMoney.Cubes.V1
{
	public class Capital : Cube
	{
		[JsonProperty(Keys.AmountType.Code), JsonPropertyName(Keys.AmountType.Code)] public string? AmountTypeCode { get; set; }
		[JsonProperty(Keys.AmountType.Label), JsonPropertyName(Keys.AmountType.Label)] public string? AmountTypeLabel { get; set; }
		[JsonProperty(Keys.CustomerGroup.Code), JsonPropertyName(Keys.CustomerGroup.Code)] public string? CustomerGroupCode { get; set; }
		[JsonProperty(Keys.Dates.Date), JsonPropertyName(Keys.Dates.Date)] public string? DatesDate { get; set; }
		[JsonProperty(Keys.Demarcation.Code), JsonPropertyName(Keys.Demarcation.Code)] public string? DemarcationCode { get; set; }
		[JsonProperty(Keys.Demarcation.CodeNew), JsonPropertyName(Keys.Demarcation.CodeNew)] public string? DemarcationCodeNew { get; set; }
		[JsonProperty(Keys.Demarcation.CodeOld), JsonPropertyName(Keys.Demarcation.CodeOld)] public string? DemarcationCodeOld { get; set; }
		[JsonProperty(Keys.Demarcation.CodeTransitionNew), JsonPropertyName(Keys.Demarcation.CodeTransitionNew)] public string? DemarcationCodeTransitionNew { get; set; }
		[JsonProperty(Keys.Demarcation.CodeTransitionOld), JsonPropertyName(Keys.Demarcation.CodeTransitionOld)] public string? DemarcationCodeTransitionOld { get; set; }
		[JsonProperty(Keys.Demarcation.Label), JsonPropertyName(Keys.Demarcation.Label)] public string? DemarcationLabel { get; set; }
		[JsonProperty(Keys.FinancialPeriod.Period), JsonPropertyName(Keys.FinancialPeriod.Period)] public string? FinancialPeriodPeriod { get; set; }
		[JsonProperty(Keys.FinancialYearEnd.Year), JsonPropertyName(Keys.FinancialYearEnd.Year)] public string? FinancialYearEndYear { get; set; }
		[JsonProperty(Keys.Function.CategoryLabel), JsonPropertyName(Keys.Function.CategoryLabel)] public string? FunctionCategoryLabel { get; set; }
		[JsonProperty(Keys.Function.Code), JsonPropertyName(Keys.Function.Code)] public string? FunctionCode { get; set; }
		[JsonProperty(Keys.Function.Label), JsonPropertyName(Keys.Function.Label)] public string? FunctionLabel { get; set; }
		[JsonProperty(Keys.Function.SubcategoryLabel), JsonPropertyName(Keys.Function.SubcategoryLabel)] public string? FunctionSubcategoryLabel { get; set; }
		[JsonProperty(Keys.Grant.Code), JsonPropertyName(Keys.Grant.Code)] public string? GrantCode { get; set; }
		[JsonProperty(Keys.Grant.Label), JsonPropertyName(Keys.Grant.Label)] public string? GrantLabel { get; set; }
		[JsonProperty(Keys.Item.Code), JsonPropertyName(Keys.Item.Code)] public string? ItemCode { get; set; }
		[JsonProperty(Keys.Item.Composition), JsonPropertyName(Keys.Item.Composition)] public string? ItemComposition { get; set; }
		[JsonProperty(Keys.Item.Label), JsonPropertyName(Keys.Item.Label)] public string? ItemLabel { get; set; }
		[JsonProperty(Keys.Item.PositionInReturnForm), JsonPropertyName(Keys.Item.PositionInReturnForm)] public string? ItemPositionInReturnForm { get; set; }
		[JsonProperty(Keys.Item.ReturnFormStructure), JsonPropertyName(Keys.Item.ReturnFormStructure)] public string? ItemReturnFormStructure { get; set; }
		[JsonProperty(Keys.Opinion.AuditorGeneralsReportURL), JsonPropertyName(Keys.Opinion.AuditorGeneralsReportURL)] public string? OpinionAuditorGeneralsReportURL { get; set; }
		[JsonProperty(Keys.Opinion.Code), JsonPropertyName(Keys.Opinion.Code)] public string? OpinionCode { get; set; }
		[JsonProperty(Keys.Opinion.Label), JsonPropertyName(Keys.Opinion.Label)] public string? OpinionLabel { get; set; }
		[JsonProperty(Keys.PeriodLength.Length), JsonPropertyName(Keys.PeriodLength.Length)] public string? PeriodLength { get; set; }
		[JsonProperty(Keys.Roles.Role), JsonPropertyName(Keys.Roles.Role)] public string? RolesRole { get; set; }
	}
}