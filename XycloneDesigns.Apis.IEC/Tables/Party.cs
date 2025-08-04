using Newtonsoft.Json;

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.IEC.Tables
{
	[SQLite.Table(SQL.Table)]
	public class Party : IECTable
	{
		public new class SQL : IECTable.SQL
		{
			public const string Table = "parties";

			public const string Column_Abbr = "abbr";
			public const string Column_Color = "color";
			public const string Column_Name = "name";
			public const string Column_DateEstablished = "dateEstablished";
			public const string Column_DateDisestablished = "dateDisestablished";
			public const string Column_Headquarters = "headquarters";
			public const string Column_List_PkElectoralEvent = "list_pkElectoralEvent";
			public const string Column_UrlWebsite = "urlWebsite";
			public const string Column_UrlLogo = "urlLogo";

			public new static IEnumerable<string> Columns()
			{
				foreach (string columns in IECTable.SQL.Columns())
					yield return columns;

				yield return Column_Abbr;
				yield return Column_Color;
				yield return Column_Name;
				yield return Column_DateEstablished;
				yield return Column_DateDisestablished;
				yield return Column_Headquarters;
				yield return Column_List_PkElectoralEvent;
				yield return Column_UrlWebsite;
				yield return Column_UrlLogo;
			}
		}
		
		[JsonProperty(SQL.Column_Abbr), JsonPropertyName(SQL.Column_Abbr), SQLite.Column(SQL.Column_Abbr)] public string? Abbr { get; set; }
		[JsonProperty(SQL.Column_Color), JsonPropertyName(SQL.Column_Color), SQLite.Column(SQL.Column_Color)] public string? Color { get; set; }
		[JsonProperty(SQL.Column_Name), JsonPropertyName(SQL.Column_Name), SQLite.Column(SQL.Column_Name)] public string? Name { get; set; }
        [JsonProperty(SQL.Column_DateEstablished), JsonPropertyName(SQL.Column_DateEstablished), SQLite.Column(SQL.Column_DateEstablished)] public string? DateEstablished { get; set; }
        [JsonProperty(SQL.Column_DateDisestablished), JsonPropertyName(SQL.Column_DateDisestablished), SQLite.Column(SQL.Column_DateDisestablished)] public string? DateDisestablished { get; set; }
        [JsonProperty(SQL.Column_Headquarters), JsonPropertyName(SQL.Column_Headquarters), SQLite.Column(SQL.Column_Headquarters)] public string? Headquarters { get; set; }
		[JsonProperty(SQL.Column_List_PkElectoralEvent), JsonPropertyName(SQL.Column_List_PkElectoralEvent), SQLite.Column(SQL.Column_List_PkElectoralEvent)] public string? List_PkElectoralEvent { get; set; }
		[JsonProperty(SQL.Column_UrlWebsite), JsonPropertyName(SQL.Column_UrlWebsite), SQLite.Column(SQL.Column_UrlWebsite)] public string? UrlWebsite { get; set; }
        [JsonProperty(SQL.Column_UrlLogo), JsonPropertyName(SQL.Column_UrlLogo), SQLite.Column(SQL.Column_UrlLogo)] public string? UrlLogo { get; set; }
    }
}