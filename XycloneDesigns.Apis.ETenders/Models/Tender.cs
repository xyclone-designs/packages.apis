using Newtonsoft.Json;

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class Tender : Model
	{
		public class Json
		{
			public const string AdditionalProcurementCategories = "additionalProcurementCategories";
			public const string AwardPeriod = "awardPeriod";
			public const string Classification = "classification";
			public const string Communication = "communication";
			public const string ContractPeriod = "contractPeriod";
			public const string ContractTerms = "contractTerms";
			public const string CoveredBy = "coveredBy";
			public const string Description = "description";
			public const string Documents = "documents";
			public const string EligibilityCriteria = "eligibilityCriteria";
			public const string EnquiryPeriod = "enquiryPeriod";
			public const string HasEnquiries = "hasEnquiries";
			public const string Id = "id";
			public const string Items = "items";
			public const string LegalBasis = "legalBasis";
			public const string Lots = "lots";
			public const string MainProcurementCategory = "mainProcurementCategory";
			public const string OtherRequirements = "otherRequirements";
			public const string ProcurementMethod = "procurementMethod";
			public const string ProcurementMethodDetails = "procurementMethodDetails";
			public const string ProcuringEntity = "procuringEntity";
			public const string ReviewDetails = "reviewDetails";
			public const string SelectionCriteria = "selectionCriteria";
			public const string Status = "status";
			public const string SubmissionMethod = "submissionMethod";
			public const string SubmissionMethodDetails = "submissionMethodDetails";
			public const string Techniques = "techniques";
			public const string Tenderers = "tenderers";
			public const string TenderPeriod = "tenderPeriod";
			public const string Title = "title";
			public const string Value = "value";
		}

		[JsonProperty(Json.AdditionalProcurementCategories), JsonPropertyName(Json.AdditionalProcurementCategories)] public List<string>? AdditionalProcurementCategories { get; set; }
		[JsonProperty(Json.AwardPeriod), JsonPropertyName(Json.AwardPeriod)] public AwardPeriod? AwardPeriod { get; set; }
        [JsonProperty(Json.Classification), JsonPropertyName(Json.Classification)] public Classification? Classification { get; set; }
        [JsonProperty(Json.Communication), JsonPropertyName(Json.Communication)] public Communication? Communication { get; set; }
        [JsonProperty(Json.ContractPeriod), JsonPropertyName(Json.ContractPeriod)] public TenderContractPeriod? ContractPeriod { get; set; }
        [JsonProperty(Json.ContractTerms), JsonPropertyName(Json.ContractTerms)] public ContractTerms? ContractTerms { get; set; }
		[JsonProperty(Json.CoveredBy), JsonPropertyName(Json.CoveredBy)] public List<string>? CoveredBy { get; set; }
		[JsonProperty(Json.Description), JsonPropertyName(Json.Description)] public string? Description { get; set; }
		[JsonProperty(Json.Documents), JsonPropertyName(Json.Documents)] public List<Document>? Documents { get; set; }
        [JsonProperty(Json.EligibilityCriteria), JsonPropertyName(Json.EligibilityCriteria)] public string? EligibilityCriteria { get; set; }
		[JsonProperty(Json.EnquiryPeriod), JsonPropertyName(Json.EnquiryPeriod)] public EnquiryPeriod? EnquiryPeriod { get; set; }
        [JsonProperty(Json.HasEnquiries), JsonPropertyName(Json.HasEnquiries)] public bool HasEnquiries { get; set; }
        [JsonProperty(Json.Id), JsonPropertyName(Json.Id)] public string? Id { get; set; }
        [JsonProperty(Json.Items), JsonPropertyName(Json.Items)] public List<TenderItem>? Items { get; set; }
        [JsonProperty(Json.LegalBasis), JsonPropertyName(Json.LegalBasis)] public string? LegalBasis { get; set; }
        [JsonProperty(Json.Lots), JsonPropertyName(Json.Lots)] public List<Lot>? Lots { get; set; }
        [JsonProperty(Json.MainProcurementCategory), JsonPropertyName(Json.MainProcurementCategory)] public string? MainProcurementCategory { get; set; }
		[JsonProperty(Json.OtherRequirements), JsonPropertyName(Json.OtherRequirements)] public OtherRequirements? OtherRequirements { get; set; }
        [JsonProperty(Json.ProcurementMethod), JsonPropertyName(Json.ProcurementMethod)] public string? ProcurementMethod { get; set; }
        [JsonProperty(Json.ProcurementMethodDetails), JsonPropertyName(Json.ProcurementMethodDetails)] public string? ProcurementMethodDetails { get; set; }
		[JsonProperty(Json.ProcuringEntity), JsonPropertyName(Json.ProcuringEntity)] public ProcuringEntity? ProcuringEntity { get; set; }
        [JsonProperty(Json.ReviewDetails), JsonPropertyName(Json.ReviewDetails)] public string? ReviewDetails { get; set; }
		[JsonProperty(Json.SelectionCriteria), JsonPropertyName(Json.SelectionCriteria)] public SelectionCriteria? SelectionCriteria { get; set; }
        [JsonProperty(Json.Status), JsonPropertyName(Json.Status)] public string? Status { get; set; }
        [JsonProperty(Json.SubmissionMethod), JsonPropertyName(Json.SubmissionMethod)] public List<string>? SubmissionMethod { get; set; }
        [JsonProperty(Json.SubmissionMethodDetails), JsonPropertyName(Json.SubmissionMethodDetails)] public string? SubmissionMethodDetails { get; set; }
		[JsonProperty(Json.Techniques), JsonPropertyName(Json.Techniques)] public Techniques? Techniques { get; set; }
        [JsonProperty(Json.Tenderers), JsonPropertyName(Json.Tenderers)] public List<Tenderers>? Tenderers { get; set; }
		[JsonProperty(Json.TenderPeriod), JsonPropertyName(Json.TenderPeriod)] public TenderPeriod? TenderPeriod { get; set; }
        [JsonProperty(Json.Title), JsonPropertyName(Json.Title)] public string? Title { get; set; }
		[JsonProperty(Json.Value), JsonPropertyName(Json.Value)] public Value? Value { get; set; }
    }
}
