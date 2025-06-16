
namespace XycloneDesigns.Apis.IEC.Tables
{
	[SQLite.Table(SQL.Table)]
	public class Party : _Table
	{
		public new class SQL
		{
			public const string Table = "parties";

			public const string Column_Abbr = "abbr";
			public const string Column_Color = "color";
			public const string Column_Name = "name";
			public const string Column_DateEstablished = "dateEstablished";
			public const string Column_DateDisestablished = "dateDisestablished";
			public const string Column_Headquarters = "headquarters";
			public const string Column_List_PkElectoralEvent = "list_pkElectoralEvent";
			public const string Column_UrlWebsite = "urlWebsite";
			public const string Column_UrlLogo = "urlLogo";
		}
		
		[SQLite.Column(SQL.Column_Abbr)] public string? Abbr { get; set; }
		[SQLite.Column(SQL.Column_Color)] public string? Color { get; set; }
		[SQLite.Column(SQL.Column_Name)] public string? Name { get; set; }
        [SQLite.Column(SQL.Column_DateEstablished)] public string? DateEstablished { get; set; }
        [SQLite.Column(SQL.Column_DateDisestablished)] public string? DateDisestablished { get; set; }
        [SQLite.Column(SQL.Column_Headquarters)] public string? Headquarters { get; set; }
		[SQLite.Column(SQL.Column_List_PkElectoralEvent)] public string? List_PkElectoralEvent { get; set; }
		[SQLite.Column(SQL.Column_UrlWebsite)] public string? UrlWebsite { get; set; }
        [SQLite.Column(SQL.Column_UrlLogo)] public string? UrlLogo { get; set; }
    }
}