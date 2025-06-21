
namespace XycloneDesigns.Apis.MunicipalMoney.Facts
{
	public interface IIncomeAndExpenditure : IFact 
	{
		int? Amount { get; set; }
        string? AmountTypeCode { get; set; }
        string? AmountTypeLabel { get; set; }
        string? DemarcationCode { get; set; }
        string? DemarcationLabel { get; set; }
        string? FunctionCode { get; set; }
        string? FunctionLabel { get; set; }
        string? FunctionCategoryLabel { get; set; }
        string? FunctionSubcategoryLabel { get; set; }
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