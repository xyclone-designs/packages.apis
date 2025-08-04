using Newtonsoft.Json;

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.SAPS.Tables
{
	[SQLite.Table(SQL.Table)]
    public class Category : SAPSTable
    {
        public new class SQL : SAPSTable.SQL
		{
            public const string Table = "categories";

			public const string Column_Name = "name";

			public new static IEnumerable<string> Columns()
			{
				foreach (string columns in SAPSTable.SQL.Columns())
					yield return columns;

				yield return Column_Name;
			}
		}

		[SQLite.Unique]
		[JsonProperty(SQL.Column_Name), JsonPropertyName(SQL.Column_Name), SQLite.Column(SQL.Column_Name)] public string? Name { get; set; }   
    }
}