using System;
using System.Collections.Generic;
using System.Drawing;

namespace XycloneDesigns.Apis.IEC.Models
{
	public class Party : Model
	{
		public string? Abbr { get; set; }
		public Color? Color { get; set; }
		public DateTime? DateEstablished { get; set; }
		public DateTime? DateDisestablished { get; set; }
		public List<ElectoralEvent>? ElectoralEvents { get; set; }
		public string? Headquarters { get; set; }
		public string? Name { get; set; }
		public Uri? UrlWebsite { get; set; }
		public Uri? UrlLogo { get; set; }
	}
}