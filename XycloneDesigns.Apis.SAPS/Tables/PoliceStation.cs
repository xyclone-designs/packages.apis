using Newtonsoft.Json;

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.SAPS.Tables
{
	[SQLite.Table(SQL.Table)]
    public class PoliceStation : SAPSTable
    {
        public new class SQL : SAPSTable.SQL
		{
            public const string Table = "policestations";

			public const string Column_Name = "name";
			public const string Column_PkCountry = "pkCountry";
			public const string Column_PkDistrict = "pkDistrict";
			public const string Column_PkMunicipality = "pkMunicipality";
            public const string Column_PkProvince = "pkProvince";

			public new static IEnumerable<string> Columns()
			{
				foreach (string columns in SAPSTable.SQL.Columns())
					yield return columns;

				yield return Column_Name;
				yield return Column_PkCountry;
				yield return Column_PkDistrict;
				yield return Column_PkMunicipality;
				yield return Column_PkProvince;
			}
		}

		[SQLite.Unique]
		[JsonProperty(SQL.Column_Name), JsonPropertyName(SQL.Column_Name), SQLite.Column(SQL.Column_Name)] public string? Name { get; set; }
        [JsonProperty(SQL.Column_PkCountry), JsonPropertyName(SQL.Column_PkCountry), SQLite.Column(SQL.Column_PkCountry)] public int? PkCountry { get; set; }
        [JsonProperty(SQL.Column_PkDistrict), JsonPropertyName(SQL.Column_PkDistrict), SQLite.Column(SQL.Column_PkDistrict)] public int? PkDistrict { get; set; }
        [JsonProperty(SQL.Column_PkMunicipality), JsonPropertyName(SQL.Column_PkMunicipality), SQLite.Column(SQL.Column_PkMunicipality)] public int? PkMunicipality { get; set; }
        [JsonProperty(SQL.Column_PkProvince), JsonPropertyName(SQL.Column_PkProvince), SQLite.Column(SQL.Column_PkProvince)] public int? PkProvince { get; set; }        
    }
}