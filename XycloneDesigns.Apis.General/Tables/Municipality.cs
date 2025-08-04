using Newtonsoft.Json;

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.General.Tables
{
	[SQLite.Table(SQL.Table)]
	public class Municipality : GeneralTable
	{
		public class MiifCategories
		{
			public const string A = "A";
			public const string B1 = "B1";
			public const string B2 = "B2";
			public const string B3 = "B3";
			public const string B4 = "B4";
			public const string C1 = "C1";
			public const string C2 = "C2";

			public static IEnumerable<string> All()
			{
				yield return A;
				yield return B1;
				yield return B2;
				yield return B3;
				yield return B4;
				yield return C1;
				yield return C2;
			}
		}
		public new class SQL : GeneralTable.SQL
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

			public new static IEnumerable<string> Columns()
			{
				foreach (string columns in GeneralTable.SQL.Columns())
					yield return columns;

				yield return Column_AddressEmail;
				yield return Column_AddressPostal;
				yield return Column_AddressStreet;
				yield return Column_Category;
				yield return Column_GeoCode;
				yield return Column_GeoLevel;
				yield return Column_IsDisestablished;
				yield return Column_MiifCategory;
				yield return Column_Name;
				yield return Column_NameLong;
				yield return Column_NumberFax;
				yield return Column_NumberPhone;
				yield return Column_PkCountry;
				yield return Column_PkDistrict;
				yield return Column_PkProvince;
				yield return Column_Population;
				yield return Column_SquareKms;
				yield return Column_UrlLogo;
				yield return Column_UrlWebsite;
			}
		}
		
        [SQLite.Column(SQL.Column_AddressEmail), JsonProperty(SQL.Column_AddressEmail), JsonPropertyName(SQL.Column_AddressEmail)] public string? AddressEmail { get; set; }
        [SQLite.Column(SQL.Column_AddressPostal), JsonProperty(SQL.Column_AddressPostal), JsonPropertyName(SQL.Column_AddressPostal)] public string? AddressPostal { get; set; }
        [SQLite.Column(SQL.Column_AddressStreet), JsonProperty(SQL.Column_AddressStreet), JsonPropertyName(SQL.Column_AddressStreet)] public string? AddressStreet { get; set; }
		[SQLite.Column(SQL.Column_Category), JsonProperty(SQL.Column_Category), JsonPropertyName(SQL.Column_Category)] public string? Category { get; set; }
		[SQLite.Column(SQL.Column_GeoCode), JsonProperty(SQL.Column_GeoCode), JsonPropertyName(SQL.Column_GeoCode), SQLite.Unique] public string? GeoCode { get; set; }
		[SQLite.Column(SQL.Column_GeoLevel), JsonProperty(SQL.Column_GeoLevel), JsonPropertyName(SQL.Column_GeoLevel)] public string? GeoLevel { get; set; }
		[SQLite.Column(SQL.Column_IsDisestablished), JsonProperty(SQL.Column_IsDisestablished), JsonPropertyName(SQL.Column_IsDisestablished)] public bool? IsDisestablished { get; set; }
		[SQLite.Column(SQL.Column_MiifCategory), JsonProperty(SQL.Column_MiifCategory), JsonPropertyName(SQL.Column_MiifCategory)] public string? MiifCategory { get; set; }
		[SQLite.Column(SQL.Column_Name), JsonProperty(SQL.Column_Name), JsonPropertyName(SQL.Column_Name)] public string? Name { get; set; }
		[SQLite.Column(SQL.Column_NameLong), JsonProperty(SQL.Column_NameLong), JsonPropertyName(SQL.Column_NameLong)] public string? NameLong { get; set; }
		[SQLite.Column(SQL.Column_NumberFax), JsonProperty(SQL.Column_NumberFax), JsonPropertyName(SQL.Column_NumberFax)] public string? NumberFax { get; set; }
		[SQLite.Column(SQL.Column_NumberPhone), JsonProperty(SQL.Column_NumberPhone), JsonPropertyName(SQL.Column_NumberPhone)] public string? NumberPhone { get; set; }
		[SQLite.Column(SQL.Column_PkCountry), JsonProperty(SQL.Column_PkCountry), JsonPropertyName(SQL.Column_PkCountry)] public int? PkCountry { get; set; }
		[SQLite.Column(SQL.Column_PkDistrict), JsonProperty(SQL.Column_PkDistrict), JsonPropertyName(SQL.Column_PkDistrict)] public int? PkDistrict { get; set; }
		[SQLite.Column(SQL.Column_PkProvince), JsonProperty(SQL.Column_PkProvince), JsonPropertyName(SQL.Column_PkProvince)] public int? PkProvince { get; set; }
		[SQLite.Column(SQL.Column_Population), JsonProperty(SQL.Column_Population), JsonPropertyName(SQL.Column_Population)] public int? Population { get; set; }
		[SQLite.Column(SQL.Column_SquareKms), JsonProperty(SQL.Column_SquareKms), JsonPropertyName(SQL.Column_SquareKms)] public decimal? SquareKms { get; set; }
		[SQLite.Column(SQL.Column_UrlLogo), JsonProperty(SQL.Column_UrlLogo), JsonPropertyName(SQL.Column_UrlLogo)] public string? UrlLogo { get; set; }
		[SQLite.Column(SQL.Column_UrlWebsite), JsonProperty(SQL.Column_UrlWebsite), JsonPropertyName(SQL.Column_UrlWebsite)] public string? UrlWebsite { get; set; }
    }
}