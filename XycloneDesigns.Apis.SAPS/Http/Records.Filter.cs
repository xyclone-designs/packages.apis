using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Models;
using XycloneDesigns.Apis.General.Http;
using XycloneDesigns.Apis.SAPS.Tables;

namespace XycloneDesigns.Apis.SAPS.Http
{
	public static partial class Records
	{
		public class Filters : Base.Filters
		{
			public const string List_PkCategoryValue = Record.SQL.Column_List_PkCategoryValue;
			public const string PkPoliceStation = Record.SQL.Column_PkPoliceStation;
			public const string Year = Record.SQL.Column_Year;

			public new static IEnumerable<string> AsEnumerable()
			{
				return Base.Filters.AsEnumerable()
					.Append(List_PkCategoryValue)
					.Append(PkPoliceStation)
					.Append(Year);
			}
		}

		public static bool Filter(this Filter filter, Record record)
		{
			return filter.Key switch
			{
				Filters.List_PkCategoryValue => filter.Passes(record.List_PkCategoryValue),
				Filters.PkPoliceStation => filter.Passes(record.PkPoliceStation),
				Filters.Year => filter.Passes(record.Year),

				_ => filter.Filter<Record>(record),
			};
		}
	}
}
