
namespace XycloneDesigns.Apis.STATSSA.Tables
{
	[SQLite.Table(SQL.Table)]
	public class CodesReligion : Codes
	{
		public new static class SQL
		{
			public const string Table = "codes_religion";

			public const string Column_Code = "code";
			public const string Column_Value = "value";
		}

		[SQLite.Column(SQL.Column_Code)] public string? Code { get; set; }
		[SQLite.Column(SQL.Column_Value)] public string? Value { get; set; }
	}
}