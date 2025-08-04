using Newtonsoft.Json;

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.SAPS.Tables
{
	[SQLite.Table(SQL.Table)]
    public class Record : SAPSTable
    {
        public new class SQL : SAPSTable.SQL
		{
            public const string Table = "records";

			public const string Column_List_PkCategoryValue = "list_pkCategoryValue";
			public const string Column_PkPoliceStation = "pkPoliceStation";
			public const string Column_Year = "year";

			public new static IEnumerable<string> Columns()
			{
				foreach (string columns in SAPSTable.SQL.Columns())
					yield return columns;

				yield return Column_List_PkCategoryValue;
				yield return Column_PkPoliceStation;
				yield return Column_Year;
			}
		}

		[JsonProperty(SQL.Column_List_PkCategoryValue), JsonPropertyName(SQL.Column_List_PkCategoryValue), SQLite.Column(SQL.Column_List_PkCategoryValue)] public string? List_PkCategoryValue { get; set; }   
		[JsonProperty(SQL.Column_PkPoliceStation), JsonPropertyName(SQL.Column_PkPoliceStation), SQLite.Column(SQL.Column_PkPoliceStation)] public int? PkPoliceStation { get; set; }   
		[JsonProperty(SQL.Column_Year), JsonPropertyName(SQL.Column_Year), SQLite.Column(SQL.Column_Year)] public int? Year { get; set; }   
    }
}