using Newtonsoft.Json;

using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.Afrobarometer.Tables
{
	[SQLite.Table(SQL.Table)]
    public class Question : _Table
	{
		public new class SQL
		{
			public const string Table = "questions";

			public const string Column_Id = "id";
			public const string Column_List_PkSurvey = "list_PkSurvey";
			public const string Column_Note = "note";
			public const string Column_PkLanguage = "pkLanguage";
			public const string Column_PkVariable = "pkVariable";
			public const string Column_Source = "source";
			public const string Column_Text = "text";
			public const string Column_VariableLabel = "variableLabel";
		}

		[JsonProperty(SQL.Column_Id), JsonPropertyName(SQL.Column_Id), SQLite.Column(SQL.Column_Id)] public string? Id { get; set; }
		[JsonProperty(SQL.Column_List_PkSurvey), JsonPropertyName(SQL.Column_List_PkSurvey), SQLite.Column(SQL.Column_List_PkSurvey)] public string? List_PkSurvey { get; set; }
		[JsonProperty(SQL.Column_Note), JsonPropertyName(SQL.Column_Note), SQLite.Column(SQL.Column_Note)] public string? Note { get; set; }
		[JsonProperty(SQL.Column_PkLanguage), JsonPropertyName(SQL.Column_PkLanguage), SQLite.Column(SQL.Column_PkLanguage)] public int? PkLanguage { get; set; }
		[JsonProperty(SQL.Column_PkVariable), JsonPropertyName(SQL.Column_PkVariable), SQLite.Column(SQL.Column_PkVariable)] public int? PkVariable { get; set; }
		[JsonProperty(SQL.Column_Source), JsonPropertyName(SQL.Column_Source), SQLite.Column(SQL.Column_Source)] public string? Source { get; set; }
		[JsonProperty(SQL.Column_Text), JsonPropertyName(SQL.Column_Text), SQLite.Column(SQL.Column_Text)] public string? Text { get; set; }
		[JsonProperty(SQL.Column_VariableLabel), JsonPropertyName(SQL.Column_VariableLabel), SQLite.Column(SQL.Column_VariableLabel)] public string? VariableLabel { get; set; }
	}
}