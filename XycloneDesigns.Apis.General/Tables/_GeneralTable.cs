using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.General.Tables
{
	public class GeneralTable
    {
		public class SQL
		{
			public const string Column_Pk = "pk";

			public static IEnumerable<string> Columns()
			{
				yield return Column_Pk;
			}
		}

		[SQLite.PrimaryKey, SQLite.NotNull, SQLite.AutoIncrement, SQLite.Unique, SQLite.Column(SQL.Column_Pk), JsonProperty(SQL.Column_Pk), JsonPropertyName(SQL.Column_Pk)]
        public int Pk { get; set; }

		public static string AddPKIfUnique(string? pks, int? pk)
		{
			if (pk is null)
				return string.Empty;
			if (pks is null)
				pks = pk.Value.ToString();
			else if (pks.Split(",").Contains(pk.ToString()) is false)
				pks += string.Format(",{0}", pk);

			return pks;
		}
		public static string AddPKPair(string? pkPairs, int pk, string value)
		{
			if (string.IsNullOrWhiteSpace(pkPairs))
				return string.Format("{0}:{1}", pk, value);

			pkPairs += string.Format(",{0}:{1}", pk, value);

			return pkPairs;
		}
		public static string AddPKPairIfUnique(string? pkPairs, int pk, string value)
		{
			if (pkPairs is null)
				pkPairs = string.Format("{0}:{1}", pk, value);
			else if (pkPairs.Split(",").FirstOrDefault(_pkPair => long.Parse(_pkPair.Split(":")[0]) == pk) is not string pkPair)
				pkPairs += string.Format(",{0}:{1}", pk, value);

			return pkPairs;
		}
		public static string AddPKPairIfUnique(string? pkPairs, int pk, int value, bool addtoifpresent = false)
		{
			if (pkPairs is null)
				pkPairs = string.Format("{0}:{1}", pk, value);
			else if (pkPairs.Split(",").FirstOrDefault(_pkPair => long.Parse(_pkPair.Split(":")[0]) == pk) is not string pkPair)
				pkPairs += string.Format(",{0}:{1}", pk, value);
			else if (addtoifpresent)
				pkPairs = pkPairs.Replace(pkPair, string.Format("{0}:{1}", pk, long.Parse(pkPair.Split(":")[1]) + value));

			return pkPairs;
		}
	}
}