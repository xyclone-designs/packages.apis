using System.Collections.Generic;
using System.Linq;

namespace XycloneDesigns.Apis.IEC.Models
{
	public partial class Ballot
	{
		public static class Types
		{
			public const string Municipal = "municipal";
			public const string MunicipalDC40 = "municipal.dc40";
			public const string MunicipalDMADC60 = "municipal.dmadc60";
			public const string MunicipalPR = "municipal.pr";
			public const string MunicipalWard = "municipal.ward";
			public const string National = "national";
			public const string NationalEC = "national.EC";
			public const string NationalFS = "national.FS";
			public const string NationalGT = "national.GT";
			public const string NationalKZN = "national.KZN";
			public const string NationalLIM = "national.LIM";
			public const string NationalMP = "national.MP";
			public const string NationalNC = "national.NC";
			public const string NationalNW = "national.NW";
			public const string NationalWC = "national.WC";
			public const string Provincial = "provincial";
			public const string ProvincialEC = "provincial.EC";
			public const string ProvincialFS = "provincial.FS";
			public const string ProvincialGT = "provincial.GT";
			public const string ProvincialKZN = "provincial.KZN";
			public const string ProvincialLIM = "provincial.LIM";
			public const string ProvincialMP = "provincial.MP";
			public const string ProvincialNC = "provincial.NC";
			public const string ProvincialNW = "provincial.NW";
			public const string ProvincialWC = "provincial.WC";
			public const string Regional = "regional";
			public const string RegionalEC = "regional.EC";
			public const string RegionalFS = "regional.FS";
			public const string RegionalGT = "regional.GT";
			public const string RegionalKZN = "regional.KZN";
			public const string RegionalLIM = "regional.LIM";
			public const string RegionalMP = "regional.MP";
			public const string RegionalNC = "regional.NC";
			public const string RegionalNW = "regional.NW";
			public const string RegionalWC = "regional.WC";

			public static bool IsMunicipalCurated(string? type)
			{
				return type != null && type.ToLower() switch
				{
					MunicipalDC40 => true,
					MunicipalDMADC60 => true,
					MunicipalPR => true,
					MunicipalWard => true,

					_ => false
				};
			}
			public static bool IsNationalCurated(string? type)
			{
				return type != null && type.ToLower() switch
				{
					NationalEC => true,
					NationalFS => true,
					NationalGT => true,
					NationalKZN => true,
					NationalLIM => true,
					NationalMP => true,
					NationalNC => true,
					NationalNW => true,
					NationalWC => true,

					_ => false
				};
			}
			public static bool IsProvincialCurated(string? type)
			{
				return type != null && type.ToLower() switch
				{
					ProvincialEC => true,
					ProvincialFS => true,
					ProvincialGT => true,
					ProvincialKZN => true,
					ProvincialLIM => true,
					ProvincialMP => true,
					ProvincialNC => true,
					ProvincialNW => true,
					ProvincialWC => true,

					_ => false
				};
			}
			public static bool IsRegionalCurated(string? type)
			{
				return type != null && type.ToLower() switch
				{
					RegionalEC => true,
					RegionalFS => true,
					RegionalGT => true,
					RegionalKZN => true,
					RegionalLIM => true,
					RegionalMP => true,
					RegionalNC => true,
					RegionalNW => true,
					RegionalWC => true,

					_ => false
				};
			}

			public class Comparer : Comparer<string?>
			{
				public new static readonly Comparer Default = new ();

				private readonly string[] Order = new string[]
				{
					MunicipalWard,
					MunicipalPR,
					MunicipalDC40,
					MunicipalDMADC60,
				};

				public override int Compare(string? x, string? y)
				{
					int? xindex = Order.Index(x);
					int? yindex = Order.Index(y);

					return (xindex, yindex) switch 
					{
						(null, null) => 0,
						(_, null) => 1,
						(null, _) => -1,

						(_, _) when xindex > yindex => 1,
						(_, _) when xindex < yindex => -1,
						(_, _) => 0,
					};
				}			
			}
		}
	}
}