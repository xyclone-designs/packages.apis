using Newtonsoft.Json;

using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.General.Tables
{
	[SQLite.Table(SQL.Table)]
	public partial class District : _Table
	{
		public new class SQL
		{
			public const string Table = "districts";

			public const string Column_Code = "code";
			public const string Column_Name = "name";
			public const string Column_PkProvince = "pkProvince";
			public const string Column_PkCountry = "pkCountry";
		}

        [SQLite.Column(SQL.Column_Code), JsonProperty(SQL.Column_Code), JsonPropertyName(SQL.Column_Code), SQLite.Unique] public string? Code { get; set; }
		[SQLite.Column(SQL.Column_Name), JsonProperty(SQL.Column_Name), JsonPropertyName(SQL.Column_Name)] public string? Name { get; set; }
        [SQLite.Column(SQL.Column_PkProvince), JsonProperty(SQL.Column_PkProvince), JsonPropertyName(SQL.Column_PkProvince)] public int? PkProvince { get; set; }
        [SQLite.Column(SQL.Column_PkCountry), JsonProperty(SQL.Column_PkCountry), JsonPropertyName(SQL.Column_PkCountry)] public int? PkCountry { get; set; }
    }
}