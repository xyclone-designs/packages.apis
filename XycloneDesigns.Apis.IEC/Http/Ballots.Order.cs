using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Models;
using XycloneDesigns.Apis.General.Http;
using XycloneDesigns.Apis.IEC.Tables;

namespace XycloneDesigns.Apis.IEC.Http
{
	public static partial class Ballots
	{
		public class Orders : GeneralBase.Orders
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
				return GeneralBase.Orders.AsEnumerable()
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

		public static IOrderedEnumerable<Ballot> Order(this IEnumerable<Ballot> queryable, params Order[] orders)
		{
			IOrderedEnumerable<Ballot>? orderedqueryable = null;

			foreach (Order order in orders)
				orderedqueryable = orderedqueryable is not null
					? orderedqueryable.Order(order)
					: (order.Key, order.Descending) switch
					{
						(Orders.PkElectoralEvent, false) => queryable.OrderBy(_ => _.PkElectoralEvent),
						(Orders.PkElectoralEvent, true) => queryable.OrderByDescending(_ => _.PkElectoralEvent),

						(Orders.PkMunicipality, false) => queryable.OrderBy(_ => _.PkMunicipality),
						(Orders.PkMunicipality, true) => queryable.OrderByDescending(_ => _.PkMunicipality),

						(Orders.PkProvince, false) => queryable.OrderBy(_ => _.PkProvince),
						(Orders.PkProvince, true) => queryable.OrderByDescending(_ => _.PkProvince),

						(Orders.PkVotingDistrict, false) => queryable.OrderBy(_ => _.PkVotingDistrict),
						(Orders.PkVotingDistrict, true) => queryable.OrderByDescending(_ => _.PkVotingDistrict),

						(Orders.PkWard, false) => queryable.OrderBy(_ => _.PkWard),
						(Orders.PkWard, true) => queryable.OrderByDescending(_ => _.PkWard),

						(Orders.Type, false) => queryable.OrderBy(_ => _.Type),
						(Orders.Type, true) => queryable.OrderByDescending(_ => _.Type),

						(Orders.VotersRegistered, false) => queryable.OrderBy(_ => _.VotersRegistered),
						(Orders.VotersRegistered, true) => queryable.OrderByDescending(_ => _.VotersRegistered),

						(Orders.VotesMEC7, false) => queryable.OrderBy(_ => _.VotesMEC7),
						(Orders.VotesMEC7, true) => queryable.OrderByDescending(_ => _.VotesMEC7),

						(Orders.VotesSection24A, false) => queryable.OrderBy(_ => _.VotesSection24A),
						(Orders.VotesSection24A, true) => queryable.OrderByDescending(_ => _.VotesSection24A),

						(Orders.VotesSpecial, false) => queryable.OrderBy(_ => _.VotesSpecial),
						(Orders.VotesSpecial, true) => queryable.OrderByDescending(_ => _.VotesSpecial),

						(Orders.VotesSpoilt, false) => queryable.OrderBy(_ => _.VotesSpoilt),
						(Orders.VotesSpoilt, true) => queryable.OrderByDescending(_ => _.VotesSpoilt),

						(Orders.VotesTotal, false) => queryable.OrderBy(_ => _.VotesTotal),
						(Orders.VotesTotal, true) => queryable.OrderByDescending(_ => _.VotesTotal),

						(Orders.VotesValid, false) => queryable.OrderBy(_ => _.VotesValid),
						(Orders.VotesValid, true) => queryable.OrderByDescending(_ => _.VotesValid),

						(_, _) => queryable.Order<Ballot>(order)
					};

			return orderedqueryable ?? queryable.Order<Ballot>(orders);
		}
		public static IOrderedEnumerable<Ballot> Order(this IOrderedEnumerable<Ballot> queryable, params Order[] orders)
		{
			IOrderedEnumerable<Ballot>? orderedqueryable = null;

			foreach (Order order in orders)
				orderedqueryable = (order.Key, order.Descending) switch
				{
					(Orders.PkElectoralEvent, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.PkElectoralEvent),
					(Orders.PkElectoralEvent, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.PkElectoralEvent),

					(Orders.PkMunicipality, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.PkMunicipality),
					(Orders.PkMunicipality, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.PkMunicipality),

					(Orders.PkProvince, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.PkProvince),
					(Orders.PkProvince, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.PkProvince),

					(Orders.PkVotingDistrict, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.PkVotingDistrict),
					(Orders.PkVotingDistrict, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.PkVotingDistrict),
						
					(Orders.PkWard, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.PkWard),
					(Orders.PkWard, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.PkWard),

					(Orders.Type, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.Type),
					(Orders.Type, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.Type),

					(Orders.VotersRegistered, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.VotersRegistered),
					(Orders.VotersRegistered, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.VotersRegistered),

					(Orders.VotesMEC7, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.VotesMEC7),
					(Orders.VotesMEC7, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.VotesMEC7),
						
					(Orders.VotesSection24A, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.VotesSection24A),
					(Orders.VotesSection24A, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.VotesSection24A),

					(Orders.VotesSpecial, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.VotesSpecial),
					(Orders.VotesSpecial, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.VotesSpecial),

					(Orders.VotesSpoilt, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.VotesSpoilt),
					(Orders.VotesSpoilt, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.VotesSpoilt),

					(Orders.VotesTotal, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.VotesTotal),
					(Orders.VotesTotal, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.VotesTotal),
						
					(Orders.VotesValid, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.VotesValid),
					(Orders.VotesValid, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.VotesValid),

					(_, _) => (orderedqueryable ?? queryable).Order<Ballot>(order)
				};

			return orderedqueryable ?? queryable;
		}
	}
}
