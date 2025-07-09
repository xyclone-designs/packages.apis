using System;
using System.Collections.Generic;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class ReleasePackage : Model
	{
		public string? License { get; set; }
		public Link? Links { get; set; }
		public string? PublicationPolicy { get; set; }
		public DateTime? PublishedDate { get; set; }
		public Publisher? Publisher { get; set; }
		public List<Release>? Releases { get; set; }
		public Uri? Uri { get; set; }
		public string? Version { get; set; }
	}
}