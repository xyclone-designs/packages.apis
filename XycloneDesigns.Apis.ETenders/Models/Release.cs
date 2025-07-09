using System;
using System.Collections.Generic;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class Release : Model
	{
		public List<Award>? Awards { get; set; }
		public Buyer? Buyer { get; set; }
		public List<Contract>? Contracts { get; set; }
		public DateTime? Date { get; set; }
		public string? Description { get; set; }
		public string? Id { get; set; }
		public string? InitiationType { get; set; }
		public string? Language { get; set; }
		public string? Ocid { get; set; }
		public List<Party>? Parties { get; set; }
		public Planning? Planning { get; set; }
		public string? RelatedProcesses { get; set; }
		public List<string>? Tag { get; set; }
		public Tender? Tender { get; set; }
	}
}