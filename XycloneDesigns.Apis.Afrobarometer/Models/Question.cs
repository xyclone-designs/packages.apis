using System.Collections.Generic;

using XycloneDesigns.Apis.General.Models;

namespace XycloneDesigns.Apis.Afrobarometer.Models
{
    public class Question : Model
	{
		public string? Id { get; set; }
		public List<Survey>? Surveys { get; set; }
		public string? Note { get; set; }
		public Language? Language { get; set; }
		public Variable? Variable { get; set; }
		public string? Source { get; set; }
		public string? Text { get; set; }
		public string? VariableLabel { get; set; }
	}
}