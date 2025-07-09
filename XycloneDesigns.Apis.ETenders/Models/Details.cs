using System;
using System.Collections.Generic;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class Details : Model 
    {
        public string? BuyerProfile { get; set; }
        public List<Classification>? Classifications { get; set; }
		public Uri? Url { get; set; }
	}
}