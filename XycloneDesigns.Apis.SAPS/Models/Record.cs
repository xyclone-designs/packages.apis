using System.Collections.Generic;

namespace XycloneDesigns.Apis.SAPS.Models
{
	public class Record : Model
	{
		public ListPairs<Category, int>? CategoryValues { get; set; }
		public PoliceStation? PoliceStation { get; set; }
		public int? Year { get; set; }
	}
}