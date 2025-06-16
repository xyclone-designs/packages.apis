
namespace XycloneDesigns.Apis.IEC.Tables
{
	[SQLite.Table(SQL.Table)]
	public class VotingDistrict : _Table
    {
		public new class SQL
		{
			public const string Table = "votingdistricts";

			public const string Column_Id = "id";
			public const string Column_PkMunicipality = "pkMunicipality";
			public const string Column_PkProvince = "pkProvince";
			public const string Column_PkWard = "pkWard";
		}

		[SQLite.Unique] 
		[SQLite.Column(SQL.Column_Id)] public string? Id { get; set; }
		[SQLite.Column(SQL.Column_PkMunicipality)] public int? PkMunicipality { get; set; }
        [SQLite.Column(SQL.Column_PkProvince)] public int? PkProvince { get; set; }
        [SQLite.Column(SQL.Column_PkWard)] public int? PkWard { get; set; }
    }
}