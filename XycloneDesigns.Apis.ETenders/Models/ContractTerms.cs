using Newtonsoft.Json;

using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class ContractTerms : Model
	{
		public class Json
		{
			public const string ElectronicInvoicingPolicy = "electronicInvoicingPolicy";
			public const string HasElectronicOrdering = "hasElectronicOrdering";
			public const string HasElectronicPayment = "hasElectronicPayment";
			public const string PerformanceTerms = "performanceTerms";
			public const string ReservedExecution = "reservedExecution";
		}

		[JsonProperty(Json.ElectronicInvoicingPolicy), JsonPropertyName(Json.ElectronicInvoicingPolicy)] public string? ElectronicInvoicingPolicy { get; set; }
		[JsonProperty(Json.HasElectronicOrdering), JsonPropertyName(Json.HasElectronicOrdering)] public bool HasElectronicOrdering { get; set; }
        [JsonProperty(Json.HasElectronicPayment), JsonPropertyName(Json.HasElectronicPayment)] public bool HasElectronicPayment { get; set; }
        [JsonProperty(Json.PerformanceTerms), JsonPropertyName(Json.PerformanceTerms)] public string? PerformanceTerms { get; set; }
		[JsonProperty(Json.ReservedExecution), JsonPropertyName(Json.ReservedExecution)] public bool ReservedExecution { get; set; }
    }
}