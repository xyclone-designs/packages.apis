
namespace XycloneDesigns.Apis.STATSSA.Tables
{
	[SQLite.Table(SQL.Table)]
	public class CodesArea : Codes
	{
		public new static class SQL
		{
			public const string Table = "codes_area";

			public const string Column_ProvinceCode = "provincecode";
			public const string Column_ProvinceName = "provincename";
			public const string Column_DistrictCouncilCode = "districtcouncilcode";
			public const string Column_DistrictCouncilName = "districtcouncilname";
			public const string Column_TLCTRCCode = "tlctrccode";
			public const string Column_TLCTRCName = "tlctrcname";
		}

		[SQLite.Column(SQL.Column_ProvinceCode)] public int? ProvinceCode { get; set; }
		[SQLite.Column(SQL.Column_ProvinceName)] public string? ProvinceName { get; set; }
		[SQLite.Column(SQL.Column_DistrictCouncilCode)] public int? DistrictCouncilCode { get; set; }
		[SQLite.Column(SQL.Column_DistrictCouncilName)] public string? DistrictCouncilName { get; set; }
		[SQLite.Column(SQL.Column_TLCTRCCode)] public int? TLCTRCCode { get; set; }
		[SQLite.Column(SQL.Column_TLCTRCName)] public string? TLCTRCName { get; set; }
	}
}