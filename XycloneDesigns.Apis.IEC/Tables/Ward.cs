﻿using Newtonsoft.Json;

using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.IEC.Tables
{
	[SQLite.Table(SQL.Table)]
    public class Ward : _Table
    {
        public new class SQL
        {
            public const string Table = "wards";

			public const string Column_Id = "id";
			public const string Column_PkMunicipality = "pkMunicipality";
            public const string Column_PkProvince = "pkProvince";
        }

		[SQLite.Unique]
		[JsonProperty(SQL.Column_Id), JsonPropertyName(SQL.Column_Id), SQLite.Column(SQL.Column_Id)] public string? Id { get; set; }
        [JsonProperty(SQL.Column_PkMunicipality), JsonPropertyName(SQL.Column_PkMunicipality), SQLite.Column(SQL.Column_PkMunicipality)] public int? PkMunicipality { get; set; }
        [JsonProperty(SQL.Column_PkProvince), JsonPropertyName(SQL.Column_PkProvince), SQLite.Column(SQL.Column_PkProvince)] public int? PkProvince { get; set; }        
    }
}