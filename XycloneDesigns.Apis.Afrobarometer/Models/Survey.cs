using System.Collections.Generic;

using XycloneDesigns.Apis.General.Models;
using XycloneDesigns.Apis.Afrobarometer.Enums;

namespace XycloneDesigns.Apis.Afrobarometer.Models
{
    public class Survey : Model
	{
		public int? InterviewCount { get; set; }
		public List<Question>? Questions { get; set; }
		public List<Variable>? Variables { get; set; }
		public Country? Country { get; set; }
		public Language? Language { get; set; }
		public Rounds? Round { get; set; }
	}
}