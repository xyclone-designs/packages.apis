using Newtonsoft.Json;

using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.MunicipalMoney.Cubes.V1
{
	public class Municipalities : Cube
	{
		[JsonProperty(Keys.Municipality.Category), JsonPropertyName(Keys.Municipality.Category)] public string? Category { get; set; }
		[JsonProperty(Keys.Municipality.DemarcationCode), JsonPropertyName(Keys.Municipality.DemarcationCode)] public string? DemarcationCode { get; set; }
		[JsonProperty(Keys.Municipality.FaxNumber), JsonPropertyName(Keys.Municipality.FaxNumber)] public string? FaxNumber { get; set; }
		[JsonProperty(Keys.Municipality.LongName), JsonPropertyName(Keys.Municipality.LongName)] public string? LongName { get; set; }
		[JsonProperty(Keys.Municipality.MIIFCategory), JsonPropertyName(Keys.Municipality.MIIFCategory)] public string? MIIFCategory { get; set; }
		[JsonProperty(Keys.Municipality.Name), JsonPropertyName(Keys.Municipality.Name)] public string? Name { get; set; }
		[JsonProperty(Keys.Municipality.ParentMunicipalityCode), JsonPropertyName(Keys.Municipality.ParentMunicipalityCode)] public string? ParentMunicipalityCode { get; set; }
		[JsonProperty(Keys.Municipality.PhoneNumber), JsonPropertyName(Keys.Municipality.PhoneNumber)] public string? PhoneNumber { get; set; }
		[JsonProperty(Keys.Municipality.PostalAddressPart1), JsonPropertyName(Keys.Municipality.PostalAddressPart1)] public string? PostalAddressPart1 { get; set; }
		[JsonProperty(Keys.Municipality.PostalAddressPart2), JsonPropertyName(Keys.Municipality.PostalAddressPart2)] public string? PostalAddressPart2 { get; set; }
		[JsonProperty(Keys.Municipality.PostalAddressPart3), JsonPropertyName(Keys.Municipality.PostalAddressPart3)] public string? PostalAddressPart3 { get; set; }
		[JsonProperty(Keys.Municipality.ProvinceCode), JsonPropertyName(Keys.Municipality.ProvinceCode)] public string? ProvinceCode { get; set; }
		[JsonProperty(Keys.Municipality.ProvinceName), JsonPropertyName(Keys.Municipality.ProvinceName)] public string? ProvinceName { get; set; }
		[JsonProperty(Keys.Municipality.StreetAddressPart1), JsonPropertyName(Keys.Municipality.StreetAddressPart1)] public string? StreetAddressPart1 { get; set; }
		[JsonProperty(Keys.Municipality.StreetAddressPart2), JsonPropertyName(Keys.Municipality.StreetAddressPart2)] public string? StreetAddressPart2 { get; set; }
		[JsonProperty(Keys.Municipality.StreetAddressPart3), JsonPropertyName(Keys.Municipality.StreetAddressPart3)] public string? StreetAddressPart3 { get; set; }
		[JsonProperty(Keys.Municipality.StreetAddressPart4), JsonPropertyName(Keys.Municipality.StreetAddressPart4)] public string? StreetAddressPart4 { get; set; }
		[JsonProperty(Keys.Municipality.Url), JsonPropertyName(Keys.Municipality.Url)] public string? Url { get; set; }

		public static IEnumerable<string> KeysEnumerable
		{
			get => Enumerable.Empty<string>()
				.Append(Keys.Municipality.Category)
				.Append(Keys.Municipality.DemarcationCode)
				.Append(Keys.Municipality.FaxNumber)
				.Append(Keys.Municipality.LongName)
				.Append(Keys.Municipality.MIIFCategory)
				.Append(Keys.Municipality.Name)
				.Append(Keys.Municipality.ParentMunicipalityCode)
				.Append(Keys.Municipality.PhoneNumber)
				.Append(Keys.Municipality.PostalAddressPart1)
				.Append(Keys.Municipality.PostalAddressPart2)
				.Append(Keys.Municipality.PostalAddressPart3)
				.Append(Keys.Municipality.ProvinceCode)
				.Append(Keys.Municipality.ProvinceName)
				.Append(Keys.Municipality.StreetAddressPart1)
				.Append(Keys.Municipality.StreetAddressPart2)
				.Append(Keys.Municipality.StreetAddressPart3)
				.Append(Keys.Municipality.StreetAddressPart4)
				.Append(Keys.Municipality.Url);
		}
	}
}