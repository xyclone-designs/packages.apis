using System;
using System.Collections.Generic;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class RelatedProcess : Model
	{
		public string? Id { get; set; }
		public Identifier? Identifier { get; set; }
		public List<string>? Relationship { get; set; }
		public string? Scheme { get; set; }
		public string? Title { get; set; }
		public Uri? Uri { get; set; }
	}
}