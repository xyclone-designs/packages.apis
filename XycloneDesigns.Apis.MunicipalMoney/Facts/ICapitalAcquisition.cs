
namespace XycloneDesigns.Apis.MunicipalMoney.Facts
{
	public interface ICapitalAcquisition : IFact 
	{
		string? AmountTypeCode { get; set; }
        string? AmountTypeLabel { get; set; }
        string? DemarcationCode { get; set; }
        string? DemarcationLabel { get; set; }
        int? FinancialYearEndYear { get; set; }
        int? FinancialPeriodPeriod { get; set; }
        string? FunctionCode { get; set; }
        string? FunctionLabel { get; set; }
        string? ItemCode { get; set; }
        string? ItemLabel { get; set; }
        int? ItemPositionInReturnForm { get; set; }
        string? ItemReturnFormStructure { get; set; }
        string? ItemComposition { get; set; }
        string? PeriodLengthLength { get; set; }
        int? NewAssets { get; set; }
        int? RenewalOfExisting { get; set; }
        int? TotalAssets { get; set; }
        int? RepairsMaintenance { get; set; }
        int? AssetRegisterSummary { get; set; }
	}
}