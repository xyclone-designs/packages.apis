
namespace XycloneDesigns.Apis.MunicipalMoney.Facts
{
	public interface IUIFWExpenditure : IFact 
	{
		int? Amount { get; set; }
        string? DemarcationCode { get; set; }
        string? DemarcationLabel { get; set; }
        string? ItemCode { get; set; }
        string? ItemLabel { get; set; }
        string? FinancialYearEndYear { get; set; }
	}
}