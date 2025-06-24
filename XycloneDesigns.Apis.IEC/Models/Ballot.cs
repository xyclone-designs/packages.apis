using System.Collections.Generic;
using System;

using XycloneDesigns.Apis.General.Models;

namespace XycloneDesigns.Apis.IEC.Models
{
	public partial class Ballot : Model
	{
		public ElectoralEvent? ElectoralEvent { get; set; }
        public Municipality? Municipality { get; set; }
		public ListPairs<Party, int>? PartyVotes { get; set; }
		public ListPairs<Party, int>? PartySeats { get; set; }
		public Province? Province { get; set; }
		public string? Type { get; set; }
		public int? VotersRegistered { get; set; }
		public int? VotesMEC7 { get; set; }
		public int? VotesSection24A { get; set; }
		public int? VotesSpecial { get; set; }
		public int? VotesSpoilt { get; set; }
		public int? VotesTotal { get; set; }
		public int? VotesValid { get; set; }
		public VotingDistrict? VotingDistrict { get; set; }
        public Ward? Ward { get; set; }
	}
}