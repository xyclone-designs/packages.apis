
namespace XycloneDesigns.Apis.General.Tables
{
	[SQLite.Table(SQL.Table)]
	public partial class District : _Table
	{
		public new class SQL
		{
			public const string Table = "districts";

			public const string Column_Code = "code";
			public const string Column_Name = "name";
			public const string Column_PkCountry = "pkCountry";
		}

        [SQLite.Column(SQL.Column_Code), SQLite.Unique] public string? Code { get; set; }
		[SQLite.Column(SQL.Column_Name)] public string? Name { get; set; }
        [SQLite.Column(SQL.Column_PkCountry)] public int? PkCountry { get; set; }
    }
}