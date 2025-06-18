
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

		[SQLite.Column(SQL.Column_Id)] public string? Id { get; set; }
		[SQLite.Column(SQL.Column_List_PkSurvey)] public string? List_PkSurvey { get; set; }
		[SQLite.Column(SQL.Column_Note)] public string? Note { get; set; }
		[SQLite.Column(SQL.Column_PkLanguage)] public string? PkLanguage { get; set; }
		[SQLite.Column(SQL.Column_PkVariable)] public int? PkVariable { get; set; }
		[SQLite.Column(SQL.Column_Source)] public string? Source { get; set; }
		[SQLite.Column(SQL.Column_Text)] public string? Text { get; set; }
		[SQLite.Column(SQL.Column_VariableLabel)] public string? VariableLabel { get; set; }
	}
}