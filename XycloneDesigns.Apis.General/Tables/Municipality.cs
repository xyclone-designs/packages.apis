
namespace XycloneDesigns.Apis.General.Tables
{
	[SQLite.Table(SQL.Table)]
	public class Municipality : _Table
	{
		public new class SQL
		{
			public const string Table = "municipalities";

			public const string Column_AddressEmail = "addressEmail";
			public const string Column_AddressPostal = "addressPostal";
			public const string Column_AddressStreet = "addressStreet";
			public const string Column_Category = "category";
			public const string Column_GeoCode = "geoCode";
			public const string Column_GeoLevel = "geoLevel";
			public const string Column_IsDisestablished = "isDisestablished";
			public const string Column_MiifCategory = "miifCategory";
			public const string Column_Name = "name";
			public const string Column_NameLong = "nameLong";
			public const string Column_NumberFax = "numberFax";
			public const string Column_NumberPhone = "numberPhone";
			public const string Column_PkCountry = "pkCountry";
			public const string Column_PkDistrict = "pkDistrict";
			public const string Column_PkProvince = "pkProvince";
			public const string Column_Population = "population";
			public const string Column_SquareKms = "squareKms";
			public const string Column_UrlLogo = "urlLogo";
			public const string Column_UrlWebsite = "urlWebsite";
		}
		
        [SQLite.Column(SQL.Column_AddressEmail)] public string? AddressEmail { get; set; }
        [SQLite.Column(SQL.Column_AddressPostal)] public string? AddressPostal { get; set; }
        [SQLite.Column(SQL.Column_AddressStreet)] public string? AddressStreet { get; set; }
		[SQLite.Column(SQL.Column_Category)] public string? Category { get; set; }
		[SQLite.Column(SQL.Column_GeoCode), SQLite.Unique] public string? GeoCode { get; set; }
		[SQLite.Column(SQL.Column_GeoLevel)] public string? GeoLevel { get; set; }
		[SQLite.Column(SQL.Column_IsDisestablished)] public bool? IsDisestablished { get; set; }
		[SQLite.Column(SQL.Column_MiifCategory)] public string? MiifCategory { get; set; }
		[SQLite.Column(SQL.Column_Name)] public string? Name { get; set; }
		[SQLite.Column(SQL.Column_NameLong)] public string? NameLong { get; set; }
		[SQLite.Column(SQL.Column_NumberFax)] public string? NumberFax { get; set; }
		[SQLite.Column(SQL.Column_NumberPhone)] public string? NumberPhone { get; set; }
		[SQLite.Column(SQL.Column_PkCountry)] public int? PkCountry { get; set; }
		[SQLite.Column(SQL.Column_PkDistrict)] public int? PkDistrict { get; set; }
		[SQLite.Column(SQL.Column_PkProvince)] public int? PkProvince { get; set; }
		[SQLite.Column(SQL.Column_Population)] public int? Population { get; set; }
		[SQLite.Column(SQL.Column_SquareKms)] public decimal? SquareKms { get; set; }
		[SQLite.Column(SQL.Column_UrlLogo)] public string? UrlLogo { get; set; }
		[SQLite.Column(SQL.Column_UrlWebsite)] public string? UrlWebsite { get; set; }
    }
}