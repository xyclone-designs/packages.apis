using System;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class ContractPeriod : Model 
    {
		public int DurationInDays { get; set; }
		public DateTime? EndDate { get; set; }
		public DateTime? MaxExtentDate { get; set; }
		public DateTime? StartDate { get; set; }
	}
}