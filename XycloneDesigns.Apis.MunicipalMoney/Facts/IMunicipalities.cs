
namespace XycloneDesigns.Apis.MunicipalMoney.Facts
{
	public interface IMunicipalities : IFact 
	{
		int? Area { get; set; }
        string? MunicipalityDemarcationCode { get; set; }
        string? MunicipalityCategory { get; set; }
        string? MunicipalityFaxNumber { get; set; }
        string? MunicipalityLongName { get; set; }
        string? MunicipalityMiifCategory { get; set; }
        string? MunicipalityName { get; set; }
        string? MunicipalityParentCode { get; set; }
        string? MunicipalityPhoneNumber { get; set; }
        string? MunicipalityProvinceCode { get; set; }
        string? MunicipalityProvinceName { get; set; }
        string? MunicipalityPostalAddress1 { get; set; }
        string? MunicipalityPostalAddress2 { get; set; }
        string? MunicipalityPostalAddress3 { get; set; }
        string? MunicipalityStreetAddress1 { get; set; }
        string? MunicipalityStreetAddress2 { get; set; }
        string? MunicipalityStreetAddress3 { get; set; }
        string? MunicipalityStreetAddress4 { get; set; }	
        string? MunicipalityUrl { get; set; }
	}
}