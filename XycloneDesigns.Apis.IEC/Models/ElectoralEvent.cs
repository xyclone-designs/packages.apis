using System;
using System.Collections.Generic;

using XycloneDesigns.Apis.General.Models;

namespace XycloneDesigns.Apis.IEC.Models
{
	public partial class ElectoralEvent : Model
	{
		public string? Abbr { get; set; }
		public DateTime? Date { get; set; }
		public List<Ballot>? Ballots { get; set; }
        public ListPairs<Municipality, Party>? MunicipalityParties { get; set; }
        public string? Name { get; set; }
		public ListTriplets<Party, string, int>? PartyNationalAllocations { get; set; }
		public ListTriplets<Party, string, int>? PartyProvincialAllocations { get; set; }
		public ListTriplets<Party, string, int>? PartyRegionalAllocations { get; set; }
		public string? Type { get; set; }
	}
}