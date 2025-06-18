
namespace XycloneDesigns.Apis.STATSSA.Tables
{
	[SQLite.Table(SQL.Table)]
	public class CodesCauseOfDeath : Codes
	{
		public new static class SQL
		{
			public const string Table = "codes_causeofdeath";

			public const string Column_Code = "code";
			public const string Column_CodeStart = "codestart";
			public const string Column_CodeEnd = "codeend";
			public const string Column_Name = "name";
		}

		[SQLite.Column(SQL.Column_Code)] public string? Code { get; set; }
		[SQLite.Column(SQL.Column_CodeStart)] public string? CodeStart { get; set; }
		[SQLite.Column(SQL.Column_CodeEnd)] public string? CodeEnd { get; set; }
		[SQLite.Column(SQL.Column_Name)] public string? Name { get; set; }
	}
}