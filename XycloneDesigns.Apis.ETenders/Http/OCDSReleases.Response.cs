using System;
using System.Collections.Generic;

using XycloneDesigns.Apis.ETenders.Models;

namespace XycloneDesigns.Apis.ETenders.Http
{
	public static partial class OCDSReleases
	{
		public abstract class Response : ETenders.Response 
		{
			public class Json
			{
				public const string Data = "data";
				public const string Status = "status";
			}

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
