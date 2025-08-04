using Newtonsoft.Json;

using System.Collections.Generic;
using System.Text.Json.Serialization;

using XycloneDesigns.Apis.Afrobarometer.Enums;

namespace XycloneDesigns.Apis.Afrobarometer.Tables
{
	[SQLite.Table(SQL.Table)]
    public class Survey : AfrobarometerTable
	{
		public new class SQL : AfrobarometerTable.SQL
		{
			public const string Table = "surveys";

			public const string Column_InterviewCount = "interviewCount";
			public const string Column_List_PkQuestion = "list_pkQuestion";
			public const string Column_List_PkVariable = "list_pkVariable";
			public const string Column_PkCountry = "pkCountry";
			public const string Column_PkLanguage = "pkLanguage";
			public const string Column_Round = "round";

			public new static IEnumerable<string> Columns()
			{
				foreach (string columns in AfrobarometerTable.SQL.Columns())
					yield return columns;

				yield return Column_InterviewCount;
				yield return Column_List_PkQuestion;
				yield return Column_List_PkVariable;
				yield return Column_PkCountry;
				yield return Column_PkLanguage;
				yield return Column_Round;
			}
		}

		[JsonProperty(SQL.Column_InterviewCount), JsonPropertyName(SQL.Column_InterviewCount), SQLite.Column(SQL.Column_InterviewCount)] public int? InterviewCount { get; set; }
		[JsonProperty(SQL.Column_List_PkQuestion), JsonPropertyName(SQL.Column_List_PkQuestion), SQLite.Column(SQL.Column_List_PkQuestion)] public string? List_PkQuestion { get; set; }
		[JsonProperty(SQL.Column_List_PkVariable), JsonPropertyName(SQL.Column_List_PkVariable), SQLite.Column(SQL.Column_List_PkVariable)] public string? List_PkVariable { get; set; }
		[JsonProperty(SQL.Column_PkCountry), JsonPropertyName(SQL.Column_PkCountry), SQLite.Column(SQL.Column_PkCountry)] public int? PkCountry { get; set; }
		[JsonProperty(SQL.Column_PkLanguage), JsonPropertyName(SQL.Column_PkLanguage), SQLite.Column(SQL.Column_PkLanguage)] public int? PkLanguage { get; set; }
		[JsonProperty(SQL.Column_Round), JsonPropertyName(SQL.Column_Round), SQLite.Column(SQL.Column_Round)] public Rounds? Round { get; set; }
	}
}