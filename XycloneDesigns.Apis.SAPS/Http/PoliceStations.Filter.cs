using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Models;
using XycloneDesigns.Apis.General.Http;
using XycloneDesigns.Apis.SAPS.Tables;

namespace XycloneDesigns.Apis.SAPS.Http
{
	public static partial class PoliceStations
	{
		public class Filters : Base.Filters
		{
			public const string Name = PoliceStation.SQL.Column_Name;
			public const string PkCountry = PoliceStation.SQL.Column_PkCountry;
			public const string PkDistrict = PoliceStation.SQL.Column_PkDistrict;
			public const string PkMunicipality = PoliceStation.SQL.Column_PkMunicipality;
			public const string PkProvince = PoliceStation.SQL.Column_PkProvince;

			public new static IEnumerable<string> AsEnumerable()
			{
				return Base.Filters.AsEnumerable()
					.Append(Name)
					.Append(PkCountry)
					.Append(PkDistrict)
					.Append(PkMunicipality)
					.Append(PkProvince);
			}
		}

		public static bool Filter(this Filter filter, PoliceStation policestation)
		{
			return filter.Key switch
			{
				Filters.Name => filter.Passes(policestation.Name),
				Filters.PkCountry => filter.Passes(policestation.PkCountry),
				Filters.PkDistrict => filter.Passes(policestation.PkDistrict),
				Filters.PkMunicipality => filter.Passes(policestation.PkMunicipality),
				Filters.PkProvince => filter.Passes(policestation.PkProvince),

				_ => filter.Filter<PoliceStation>(policestation),
			};
		}
	}
}
