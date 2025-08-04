using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Models;
using XycloneDesigns.Apis.General.Http;
using XycloneDesigns.Apis.Afrobarometer.Tables;

namespace XycloneDesigns.Apis.Afrobarometer.Http
{
	public static partial class Surveys
	{
		public class Filters : GeneralBase.Filters
		{
			public const string InterviewCount = Survey.SQL.Column_InterviewCount;
			public const string List_PkQuestion = Survey.SQL.Column_List_PkQuestion;
			public const string List_PkVariable = Survey.SQL.Column_List_PkVariable;
			public const string PkCountry = Survey.SQL.Column_PkCountry;
			public const string PkLanguage = Survey.SQL.Column_PkLanguage;
			public const string Round = Survey.SQL.Column_Round;

			public new static IEnumerable<string> AsEnumerable()
			{
				return GeneralBase.Filters.AsEnumerable()
					.Append(InterviewCount)
					.Append(List_PkQuestion)
					.Append(List_PkVariable)
					.Append(PkCountry)
					.Append(PkLanguage)
					.Append(Round);
			}
		}

		public static bool Filter(this Filter filter, Survey survey)
		{
			return filter.Key switch
			{
				Filters.InterviewCount => filter.Passes(survey.InterviewCount),
				Filters.List_PkQuestion => filter.Passes(survey.List_PkQuestion),
				Filters.List_PkVariable => filter.Passes(survey.List_PkVariable),
				Filters.PkCountry => filter.Passes(survey.PkCountry),
				Filters.PkLanguage => filter.Passes(survey.PkLanguage),
				Filters.Round => filter.Passes(survey.Round),

				_ => filter.Filter<Survey>(survey),
			};
		}
	}
}
