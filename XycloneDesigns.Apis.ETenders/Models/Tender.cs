using System.Collections.Generic;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class Tender : Model 
    {
        public List<string>? AdditionalProcurementCategories { get; set; }
        public AwardPeriod? AwardPeriod { get; set; }
        public Classification? Classification { get; set; }
        public Communication? Communication { get; set; }
        public TenderContractPeriod? ContractPeriod { get; set; }
        public ContractTerms? ContractTerms { get; set; }
		public List<string>? CoveredBy { get; set; }
		public string? Description { get; set; }
		public List<Document>? Documents { get; set; }
        public string? EligibilityCriteria { get; set; }
        public EnquiryPeriod? EnquiryPeriod { get; set; }
        public bool HasEnquiries { get; set; }
        public string? Id { get; set; }
        public List<TenderItem>? Items { get; set; }
        public string? LegalBasis { get; set; }
        public List<Lot>? Lots { get; set; }
        public string? MainProcurementCategory { get; set; }
        public OtherRequirements? OtherRequirements { get; set; }
        public string? ProcurementMethod { get; set; }
        public string? ProcurementMethodDetails { get; set; }
        public ProcuringEntity? ProcuringEntity { get; set; }
        public string? ReviewDetails { get; set; }
        public SelectionCriteria? SelectionCriteria { get; set; }
        public string? Status { get; set; }
        public List<string>? SubmissionMethod { get; set; }
        public string? SubmissionMethodDetails { get; set; }
        public Techniques? Techniques { get; set; }
        public List<Tenderers>? Tenderers { get; set; }
        public TenderPeriod? TenderPeriod { get; set; }
        public string? Title { get; set; }
        public Value? Value { get; set; }
    }
}
