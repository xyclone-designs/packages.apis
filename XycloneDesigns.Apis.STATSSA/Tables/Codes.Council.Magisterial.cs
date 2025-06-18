
namespace XycloneDesigns.Apis.STATSSA.Tables
{
	[SQLite.Table(SQL.Table)]
	public class CodesCouncilMagisterial : CodesCouncil
	{
		public new static class SQL
		{
			public const string Table = "codes_council_magisterial";

			public const string Code = "code";
			public const string Name = "name";
		}
		[SQLite.Column(SQL.Code)] public int? Code { get; set; }
		[SQLite.Column(SQL.Name)] public string? Name { get; set; }
	}
}