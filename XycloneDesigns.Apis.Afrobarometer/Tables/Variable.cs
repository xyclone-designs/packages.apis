
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

		[SQLite.Column(SQL.Column_Id)] public string? Id { get; set; }
		[SQLite.Column(SQL.Column_Label)] public string? Label { get; set; }
		[SQLite.Column(SQL.Column_ValueLabels)] public string? ValueLabels { get; set; }
	}
}