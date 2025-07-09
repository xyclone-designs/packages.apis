
namespace XycloneDesigns.Apis.ETenders.Models
{
    public class Lot : Model 
    {
        public AwardCriteria? AwardCriteria { get; set; }
        public ContractPeriod? ContractPeriod { get; set; }
        public string? Description { get; set; }
		public bool HasOptions { get; set; }
		public bool HasRenewal { get; set; }
		public string? Id { get; set; }
        public Options? Options { get; set; }
		public Renewal? Renewal { get; set; }
		public SubmissionTerms? SubmissionTerms { get; set; }
		public string? Status { get; set; }
		public Value? Value { get; set; }
	}
}