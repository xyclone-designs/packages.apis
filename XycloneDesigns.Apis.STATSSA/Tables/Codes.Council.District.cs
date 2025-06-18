
namespace XycloneDesigns.Apis.STATSSA.Tables
{
	[SQLite.Table(SQL.Table)]
	public class CodesCouncilDistrict : CodesCouncil
	{
		public new static class SQL
		{
			public const string Table = "codes_council_district";

			public const string Code = "code";
			public const string Name = "name";
			public const string ProvinceCode = "provincecode";
		}

		[SQLite.Column(SQL.Code)] public int? Code { get; set; }
		[SQLite.Column(SQL.Name)] public string? Name { get; set; }
		[SQLite.Column(SQL.ProvinceCode)] public int? ProvinceCode { get; set; }
	}
}