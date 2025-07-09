using System;
using System.Collections.Generic;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class Contract : Model
	{
		public string? AwardID { get; set; }
		public DateTime? DateSigned { get; set; }
		public string? Description { get; set; }
		public List<Document>? Documents { get; set; }
		public string? Id { get; set; }
		public Implementation? Implementation { get; set; }
		public List<Milestone>? Milestones { get; set; }
		public Period? Period { get; set; }
		public List<RelatedProcess>? RelatedProcesses { get; set; }
		public string? Status { get; set; }
		public string? Title { get; set; }
        public Value? Value { get; set; }
	}
}