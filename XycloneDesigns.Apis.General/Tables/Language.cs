
namespace XycloneDesigns.Apis.General.Tables
{
	[SQLite.Table(SQL.Table)]
	public partial class Language : _Table
	{
		public new class SQL
		{
			public const string Table = "languages";

			public const string Column_Code = "code";
			public const string Column_Name = "name";
		}

        [SQLite.Column(SQL.Column_Code)] public string? Code { get; set; }
		[SQLite.Column(SQL.Column_Name)] public string? Name { get; set; }
    }
}