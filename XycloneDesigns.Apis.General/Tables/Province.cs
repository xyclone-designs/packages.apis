﻿
namespace XycloneDesigns.Apis.General.Tables
{
	[SQLite.Table(SQL.Table)]
	public partial class Province : _Table
	{
		public new class SQL
		{
			public const string Table = "provinces";

			public const string Column_Capital = "capital";
			public const string Column_Code = "code";
			public const string Column_Name = "name";
			public const string Column_Population = "population";
			public const string Column_PkCountry = "pkCountry";
			public const string Column_SquareKms = "squareKms";
			public const string Column_UrlCoatOfArms = "urlCoatOfArms";
			public const string Column_UrlWebsite = "urlWebsite";
		}

        [SQLite.Column(SQL.Column_Capital)] public string? Capital { get; set; }
		[SQLite.Column(SQL.Column_Code), SQLite.Unique] public string? Code { get; set; }
		[SQLite.Column(SQL.Column_Name)] public string? Name { get; set; }
        [SQLite.Column(SQL.Column_PkCountry)] public int? PkCountry { get; set; }
        [SQLite.Column(SQL.Column_Population)] public int? Population { get; set; }
        [SQLite.Column(SQL.Column_SquareKms)] public decimal? SquareKms { get; set; }
        [SQLite.Column(SQL.Column_UrlCoatOfArms)] public string? UrlCoatOfArms { get; set; }
        [SQLite.Column(SQL.Column_UrlWebsite)] public string? UrlWebsite { get; set; }
    }
}