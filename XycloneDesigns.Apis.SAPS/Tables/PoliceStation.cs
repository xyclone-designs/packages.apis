﻿
namespace XycloneDesigns.Apis.SAPS.Tables
{
	[SQLite.Table(SQL.Table)]
    public class PoliceStation : _Table
    {
        public new class SQL
        {
            public const string Table = "policestations";

			public const string Column_Name = "name";
			public const string Column_PkDistrict = "pkDistrict";
			public const string Column_PkMunicipality = "pkMunicipality";
            public const string Column_PkProvince = "pkProvince";
        }

		[SQLite.Unique]
		[SQLite.Column(SQL.Column_Name)] public string? Name { get; set; }
        [SQLite.Column(SQL.Column_PkDistrict)] public int? PkDistrict { get; set; }
        [SQLite.Column(SQL.Column_PkMunicipality)] public int? PkMunicipality { get; set; }
        [SQLite.Column(SQL.Column_PkProvince)] public int? PkProvince { get; set; }        
    }
}