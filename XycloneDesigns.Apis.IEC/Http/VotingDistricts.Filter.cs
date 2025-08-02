using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Models;
using XycloneDesigns.Apis.General.Http;
using XycloneDesigns.Apis.IEC.Tables;

namespace XycloneDesigns.Apis.IEC.Http
{
	public static partial class VotingDistricts
	{
		public class Filters : Base.Filters
		{
			public const string Id = VotingDistrict.SQL.Column_Id;
			public const string PkCountry = VotingDistrict.SQL.Column_PkCountry;
			public const string PkDistrict = VotingDistrict.SQL.Column_PkDistrict;
			public const string PkMunicipality = VotingDistrict.SQL.Column_PkMunicipality;
			public const string PkProvince = VotingDistrict.SQL.Column_PkProvince;
			public const string PkWard = VotingDistrict.SQL.Column_PkWard;

			public new static IEnumerable<string> AsEnumerable()
			{
				return Base.Filters.AsEnumerable()
					.Append(Id)
					.Append(PkCountry)
					.Append(PkDistrict)
					.Append(PkMunicipality)
					.Append(PkProvince)
					.Append(PkWard);
			}
		}

		public static bool Filter(this Filter filter, VotingDistrict votingdistrict)
		{
			return filter.Key switch
			{
				Filters.Id => filter.Passes(votingdistrict.Id),
				Filters.PkCountry => filter.Passes(votingdistrict.PkCountry),
				Filters.PkDistrict => filter.Passes(votingdistrict.PkDistrict),
				Filters.PkMunicipality => filter.Passes(votingdistrict.PkMunicipality),
				Filters.PkProvince => filter.Passes(votingdistrict.PkProvince),
				Filters.PkWard => filter.Passes(votingdistrict.PkWard),

				_ => filter.Filter<VotingDistrict>(votingdistrict),
			};
		}
	}
}
