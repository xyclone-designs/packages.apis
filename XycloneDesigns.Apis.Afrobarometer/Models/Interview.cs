using System.Collections.Generic;

using XycloneDesigns.Apis.Afrobarometer.Enums;
using XycloneDesigns.Apis.General.Models;

namespace XycloneDesigns.Apis.Afrobarometer.Models
{
	public class Interview : Model
	{
		public ListPairs<Variable, int>? VariableRecords { get; set; }
		public Language? Language { get; set; }
		public Survey? Survey { get; set; }
		public Rounds? Round { get; set; }
	}
}