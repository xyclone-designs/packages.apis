using Newtonsoft.Json;

using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.SAPS.Tables
{
	[SQLite.Table(SQL.Table)]
    public class Category : _Table
    {
        public new class SQL
        {
            public const string Table = "categories";

			public const string Column_Name = "name";
        }

		[SQLite.Unique]
		[JsonProperty(SQL.Column_Name), JsonPropertyName(SQL.Column_Name), SQLite.Column(SQL.Column_Name)] public string? Name { get; set; }   
    }
}