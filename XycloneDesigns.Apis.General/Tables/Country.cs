using Newtonsoft.Json;

using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.General.Tables
{
	[SQLite.Table(SQL.Table)]
	public partial class Country : _Table
	{
		public new class SQL
		{
			public const string Table = "countries";

			public const string Column_Capital = "capital";
			public const string Column_Code = "code";
			public const string Column_Name = "name";
			public const string Column_Population = "population";
			public const string Column_SquareKms = "squareKms";
			public const string Column_UrlCoatOfArms = "urlCoatOfArms";
			public const string Column_UrlWebsite = "urlWebsite";
		}

        [SQLite.Column(SQL.Column_Capital), JsonProperty(SQL.Column_Capital), JsonPropertyName(SQL.Column_Capital)] public string? Capital { get; set; }
		[SQLite.Column(SQL.Column_Code), JsonProperty(SQL.Column_Code), JsonPropertyName(SQL.Column_Code), SQLite.Unique] public string? Code { get; set; }
		[SQLite.Column(SQL.Column_Name), JsonProperty(SQL.Column_Name), JsonPropertyName(SQL.Column_Name)] public string? Name { get; set; }
        [SQLite.Column(SQL.Column_Population), JsonProperty(SQL.Column_Population), JsonPropertyName(SQL.Column_Population)] public int? Population { get; set; }
        [SQLite.Column(SQL.Column_SquareKms), JsonProperty(SQL.Column_SquareKms), JsonPropertyName(SQL.Column_SquareKms)] public decimal? SquareKms { get; set; }
        [SQLite.Column(SQL.Column_UrlCoatOfArms), JsonProperty(SQL.Column_UrlCoatOfArms), JsonPropertyName(SQL.Column_UrlCoatOfArms)] public string? UrlCoatOfArms { get; set; }
        [SQLite.Column(SQL.Column_UrlWebsite), JsonProperty(SQL.Column_UrlWebsite), JsonPropertyName(SQL.Column_UrlWebsite)] public string? UrlWebsite { get; set; }
    }
}