using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Models;
using XycloneDesigns.Apis.General.Http;
using XycloneDesigns.Apis.IEC.Tables;

namespace XycloneDesigns.Apis.IEC.Http
{
	public static partial class Parties
	{
		public class Filters : GeneralBase.Filters
		{
			public const string Abbr = Party.SQL.Column_Abbr;
			public const string Name = Party.SQL.Column_Name;
			public const string DateEstablished = Party.SQL.Column_DateEstablished;
			public const string DateDisestablished = Party.SQL.Column_DateDisestablished;
			public const string Headquarters = Party.SQL.Column_Headquarters;
			public const string List_PkElectoralEvent = Party.SQL.Column_List_PkElectoralEvent;
			public const string UrlWebsite = Party.SQL.Column_UrlWebsite;
			public const string UrlLogo = Party.SQL.Column_UrlLogo;

			public new static IEnumerable<string> AsEnumerable()
			{
				return GeneralBase.Filters.AsEnumerable()
					.Append(Abbr)
					.Append(Name)
					.Append(DateEstablished)
					.Append(DateDisestablished)
					.Append(Headquarters)
					.Append(List_PkElectoralEvent)
					.Append(UrlWebsite)
					.Append(UrlLogo);
			}
		}

		public static bool Filter(this Filter filter, Party party)
		{
			return filter.Key switch
			{
				Filters.Abbr => filter.Passes(party.Abbr),
				Filters.Name => filter.Passes(party.Name),
				Filters.DateEstablished => filter.Passes(party.DateEstablished),
				Filters.DateDisestablished => filter.Passes(party.DateDisestablished),
				Filters.Headquarters => filter.Passes(party.Headquarters),
				Filters.List_PkElectoralEvent => filter.Passes(party.List_PkElectoralEvent),
				Filters.UrlWebsite => filter.Passes(party.UrlWebsite),
				Filters.UrlLogo => filter.Passes(party.UrlLogo),

				_ => filter.Filter<Party>(party),
			};
		}
	}
}
