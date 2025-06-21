
namespace XycloneDesigns.Apis.MunicipalMoney.Facts
{
	public interface IConditionalGrants : IFact 
	{
		int? Amount { get; set; }
        string? AmountTypeCode { get; set; }
        string? AmountTypeLabel { get; set; }
        string? DemarcationCode { get; set; }
        string? DemarcationLabel { get; set; }
        int? FinancialYearEndYear { get; set; }
        int? FinancialPeriodPeriod { get; set; }
        string? GrantCode { get; set; }
        string? GrantLabel { get; set; }
        string? PeriodLengthLength { get; set; }
	}
}