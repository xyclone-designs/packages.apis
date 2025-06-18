using System;

using XycloneDesigns.Apis.STATSSA.Enums;
using XycloneDesigns.Apis.STATSSA.Structs;

namespace XycloneDesigns.Apis.STATSSA.Models
{
    public class RecordMortality : Record
	{
		public Uncertain<int>? AgeOfDeceased { get; set; }		
		public Uncertain<bool>? AnybodyDied { get; set; }
		public DateTime? DateOfDeath { get; set; }
		public Uncertain<Sexes>? Gender { get; set; }
		public Uncertain<int>? HowManyDied { get; set; }
		public Uncertain<ImputationFlags>? ImputationFlags { get; set; }
		public Uncertain<bool>? WasDeathFromViolence { get; set; }
		public Uncertain<bool>? WasPregnantWhenDeceased { get; set; }
	}
}