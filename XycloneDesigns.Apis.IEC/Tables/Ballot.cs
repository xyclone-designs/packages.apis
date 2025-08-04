using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.IEC.Tables
{
	[SQLite.Table(SQL.Table)]
	public class Ballot : IECTable
	{
		public class Types
		{
            public const string Municipal = "municipal";
            public const string MunicipalDC40 = "municipal.DC40";
            public const string MunicipalDMADC60 = "municipal.DMADC60";
            public const string MunicipalPR = "municipal.PR";
            public const string MunicipalWard = "municipal.Ward";
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

			public static IEnumerable<string> All()
			{
				yield return Municipal;
				yield return MunicipalDC40;
				yield return MunicipalDMADC60;
				yield return MunicipalPR;
				yield return MunicipalWard;
				yield return National;
				yield return NationalEC;
				yield return NationalFS;
				yield return NationalGT;
				yield return NationalKZN;
				yield return NationalLIM;
				yield return NationalMP;
				yield return NationalNC;
				yield return NationalNW;
				yield return NationalWC;
				yield return Provincial;
				yield return ProvincialEC;
				yield return ProvincialFS;
				yield return ProvincialGT;
				yield return ProvincialKZN;
				yield return ProvincialLIM;
				yield return ProvincialMP;
				yield return ProvincialNC;
				yield return ProvincialNW;
				yield return ProvincialWC;
				yield return Regional;
				yield return RegionalEC;
				yield return RegionalFS;
				yield return RegionalGT;
				yield return RegionalKZN;
				yield return RegionalLIM;
				yield return RegionalMP;
				yield return RegionalNC;
				yield return RegionalNW;
				yield return RegionalWC;
			}
		}
		public new class SQL : IECTable.SQL
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

			public new static IEnumerable<string> Columns()
			{
				foreach (string columns in IECTable.SQL.Columns())
					yield return columns;

				yield return Column_List_PkParty_Votes;
				yield return Column_List_PkParty_Seats;
				yield return Column_PkElectoralEvent;
				yield return Column_PkMunicipality;
				yield return Column_PkProvince;
				yield return Column_PkVotingDistrict;
				yield return Column_PkWard;
				yield return Column_Type;
				yield return Column_VotersRegistered;
				yield return Column_VotesMEC7;
				yield return Column_VotesSection24A;
				yield return Column_VotesSpecial;
				yield return Column_VotesSpoilt;
				yield return Column_VotesTotal;
				yield return Column_VotesValid;
			}
		}

		private int? _VotersRegistered;
        private int? _VotesMEC7;
        private int? _VotesSection24A;
        private int? _VotesSpecial;
        private int? _VotesSpoilt;
        private int? _VotesTotal;
        private int? _VotesValid;

		[JsonProperty(SQL.Column_List_PkParty_Votes), JsonPropertyName(SQL.Column_List_PkParty_Votes), SQLite.Column(SQL.Column_List_PkParty_Votes)] public string? List_PkParty_Votes { get; set; }
		[JsonProperty(SQL.Column_List_PkParty_Seats), JsonPropertyName(SQL.Column_List_PkParty_Seats), SQLite.Column(SQL.Column_List_PkParty_Seats)] public string? List_PkParty_Seats { get; set; }
		[JsonProperty(SQL.Column_PkElectoralEvent), JsonPropertyName(SQL.Column_PkElectoralEvent), SQLite.Column(SQL.Column_PkElectoralEvent)] public int? PkElectoralEvent { get; set; }
        [JsonProperty(SQL.Column_PkMunicipality), JsonPropertyName(SQL.Column_PkMunicipality), SQLite.Column(SQL.Column_PkMunicipality)] public int? PkMunicipality { get; set; }
        [JsonProperty(SQL.Column_PkProvince), JsonPropertyName(SQL.Column_PkProvince), SQLite.Column(SQL.Column_PkProvince)] public int? PkProvince { get; set; }
        [JsonProperty(SQL.Column_PkVotingDistrict), JsonPropertyName(SQL.Column_PkVotingDistrict), SQLite.Column(SQL.Column_PkVotingDistrict)] public int? PkVotingDistrict { get; set; }
        [JsonProperty(SQL.Column_PkWard), JsonPropertyName(SQL.Column_PkWard), SQLite.Column(SQL.Column_PkWard)] public int? PkWard { get; set; }
        [JsonProperty(SQL.Column_Type), JsonPropertyName(SQL.Column_Type), SQLite.Column(SQL.Column_Type)] public string? Type { get; set; }
        [JsonProperty(SQL.Column_VotersRegistered), JsonPropertyName(SQL.Column_VotersRegistered), SQLite.Column(SQL.Column_VotersRegistered)] public int? VotersRegistered 
        {
            set => _VotersRegistered = value;
            get => _VotersRegistered;
        }
        [JsonProperty(SQL.Column_VotesMEC7), JsonPropertyName(SQL.Column_VotesMEC7), SQLite.Column(SQL.Column_VotesMEC7)] public int? VotesMEC7 
        { 
            set => _VotesMEC7 = value;
            get => _VotesMEC7;
        }
        [JsonProperty(SQL.Column_VotesSection24A), JsonPropertyName(SQL.Column_VotesSection24A), SQLite.Column(SQL.Column_VotesSection24A)] public int? VotesSection24A 
        { 
            set => _VotesSection24A = value;
            get => _VotesSection24A;
        }
        [JsonProperty(SQL.Column_VotesSpecial), JsonPropertyName(SQL.Column_VotesSpecial), SQLite.Column(SQL.Column_VotesSpecial)] public int? VotesSpecial 
        { 
            set => _VotesSpecial = value;
            get => _VotesSpecial;
        }
        [JsonProperty(SQL.Column_VotesSpoilt), JsonPropertyName(SQL.Column_VotesSpoilt), SQLite.Column(SQL.Column_VotesSpoilt)] public int? VotesSpoilt 
        { 
            set => _VotesSpoilt = value;
            get => _VotesSpoilt ??= true switch
            {
                true when VotesValid is not null && _VotesTotal is not null => _VotesTotal - VotesValid,

                _ => new int?()
            };
        }
        [JsonProperty(SQL.Column_VotesTotal), JsonPropertyName(SQL.Column_VotesTotal), SQLite.Column(SQL.Column_VotesTotal)] public int? VotesTotal 
        { 
            set => _VotesTotal = value;
            get => _VotesTotal ??= true switch
            {
                true when VotesValid is not null && _VotesSpoilt is null => VotesValid,
                true when VotesValid is not null && _VotesSpoilt is not null => VotesValid + _VotesSpoilt,

                _ => new int?()
            };
        }
        [JsonProperty(SQL.Column_VotesValid), JsonPropertyName(SQL.Column_VotesValid), SQLite.Column(SQL.Column_VotesValid)] public int? VotesValid 
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