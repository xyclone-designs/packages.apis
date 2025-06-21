
namespace XycloneDesigns.Apis.MunicipalMoney.Facts
{
	public interface IDemarcationChanges : IFact 
	{
		string? DateDate { get; set; }
		string? NewDemarcation { get; set; }
		string? NewCodeTransition { get; set; }
		string? OldDemarcation { get; set; }
		string? OldCodeTransition { get; set; }
	}
}