
namespace XycloneDesigns.Apis.MunicipalMoney.Facts
{
	public interface ICapitalAcquisitionV2 : IFact 
	{
		string? Amount { get; set; }
        string? AmountTypeCode { get; set; }
        string? AmountTypeLabel { get; set; }
        string? CapitalTypeCode { get; set; }
        string? CapitalTypeLabel { get; set; }
        string? DemarcationCode { get; set; }
        string? DemarcationLabel { get; set; }
        int? FinancialYearEndYear { get; set; }
        int? FinancialPeriodPeriod { get; set; }
        string? FunctionCode { get; set; }
        string? FunctionLabel { get; set; }
        string? ItemCode { get; set; }
        string? ItemLabel { get; set; }
        string? PeriodLengthLength { get; set; }
	}
}