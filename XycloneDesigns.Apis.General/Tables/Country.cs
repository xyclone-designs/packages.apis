using Newtonsoft.Json;

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.General.Tables
{
	[SQLite.Table(SQL.Table)]
	public partial class Country : GeneralTable
	{
		public new class SQL : GeneralTable.SQL
		{
			public const string Table = "countries";

			public const string Column_Capital = "capital";
			public const string Column_Code = "code";
			public const string Column_Name = "name";
			public const string Column_Population = "population";
			public const string Column_SquareKms = "squareKms";
			public const string Column_UrlCoatOfArms = "urlCoatOfArms";
			public const string Column_UrlWebsite = "urlWebsite";

			public new static IEnumerable<string> Columns()
			{
				foreach (string columns in GeneralTable.SQL.Columns())
					yield return columns;

				yield return Column_Capital;
				yield return Column_Code;
				yield return Column_Name;
				yield return Column_Population;
				yield return Column_SquareKms;
				yield return Column_UrlCoatOfArms;
				yield return Column_UrlWebsite;
			}
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