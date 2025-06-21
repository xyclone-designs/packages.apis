
namespace XycloneDesigns.Apis.MunicipalMoney.Facts
{
	public interface IMunicipalOfficials : IFact 
	{
		string? ContactDetailsEmailAddress { get; set; }
        string? ContactDetailsFaxNumber { get; set; }
        string? ContactDetailsName { get; set; }
        string? ContactDetailsPhoneNumber { get; set; }
        string? ContactDetailsTitle { get; set; }
        string? MunicipalityDemarcationCode { get; set; }
        string? RoleRole { get; set; }
	}
}