
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
		[SQLite.Column(SQL.Column_Name)] public string? Name { get; set; }   
    }
}