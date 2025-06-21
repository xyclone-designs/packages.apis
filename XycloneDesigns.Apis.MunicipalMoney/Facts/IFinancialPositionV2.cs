
namespace XycloneDesigns.Apis.MunicipalMoney.Facts
{
	public interface IFinancialPositionV2 : IFact 
	{
		int? Amount { get; set; }
        string? AmountTypeCode { get; set; }
        string? AmountTypeLabel { get; set; }
        string? DemarcationCode { get; set; }
        string? DemarcationLabel { get; set; }
        int? FinancialYearEndYear { get; set; }
        int? FinancialPeriodPeriod { get; set; }
        string? ItemCode { get; set; }
        string? ItemLabel { get; set; }
        string? ItemComposition { get; set; }
        int? ItemPositionInReturnForm { get; set; }
        string? ItemReturnFormStructure { get; set; }
        string? PeriodLengthLength { get; set; }
	}
}