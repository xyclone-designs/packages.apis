using XycloneDesigns.Apis.Afrobarometer.Enums;

namespace XycloneDesigns.Apis.Afrobarometer.Tables
{
	[SQLite.Table(SQL.Table)]
    public class Survey : _Table
	{
		public new class SQL
		{
			public const string Table = "surveys";

			public const string Column_CountryCode = "countryCode";
			public const string Column_InterviewCount = "interviewCount";
			public const string Column_List_PkQuestion = "list_pkQuestion";
			public const string Column_List_PkVariable = "list_pkVariable";
			public const string Column_PkLanguage = "pkLanguage";
			public const string Column_Round = "round";
		}

		[SQLite.Column(SQL.Column_CountryCode)] public string? CountryCode { get; set; }
		[SQLite.Column(SQL.Column_InterviewCount)] public int? InterviewCount { get; set; }
		[SQLite.Column(SQL.Column_List_PkQuestion)] public string? List_PkQuestion { get; set; }
		[SQLite.Column(SQL.Column_List_PkVariable)] public string? List_PkVariable { get; set; }
		[SQLite.Column(SQL.Column_PkLanguage)] public string? PkLanguage { get; set; }
		[SQLite.Column(SQL.Column_Round)] public Rounds? Round { get; set; }
	}
}