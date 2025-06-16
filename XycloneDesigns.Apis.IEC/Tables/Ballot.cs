using System;
using System.Collections.Generic;
using System.Linq;

namespace XycloneDesigns.Apis.IEC.Tables
{
	[SQLite.Table(SQL.Table)]
	public class Ballot : _Table
	{
		public new class SQL
		{
			public const string Table = "ballots";

			public const string Column_List_PkParty_Votes = "list_pkParty_Votes";
			public const string Column_List_PkParty_Seats = "list_pkParty_seats";
			public const string Column_PkElectoralEvent = "pkElectoralEvent";
			public const string Column_PkMunicipality = "pkMunicipality";
			public const string Column_PkProvince = "pkProvince";
			public const string Column_PkVotingDistrict = "pkVotingDistrict";
			public const string Column_PkWard = "pkWard";
			public const string Column_Type = "type";
			public const string Column_VotersRegistered = "votersRegistered";
			public const string Column_VotesMEC7 = "votesMEC7";
			public const string Column_VotesSection24A = "votesSection24A";
			public const string Column_VotesSpecial = "votesSpecial";
			public const string Column_VotesSpoilt = "votesSpoilt";
			public const string Column_VotesTotal = "votesTotal";
			public const string Column_VotesValid = "votesValid";
		}

		private int? _VotersRegistered;
        private int? _VotesMEC7;
        private int? _VotesSection24A;
        private int? _VotesSpecial;
        private int? _VotesSpoilt;
        private int? _VotesTotal;
        private int? _VotesValid;

		[SQLite.Column(SQL.Column_List_PkParty_Votes)] public string? List_PkParty_Votes { get; set; }
		[SQLite.Column(SQL.Column_List_PkParty_Seats)] public string? List_PkParty_Seats { get; set; }
		[SQLite.Column(SQL.Column_PkElectoralEvent)] public int? PkElectoralEvent { get; set; }
        [SQLite.Column(SQL.Column_PkMunicipality)] public int? PkMunicipality { get; set; }
        [SQLite.Column(SQL.Column_PkProvince)] public int? PkProvince { get; set; }
        [SQLite.Column(SQL.Column_PkVotingDistrict)] public int? PkVotingDistrict { get; set; }
        [SQLite.Column(SQL.Column_PkWard)] public int? PkWard { get; set; }
        [SQLite.Column(SQL.Column_Type)] public string? Type { get; set; }
        [SQLite.Column(SQL.Column_VotersRegistered)] public int? VotersRegistered 
        {
            set => _VotersRegistered = value;
            get => _VotersRegistered;
        }
        [SQLite.Column(SQL.Column_VotesMEC7)] public int? VotesMEC7 
        { 
            set => _VotesMEC7 = value;
            get => _VotesMEC7;
        }
        [SQLite.Column(SQL.Column_VotesSection24A)] public int? VotesSection24A 
        { 
            set => _VotesSection24A = value;
            get => _VotesSection24A;
        }
        [SQLite.Column(SQL.Column_VotesSpecial)] public int? VotesSpecial 
        { 
            set => _VotesSpecial = value;
            get => _VotesSpecial;
        }
        [SQLite.Column(SQL.Column_VotesSpoilt)] public int? VotesSpoilt 
        { 
            set => _VotesSpoilt = value;
            get => _VotesSpoilt ??= true switch
            {
                true when VotesValid is not null && _VotesTotal is not null => _VotesTotal - VotesValid,

                _ => new int?()
            };
        }
        [SQLite.Column(SQL.Column_VotesTotal)] public int? VotesTotal 
        { 
            set => _VotesTotal = value;
            get => _VotesTotal ??= true switch
            {
                true when VotesValid is not null && _VotesSpoilt is null => VotesValid,
                true when VotesValid is not null && _VotesSpoilt is not null => VotesValid + _VotesSpoilt,

                _ => new int?()
            };
        }
        [SQLite.Column(SQL.Column_VotesValid)] public int? VotesValid 
        { 
            set => _VotesValid = value;
            get => _VotesValid ??= List_PkParty_Votes?
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .Select(_ => int.Parse(_.Split(':')[1]))
                .Sum();
        }

        public void UpdateBallot(Ballot ballot)
        {
            if (VotersRegistered is null) VotersRegistered = ballot.VotersRegistered;
            else VotersRegistered += ballot.VotersRegistered ?? 0;
            if (VotesMEC7 is null) VotesMEC7 = ballot.VotesMEC7;
            else VotesMEC7 += ballot.VotesMEC7 ?? 0;
            if (VotesSection24A is null) VotesSection24A = ballot.VotesSection24A;
            else VotesSection24A += ballot.VotesSection24A ?? 0;
            if (VotesSpecial is null) VotesSpecial = ballot.VotesSpecial;
            else VotesSpecial += ballot.VotesSpecial ?? 0;
            if (VotesSpoilt is null) VotesSpoilt = ballot.VotesSpoilt;
            else VotesSpoilt += ballot.VotesSpoilt ?? 0;
            if (VotesTotal is null) VotesTotal = ballot.VotesTotal;
            else VotesTotal += ballot.VotesTotal ?? 0;
            if (VotesValid is null) VotesValid = ballot.VotesValid;
            else VotesValid += ballot.VotesValid ?? 0;

            UpdatePartyVotes(ballot.List_PkParty_Votes);
        }
        public void UpdatePartyVotes(string? listPkPartyVotes)
        {
            if (List_PkParty_Votes is null) List_PkParty_Votes = listPkPartyVotes;
            else if (listPkPartyVotes is not null)
            {
                Dictionary<int, long> pairs = List_PkParty_Votes
					.Split(",")
                    .Select(_pkPair => _pkPair.Split(":"))
                    .ToDictionary(_pkPair => int.Parse(_pkPair[0]), _pkPair => long.Parse(_pkPair[1]));

                foreach (string[] pkVote in listPkPartyVotes
                    .Split(",")
                    .Select(_pkVote => _pkVote.Split(":")))
                {
                    int pk = int.Parse(pkVote[0]);
                    pairs.TryAdd(pk, 0);
                    pairs[pk] += long.Parse(pkVote[1]);
                }

				List_PkParty_Votes = string.Join(',', pairs.Select(pair => string.Format("{0}:{1}", pair.Key, pair.Value)));
            }
        }
    }
}