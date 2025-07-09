using System.Collections.Generic;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class Party : Model
	{
		public Address? Address { get; set; }
		public ContactPoint? ContactPoint { get; set; }
		public Details? Details { get; set; }
		public string? Id { get; set; }
		public Identifier? Identifier { get; set; }
		public string? Name { get; set; }
        public List<string>? Roles { get; set; }
    }
}