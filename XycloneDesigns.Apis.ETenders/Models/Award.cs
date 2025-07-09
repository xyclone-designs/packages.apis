using System.Collections.Generic;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class Award : Model 
    {
        public string? Description { get; set; }
        public string? Id { get; set; }
        public List<Supplier>? Suppliers { get; set; }
        public string? Status { get; set; }
		public string? Title { get; set; }
		public Value? Value { get; set; }
    }
}