using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Models;
using XycloneDesigns.Apis.General.Http;
using XycloneDesigns.Apis.IEC.Tables;

namespace XycloneDesigns.Apis.IEC.Http
{
	public static partial class Ballots
	{
		public class Filters : Base.Filters
		{
			public const string PkElectoralEvent = Ballot.SQL.Column_PkElectoralEvent;
			public const string PkMunicipality = Ballot.SQL.Column_PkMunicipality;
			public const string PkProvince = Ballot.SQL.Column_PkProvince;
			public const string PkVotingDistrict = Ballot.SQL.Column_PkVotingDistrict;
			public const string PkWard = Ballot.SQL.Column_PkWard;
			public const string Type = Ballot.SQL.Column_Type;
			public const string VotersRegistered = Ballot.SQL.Column_VotersRegistered;
			public const string VotesMEC7 = Ballot.SQL.Column_VotesMEC7;
			public const string VotesSection24A = Ballot.SQL.Column_VotesSection24A;
			public const string VotesSpecial = Ballot.SQL.Column_VotesSpecial;
			public const string VotesSpoilt = Ballot.SQL.Column_VotesSpoilt;
			public const string VotesTotal = Ballot.SQL.Column_VotesTotal;
			public const string VotesValid = Ballot.SQL.Column_VotesValid;

			public new static IEnumerable<string> AsEnumerable()
			{
				return Base.Filters.AsEnumerable()
					.Append(PkElectoralEvent)
					.Append(PkMunicipality)
					.Append(PkProvince)
					.Append(PkVotingDistrict)
					.Append(PkWard)
					.Append(Type)
					.Append(VotersRegistered)
					.Append(VotesMEC7)
					.Append(VotesSection24A)
					.Append(VotesSpecial)
					.Append(VotesSpoilt)
					.Append(VotesTotal)
					.Append(VotesValid);
			}
		}

		public static bool Filter(this Filter filter, Ballot ballot)
		{
			return filter.Key switch
			{
				Filters.PkElectoralEvent => filter.Passes(ballot.PkElectoralEvent),
				Filters.PkMunicipality => filter.Passes(ballot.PkMunicipality),
				Filters.PkProvince => filter.Passes(ballot.PkProvince),
				Filters.PkVotingDistrict => filter.Passes(ballot.PkVotingDistrict),
				Filters.PkWard => filter.Passes(ballot.PkWard),
				Filters.Type => filter.Passes(ballot.Type),
				Filters.VotersRegistered => filter.Passes(ballot.VotersRegistered),
				Filters.VotesMEC7 => filter.Passes(ballot.VotesMEC7),
				Filters.VotesSection24A => filter.Passes(ballot.VotesSection24A),
				Filters.VotesSpecial => filter.Passes(ballot.VotesSpecial),
				Filters.VotesSpoilt => filter.Passes(ballot.VotesSpoilt),
				Filters.VotesTotal => filter.Passes(ballot.VotesTotal),
				Filters.VotesValid => filter.Passes(ballot.VotesValid),

				_ => filter.Filter<Ballot>(ballot),
			};
		}
	}
}
