using Newtonsoft.Json;

using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.Afrobarometer.Tables
{
	[SQLite.Table(SQL.Table)]
	public class Variable : _Table
	{
		public new class SQL
		{
			public const string Table = "variables";

			public const string Column_Id = "id";
			public const string Column_Label = "label";
			public const string Column_ValueLabels = "valueLabels";
		}

		[JsonProperty(SQL.Column_Id), JsonPropertyName(SQL.Column_Id), SQLite.Column(SQL.Column_Id)] public string? Id { get; set; }
		[JsonProperty(SQL.Column_Label), JsonPropertyName(SQL.Column_Label), SQLite.Column(SQL.Column_Label)] public string? Label { get; set; }
		[JsonProperty(SQL.Column_ValueLabels), JsonPropertyName(SQL.Column_ValueLabels), SQLite.Column(SQL.Column_ValueLabels)] public string? ValueLabels { get; set; }
	}
}