using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Enums;
using XycloneDesigns.Apis.General.Http.Models;
using XycloneDesigns.Apis.General.Tables;

namespace XycloneDesigns.Apis.General.Http
{
	public static partial class Languages
	{
		public class Filters : GeneralBase.Filters
		{
			public const string Code = Language.SQL.Column_Code;
			public const string Name = Language.SQL.Column_Name;
			
			public new static IEnumerable<string> AsEnumerable()
			{
				return GeneralBase.Filters.AsEnumerable()
					.Append(Code)
					.Append(Name);
			}
		}

		public static bool Filter(this Filter filter, Language language)
		{
			return filter.Key switch
			{
				Filters.Code => filter.Passes(language.Code),
				Filters.Name => filter.Passes(language.Name),

				_ => filter.Filter<Language>(language),
			};
		}
	}
}
