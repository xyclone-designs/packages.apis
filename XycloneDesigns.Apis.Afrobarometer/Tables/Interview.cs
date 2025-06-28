using XycloneDesigns.Apis.Afrobarometer.Enums;

namespace XycloneDesigns.Apis.Afrobarometer.Tables
{
	[SQLite.Table(SQL.Table)]
    public class Interview : _Table
	{
		public new class SQL
		{
			public const string Table = "interviews";

			public const string Column_List_PkVariable_Record = "list_pkVariable_record";
			public const string Column_PkLanguage = "pkLanguage";
			public const string Column_PkSurvey = "pkSurvey";
			public const string Column_Round = "round";
		}

		[SQLite.Column(nameof(List_PkVariable_Record))] public string? List_PkVariable_Record { get; set; }
		[SQLite.Column(nameof(PkLanguage))] public int? PkLanguage { get; set; }
		[SQLite.Column(nameof(PkSurvey))] public int? PkSurvey { get; set; }
		[SQLite.Column(nameof(Round))] public Rounds? Round { get; set; }
	}
}