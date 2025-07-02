
namespace XycloneDesigns.Apis.SAPS.Tables
{
	[SQLite.Table(SQL.Table)]
    public class Record : _Table
    {
        public new class SQL
        {
            public const string Table = "record";

			public const string Column_List_PkCategoryValue = "list_pkCategoryValue";
			public const string Column_PkPoliceStation = "pkPoliceStation";
			public const string Column_Year = "year";
        }

		[SQLite.Column(SQL.Column_List_PkCategoryValue)] public string? List_PkCategoryValue { get; set; }   
		[SQLite.Column(SQL.Column_PkPoliceStation)] public int? PkPoliceStation { get; set; }   
		[SQLite.Column(SQL.Column_Year)] public int? Year { get; set; }   
    }
}