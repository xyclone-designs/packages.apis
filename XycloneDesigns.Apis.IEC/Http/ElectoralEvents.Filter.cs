using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Models;
using XycloneDesigns.Apis.General.Http;
using XycloneDesigns.Apis.IEC.Tables;

namespace XycloneDesigns.Apis.IEC.Http
{
	public static partial class ElectoralEvents
	{
		public class Filters : Base.Filters
		{
			public const string Abbr = ElectoralEvent.SQL.Column_Abbr;
			public const string Date = ElectoralEvent.SQL.Column_Date;
			public const string Name = ElectoralEvent.SQL.Column_Name;
			public const string Type = ElectoralEvent.SQL.Column_Type;
			
			public new static IEnumerable<string> AsEnumerable()
			{
				return Base.Filters.AsEnumerable()
					.Append(Abbr)
					.Append(Date)
					.Append(Name)
					.Append(Type);
			}
		}

		public static bool Filter(this Filter filter, ElectoralEvent electoralevent)
		{
			return filter.Key switch
			{
				Filters.Abbr => filter.Passes(electoralevent.Abbr),
				Filters.Date => filter.Passes(electoralevent.Date),
				Filters.Name => filter.Passes(electoralevent.Name),
				Filters.Type => filter.Passes(electoralevent.Type),

				_ => filter.Filter<ElectoralEvent>(electoralevent),
			};
		}
	}
}
