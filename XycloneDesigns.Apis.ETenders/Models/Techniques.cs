using Newtonsoft.Json;

using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class Techniques : Model
	{
		public class Json
		{
			public const string ElectronicAuction = "electronicAuction";
			public const string FrameworkAgreement = "frameworkAgreement";
			public const string HasElectronicAuction = "hasElectronicAuction";
			public const string HasFrameworkAgreement = "hasFrameworkAgreement";
		}

		[JsonProperty(Json.ElectronicAuction), JsonPropertyName(Json.ElectronicAuction)] public ElectronicAuction? ElectronicAuction { get; set; }
		[JsonProperty(Json.FrameworkAgreement), JsonPropertyName(Json.FrameworkAgreement)] public FrameworkAgreement? FrameworkAgreement { get; set; }
		[JsonProperty(Json.HasElectronicAuction), JsonPropertyName(Json.HasElectronicAuction)] public bool HasElectronicAuction { get; set; }
		[JsonProperty(Json.HasFrameworkAgreement), JsonPropertyName(Json.HasFrameworkAgreement)] public bool HasFrameworkAgreement { get; set; }
	}
}