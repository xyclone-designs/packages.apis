using Newtonsoft.Json;

using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.MunicipalMoney.Cubes.V1
{
	public class MunicipalOfficials : Cube
	{
		[JsonProperty(Keys.Municipality.DemarcationCode), JsonPropertyName(Keys.Municipality.DemarcationCode)] public string? DemarcationCode { get; set; }
		[JsonProperty(Keys.ContactDetails.EmailAddress), JsonPropertyName(Keys.ContactDetails.EmailAddress)] public string? EmailAddress { get; set; }
		[JsonProperty(Keys.ContactDetails.FaxNumber), JsonPropertyName(Keys.ContactDetails.FaxNumber)] public string? FaxNumber { get; set; }
		[JsonProperty(Keys.ContactDetails.Name), JsonPropertyName(Keys.ContactDetails.Name)] public string? Name { get; set; }
		[JsonProperty(Keys.ContactDetails.PhoneNumber), JsonPropertyName(Keys.ContactDetails.PhoneNumber)] public string? PhoneNumber { get; set; }
		[JsonProperty(Keys.Roles.Role), JsonPropertyName(Keys.Roles.Role)] public string? Role { get; set; }
		[JsonProperty(Keys.ContactDetails.Title), JsonPropertyName(Keys.ContactDetails.Title)] public string? Title { get; set; }
	}
}