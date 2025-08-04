using Newtonsoft.Json;

using System.Collections.Generic;
using System.Text.Json.Serialization;

using XycloneDesigns.Apis.Afrobarometer.Enums;

namespace XycloneDesigns.Apis.Afrobarometer.Tables
{
	[SQLite.Table(SQL.Table)]
    public class Interview : AfrobarometerTable
	{
		public new class SQL : AfrobarometerTable.SQL
		{
			public const string Table = "interviews";

			public const string Column_List_PkVariable_Record = "list_pkVariable_record";
			public const string Column_PkLanguage = "pkLanguage";
			public const string Column_PkSurvey = "pkSurvey";
			public const string Column_Round = "round";

			public new static IEnumerable<string> Columns()
			{
				foreach (string columns in AfrobarometerTable.SQL.Columns())
					yield return columns;

				yield return Column_List_PkVariable_Record;
				yield return Column_PkLanguage;
				yield return Column_PkSurvey;
				yield return Column_Round;
			}
		}

		[JsonProperty(SQL.Column_List_PkVariable_Record), JsonPropertyName(SQL.Column_List_PkVariable_Record), SQLite.Column(SQL.Column_List_PkVariable_Record)] public string? List_PkVariable_Record { get; set; }
		[JsonProperty(SQL.Column_PkLanguage), JsonPropertyName(SQL.Column_PkLanguage), SQLite.Column(SQL.Column_PkLanguage)] public int? PkLanguage { get; set; }
		[JsonProperty(SQL.Column_PkSurvey), JsonPropertyName(SQL.Column_PkSurvey), SQLite.Column(SQL.Column_PkSurvey)] public int? PkSurvey { get; set; }
		[JsonProperty(SQL.Column_Round), JsonPropertyName(SQL.Column_Round), SQLite.Column(SQL.Column_Round)] public Rounds? Round { get; set; }
	}
}