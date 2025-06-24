using System.Collections.Generic;

namespace XycloneDesigns.Apis.General.Models
{
	public partial class Province
	{
		public static class Ids
		{
			public const string EC = "EC";
			public const string FS = "FS";
			public const string GT = "GT";
			public const string KZN = "KZN";
			public const string LIM = "LIM";
			public const string MP = "MP";
			public const string NC = "NC";
			public const string NW = "NW";
			public const string WC = "WC";

			public static string? FromPK(int pk)
			{
				return pk switch
				{
					1 => "EC",
					2 => "FS",
					3 => "GT",
					4 => "KZN",
					5 => "LIM",
					6 => "MP",
					7 => "NC",
					8 => "NW",
					9 => "WC",

					_ => null
				};
			}
			public static IEnumerable<string> AsEnumerable()
			{
				yield return EC;
				yield return FS;
				yield return GT;
				yield return KZN;
				yield return LIM;
				yield return MP;
				yield return NC;
				yield return NW;
				yield return WC;
			}
		}
	}
}