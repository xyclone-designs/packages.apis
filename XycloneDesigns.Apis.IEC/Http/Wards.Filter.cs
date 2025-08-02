using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Models;
using XycloneDesigns.Apis.General.Http;
using XycloneDesigns.Apis.IEC.Tables;

namespace XycloneDesigns.Apis.IEC.Http
{
	public static partial class Wards
	{
		public class Filters : Base.Filters
		{
			public const string Id = Ward.SQL.Column_Id;
			public const string PkCountry = Ward.SQL.Column_PkCountry;
			public const string PkDistrict = Ward.SQL.Column_PkDistrict;
			public const string PkMunicipality = Ward.SQL.Column_PkMunicipality;
			public const string PkProvince = Ward.SQL.Column_PkProvince;

			public new static IEnumerable<string> AsEnumerable()
			{
				return Base.Filters.AsEnumerable()
					.Append(Id)
					.Append(PkCountry)
					.Append(PkDistrict)
					.Append(PkMunicipality)
					.Append(PkProvince);
			}
		}

		public static bool Filter(this Filter filter, Ward ward)
		{
			return filter.Key switch
			{
				Filters.Id => filter.Passes(ward.Id),
				Filters.PkCountry => filter.Passes(ward.PkCountry),
				Filters.PkDistrict => filter.Passes(ward.PkDistrict),
				Filters.PkMunicipality => filter.Passes(ward.PkMunicipality),
				Filters.PkProvince => filter.Passes(ward.PkProvince),

				_ => filter.Filter<Ward>(ward),
			};
		}
	}
}
