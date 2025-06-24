using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.IEC.Tables;

namespace XycloneDesigns.Apis.IEC.Http.Rest
{
	public partial class Languages 
	{
		public class OrderKeys : IECRest.OrderKeys
		{
			public const string ElectoralEvent = "electoralEvent";
			public const string Municipality = "municipality";
			public const string Province = "province";
			public const string Type = "type";
			public const string VotersRegistered = "votersRegistered";
			public const string VotesSection24A = "votesSection24A";
			public const string VotesMEC7 = "votesMEC7";
			public const string VotesSpecial = "votesSpecial";
			public const string VotesSpoilt = "votesSpoilt";
			public const string VotesTotal = "votesTotal";
			public const string VotingDistrict = "votingDistrict";
			public const string Ward = "ward";

			public static IOrderedQueryable<Language> Order(IQueryable<Language> queryable, string orderkey, bool reverse)
			{
				return (orderkey, reverse) switch
				{
					(ElectoralEvent, true) => queryable.OrderByDescending(_ => _.PkElectoralEvent),
					(ElectoralEvent, false) => queryable.OrderBy(_ => _.PkElectoralEvent),

					(Municipality, false) => queryable.OrderBy(_ => _.PkMunicipality),
					(Municipality, true) => queryable.OrderByDescending(_ => _.PkMunicipality),

					(Province, false) => queryable.OrderBy(_ => _.PkProvince),
					(Province, true) => queryable.OrderByDescending(_ => _.PkProvince),

					(Type, false) => queryable.OrderBy(_ => _.Type),
					(Type, true) => queryable.OrderByDescending(_ => _.Type),

					(VotersRegistered, false) => queryable.OrderByDescending(_ => _.VotersRegistered),
					(VotersRegistered, true) => queryable.OrderBy(_ => _.VotersRegistered),

					(VotesSection24A, false) => queryable.OrderByDescending(_ => _.VotesSection24A),
					(VotesSection24A, true) => queryable.OrderBy(_ => _.VotesSection24A),

					(VotesMEC7, false) => queryable.OrderByDescending(_ => _.VotesMEC7),
					(VotesMEC7, true) => queryable.OrderBy(_ => _.VotesMEC7),

					(VotesSpecial, false) => queryable.OrderByDescending(_ => _.VotesSpecial),
					(VotesSpecial, true) => queryable.OrderBy(_ => _.VotesSpecial),

					(VotesSpoilt, false) => queryable.OrderByDescending(_ => _.VotesSpoilt),
					(VotesSpoilt, true) => queryable.OrderBy(_ => _.VotesSpoilt),

					(VotesTotal, false) => queryable.OrderByDescending(_ => _.VotesTotal),
					(VotesTotal, true) => queryable.OrderBy(_ => _.VotesTotal),

					(VotingDistrict, false) => queryable.OrderByDescending(_ => _.PkVotingDistrict),
					(VotingDistrict, true) => queryable.OrderBy(_ => _.PkVotingDistrict),

					(Ward, false) => queryable.OrderBy(_ => _.PkWard),
					(Ward, true) => queryable.OrderByDescending(_ => _.PkWard),

					(_, _) => IECRest.OrderKeys.Order(queryable, orderkey, reverse)
				};
			}
			public static IQueryable<Language> Order(IQueryable<Language> queryable, bool reverse, params string[] orderkeys)
			{
				IOrderedQueryable<Language>? ordered = null;

				foreach (string orderkey in orderkeys)
					ordered = Order(ordered ?? queryable, orderkey, reverse);

				return ordered ?? queryable;
			}

			public new static IEnumerable<string> AsEnumerable()
			{
				return IECRest.OrderKeys.AsEnumerable()
					.Append(ElectoralEvent)
					.Append(Municipality)
					.Append(Province)
					.Append(Type)
					.Append(VotersRegistered)
					.Append(VotesSection24A)
					.Append(VotesMEC7)
					.Append(VotesSpecial)
					.Append(VotesSpoilt)
					.Append(VotesTotal)
					.Append(VotingDistrict)
					.Append(Ward);
			}
		}
	}
}
