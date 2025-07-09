using System;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class Publisher : Model
	{
		public string? Name { get; set; }
		public string? Scheme { get; set; }
		public string? Uid { get; set; }
		public Uri? Uri { get; set; }
	}
}