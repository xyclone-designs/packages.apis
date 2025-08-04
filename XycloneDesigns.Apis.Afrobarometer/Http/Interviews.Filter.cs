using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Enums;
using XycloneDesigns.Apis.General.Http.Models;
using XycloneDesigns.Apis.General.Http;
using XycloneDesigns.Apis.Afrobarometer.Tables;

namespace XycloneDesigns.Apis.Afrobarometer.Http
{
	public static partial class Interviews
	{
		public class Filters : GeneralBase.Filters
		{
			public const string List_PkVariable_Record = Interview.SQL.Column_List_PkVariable_Record;
			public const string PkLanguage = Interview.SQL.Column_PkLanguage;
			public const string PkSurvey = Interview.SQL.Column_PkSurvey;
			public const string Round = Interview.SQL.Column_Round;

			public new static IEnumerable<string> AsEnumerable()
			{
				return GeneralBase.Filters.AsEnumerable()
					.Append(List_PkVariable_Record)
					.Append(PkLanguage)
					.Append(PkSurvey)
					.Append(Round);
			}
		}

		public static bool Filter(this Filter filter, Interview interview)
		{
			return filter.Key switch
			{
				Filters.List_PkVariable_Record => filter.Passes(interview.List_PkVariable_Record),
				Filters.PkLanguage => filter.Passes(interview.PkLanguage),
				Filters.PkSurvey => filter.Passes(interview.PkSurvey),
				Filters.Round => filter.Passes(interview.Round),

				_ => filter.Filter<Interview>(interview),
			};
		}
	}
}
