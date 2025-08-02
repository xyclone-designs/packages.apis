using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Enums;
using XycloneDesigns.Apis.General.Http.Models;
using XycloneDesigns.Apis.General.Tables;

namespace XycloneDesigns.Apis.General.Http
{
	public static partial class Districts
	{
		public class Filters : Base.Filters
		{
			public const string Code = District.SQL.Column_Code;
			public const string Name = District.SQL.Column_Name;
			public const string PkProvince = District.SQL.Column_PkProvince;
			public const string PkCountry = District.SQL.Column_PkCountry;

			public new static IEnumerable<string> AsEnumerable()
			{
				return Base.Filters.AsEnumerable()
					.Append(Code)
					.Append(Name)
					.Append(PkProvince)
					.Append(PkCountry);
			}
		}

		public static bool Filter(this Filter filter, District district)
		{
			return filter.Key switch
			{
				Filters.Code => filter.Passes(district.Code),
				Filters.Name => filter.Passes(district.Name),
				Filters.PkProvince => filter.Passes(district.PkProvince),
				Filters.PkCountry => filter.Passes(district.PkCountry),

				_ => filter.Filter<District>(district),
			};
		}
	}
}
