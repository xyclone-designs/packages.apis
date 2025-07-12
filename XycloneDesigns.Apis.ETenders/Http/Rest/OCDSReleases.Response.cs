using System;
using System.Collections.Generic;

using XycloneDesigns.Apis.ETenders.Models;

namespace XycloneDesigns.Apis.ETenders.Http.Rest
{
	public partial class OCDSReleases
	{
		public class ResponseSingle : ETendersRest.Response 
		{
			public Release? Release { get; set; }
		}
		public class ResponseMultiple : ETendersRest.Response 
		{
			public string? License { get; set; }
			public Link? Links { get; set; }
			public Publisher? Publisher { get; set; }
			public DateTime? PublishedDate { get; set; }
			public string? PublicationPolicy { get; set; }
			public List<Release>? Releases { get; set; }
			public string? Uri { get; set; }
			public string? Version { get; set; }
		}
	}
}
