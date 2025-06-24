using System.Collections.Generic;
using System.Linq;

namespace XycloneDesigns.Apis.General.Models
{
	public partial class Municipality 
	{
		public static class MiifCategories
		{
			public const string A = "A";
			public const string B1 = "B1";
			public const string B2 = "B2";
			public const string B3 = "B3";
			public const string B4 = "B4";
			public const string C1 = "C1";
			public const string C2 = "C2";

			public class Comparer : Comparer<string?>
			{
				public new static readonly Comparer Default = new();
				public static readonly Comparer Metro = new() { Order = [ A ] };

				private string[] Order = [A, B1, B2, B3, B4, C1, C2];

				public override int Compare(string? x, string? y)
				{
					int? xindex = Order.Index(x);
					int? yindex = Order.Index(y);

					return (xindex, yindex) switch
					{
						(null, null) => 0,
						(null, _) => 1,
						(_, null) => -1,

						(_, _) when xindex > yindex => 1,
						(_, _) when xindex < yindex => -1,
						(_, _) => 0,
					};
				}
			}
		}
	}
}