using System.Collections.Generic;

using XycloneDesigns.Apis.General.Models;

namespace XycloneDesigns.Apis.IEC.Models
{
	public partial class Province : General.Models.Province
	{
		public List<Ballot>? Ballots { get; set; }
		public List<District>? Districts { get; set; }
		public List<ElectoralEvent>? ElectoralEvents { get; set; }
		public List<Municipality>? Municipalities { get; set; }
		public List<VotingDistrict>? VotingDistricts { get; set; }
		public List<Ward>? Wards { get; set; }
	}
}