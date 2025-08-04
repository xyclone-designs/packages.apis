using Newtonsoft.Json;

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.General.Tables
{
	[SQLite.Table(SQL.Table)]
	public partial class Province : GeneralTable
	{
		public class Codes
		{
			public class SouthAfrica
			{
				public const string EC = "EC";
				public const string FS = "FS";
				public const string GT = "GT";
				public const string KZN = "KZN";
				public const string LIM = "LIM";
				public const string MP = "MP";
				public const string NC = "NC";
				public const string NW = "NW";
				public const string WC = "WC";

				public static IEnumerable<string> All()
				{
					yield return EC;
					yield return FS;
					yield return GT;
					yield return KZN;
					yield return LIM;
					yield return MP;
					yield return NC;
					yield return NW;
					yield return WC;
				}
			}
		}
		public new class SQL : GeneralTable.SQL
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

			public new static IEnumerable<string> Columns()
			{
				foreach (string columns in GeneralTable.SQL.Columns())
					yield return columns;

				yield return Column_Capital;
				yield return Column_Code;
				yield return Column_Name;
				yield return Column_Population;
				yield return Column_PkCountry;
				yield return Column_SquareKms;
				yield return Column_UrlCoatOfArms;
				yield return Column_UrlWebsite;
			}
		}

        [JsonProperty(SQL.Column_Capital), JsonPropertyName(SQL.Column_Capital), SQLite.Column(SQL.Column_Capital)] public string? Capital { get; set; }
		[JsonProperty(SQL.Column_Code), JsonPropertyName(SQL.Column_Code), SQLite.Column(SQL.Column_Code), SQLite.Unique] public string? Code { get; set; }
		[JsonProperty(SQL.Column_Name), JsonPropertyName(SQL.Column_Name), SQLite.Column(SQL.Column_Name)] public string? Name { get; set; }
        [JsonProperty(SQL.Column_PkCountry), JsonPropertyName(SQL.Column_PkCountry), SQLite.Column(SQL.Column_PkCountry)] public int? PkCountry { get; set; }
        [JsonProperty(SQL.Column_Population), JsonPropertyName(SQL.Column_Population), SQLite.Column(SQL.Column_Population)] public int? Population { get; set; }
        [JsonProperty(SQL.Column_SquareKms), JsonPropertyName(SQL.Column_SquareKms), SQLite.Column(SQL.Column_SquareKms)] public decimal? SquareKms { get; set; }
        [JsonProperty(SQL.Column_UrlCoatOfArms), JsonPropertyName(SQL.Column_UrlCoatOfArms), SQLite.Column(SQL.Column_UrlCoatOfArms)] public string? UrlCoatOfArms { get; set; }
        [JsonProperty(SQL.Column_UrlWebsite), JsonPropertyName(SQL.Column_UrlWebsite), SQLite.Column(SQL.Column_UrlWebsite)] public string? UrlWebsite { get; set; }
    }
}