using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Models;
using XycloneDesigns.Apis.General.Http;
using XycloneDesigns.Apis.Afrobarometer.Tables;

namespace XycloneDesigns.Apis.Afrobarometer.Http
{
	public static partial class Questions
	{
		public class Filters : GeneralBase.Filters
		{
			public const string Id = Question.SQL.Column_Id;
			public const string List_PkSurvey = Question.SQL.Column_List_PkSurvey;
			public const string Note = Question.SQL.Column_Note;
			public const string PkLanguage = Question.SQL.Column_PkLanguage;
			public const string PkVariable = Question.SQL.Column_PkVariable;
			public const string Source = Question.SQL.Column_Source;
			public const string Text = Question.SQL.Column_Text;
			public const string VariableLabel = Question.SQL.Column_VariableLabel;
			
			public new static IEnumerable<string> AsEnumerable()
			{
				return GeneralBase.Filters.AsEnumerable()
					.Append(Id)
					.Append(List_PkSurvey)
					.Append(Note)
					.Append(PkLanguage)
					.Append(PkVariable)
					.Append(Source)
					.Append(Text)
					.Append(VariableLabel);
			}
		}

		public static bool Filter(this Filter filter, Question question)
		{
			return filter.Key switch
			{
				Filters.Id => filter.Passes(question.Id),
				Filters.List_PkSurvey => filter.Passes(question.List_PkSurvey),
				Filters.Note => filter.Passes(question.Note),
				Filters.PkLanguage => filter.Passes(question.PkLanguage),
				Filters.PkVariable => filter.Passes(question.PkVariable),
				Filters.Source => filter.Passes(question.Source),
				Filters.Text => filter.Passes(question.Text),
				Filters.VariableLabel => filter.Passes(question.VariableLabel),

				_ => filter.Filter<Question>(question),
			};
		}
	}
}
