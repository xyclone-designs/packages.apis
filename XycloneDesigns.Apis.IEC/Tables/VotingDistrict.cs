using Newtonsoft.Json;

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.IEC.Tables
{
	[SQLite.Table(SQL.Table)]
	public class VotingDistrict : IECTable
    {
		public new class SQL : IECTable.SQL
		{
			public const string Table = "votingdistricts";

			public const string Column_Id = "id";
			public const string Column_PkCountry = "pkCountry";
			public const string Column_PkDistrict = "pkDistrict";
			public const string Column_PkMunicipality = "pkMunicipality";
			public const string Column_PkProvince = "pkProvince";
			public const string Column_PkWard = "pkWard";

			public new static IEnumerable<string> Columns()
			{
				foreach (string columns in IECTable.SQL.Columns())
					yield return columns;

				yield return Column_Id;
				yield return Column_PkCountry;
				yield return Column_PkDistrict;
				yield return Column_PkMunicipality;
				yield return Column_PkProvince;
				yield return Column_PkWard;
			}
		}

		[SQLite.Unique] 
		[JsonProperty(SQL.Column_Id), JsonPropertyName(SQL.Column_Id), SQLite.Column(SQL.Column_Id)] public string? Id { get; set; }
		[JsonProperty(SQL.Column_PkCountry), JsonPropertyName(SQL.Column_PkCountry), SQLite.Column(SQL.Column_PkCountry)] public int? PkCountry { get; set; }
		[JsonProperty(SQL.Column_PkDistrict), JsonPropertyName(SQL.Column_PkDistrict), SQLite.Column(SQL.Column_PkDistrict)] public int? PkDistrict { get; set; }
		[JsonProperty(SQL.Column_PkMunicipality), JsonPropertyName(SQL.Column_PkMunicipality), SQLite.Column(SQL.Column_PkMunicipality)] public int? PkMunicipality { get; set; }
        [JsonProperty(SQL.Column_PkProvince), JsonPropertyName(SQL.Column_PkProvince), SQLite.Column(SQL.Column_PkProvince)] public int? PkProvince { get; set; }
        [JsonProperty(SQL.Column_PkWard), JsonPropertyName(SQL.Column_PkWard), SQLite.Column(SQL.Column_PkWard)] public int? PkWard { get; set; }
    }
}