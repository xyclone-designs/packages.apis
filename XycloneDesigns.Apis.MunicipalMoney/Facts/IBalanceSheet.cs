
namespace XycloneDesigns.Apis.MunicipalMoney.Facts
{
	public interface IBalanceSheet : IFact 
	{
		string? Amount { get; set; }
        string? AmountTypeCode { get; set; }
        string? AmountTypeLabel { get; set; }
        string? DemarcationCode { get; set; }
        string? DemarcationLabel { get; set; }
        string? FinancialYearEndYear { get; set; }
        string? FinancialPeriodPeriod { get; set; }
        string? ItemCode { get; set; }
        string? ItemLabel { get; set; }
        string? ItemPositionInReturnForm { get; set; }
        string? ItemReturnFormStructure { get; set; }
        string? ItemComposition { get; set; }
        string? PeriodLengthLength { get; set; }
	}
}