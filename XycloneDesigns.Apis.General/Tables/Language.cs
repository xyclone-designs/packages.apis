using Newtonsoft.Json;

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.General.Tables
{
	[SQLite.Table(SQL.Table)]
	public partial class Language : GeneralTable
	{
		public new class SQL : GeneralTable.SQL
		{
			public const string Table = "languages";

			public const string Column_Code = "code";
			public const string Column_Name = "name";

			public new static IEnumerable<string> Columns()
			{
				foreach (string columns in GeneralTable.SQL.Columns())
					yield return columns;

				yield return Column_Code;
				yield return Column_Name;
			}
		}

        [SQLite.Column(SQL.Column_Code), JsonProperty(SQL.Column_Code), JsonPropertyName(SQL.Column_Code)] public string? Code { get; set; }
		[SQLite.Column(SQL.Column_Name), JsonProperty(SQL.Column_Name), JsonPropertyName(SQL.Column_Name)] public string? Name { get; set; }
    }
}