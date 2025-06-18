using System;

using XycloneDesigns.Apis.STATSSA.Enums;
using XycloneDesigns.Apis.STATSSA.Models;
using XycloneDesigns.Apis.STATSSA.Structs;

namespace XycloneDesigns.Apis.STATSSA.Tables
{
	[SQLite.Table(SQL.Table)]
    public class RecordsMortality : Records
	{
		public new static class SQL
		{
			public const string Table = "records_mortality";

			public const string Column_AgeOfDeceased = "ageofdeceased";
			public const string Column_AnybodyDied = "anybodydied";
			public const string Column_DateOfDeath = "dateofdeath";
			public const string Column_Gender = "gender";
			public const string Column_HowManyDied = "howmanydied";
			public const string Column_ImputationFlags = "imputationflags";
			public const string Column_WasDeathFromViolence = "wasdeathfromviolence";
			public const string Column_WasPregnantWhenDeceased = "waspregnantwhendeceased";
		}

		[SQLite.Column(SQL.Column_AgeOfDeceased)] public int? AgeOfDeceased { get; set; }
		[SQLite.Column(SQL.Column_AnybodyDied)] public int? AnybodyDied { get; set; }
		[SQLite.Column(SQL.Column_DateOfDeath)] public DateTime? DateOfDeath { get; set; }
		[SQLite.Column(SQL.Column_Gender)] public int? Gender { get; set; }
		[SQLite.Column(SQL.Column_HowManyDied)] public int? HowManyDied { get; set; }
		[SQLite.Column(SQL.Column_ImputationFlags)] public int? ImputationFlags { get; set; }
		[SQLite.Column(SQL.Column_WasDeathFromViolence)] public int? WasDeathFromViolence { get; set; }
		[SQLite.Column(SQL.Column_WasPregnantWhenDeceased)] public int? WasPregnantWhenDeceased { get; set; }

		public RecordMortality ToModel()
		{
			return new RecordMortality
			{
				AgeOfDeceased = Uncertain.From<int>(AgeOfDeceased),
				AnybodyDied = Uncertain.From<bool>(AnybodyDied),
				DateOfDeath = DateOfDeath,
				Gender = Uncertain.From<Sexes>(Gender),
				HowManyDied = Uncertain.From<int>(HowManyDied),
				ImputationFlags = Uncertain.From<ImputationFlags>(ImputationFlags),
				WasDeathFromViolence = Uncertain.From<bool>(WasDeathFromViolence),
				WasPregnantWhenDeceased = Uncertain.From<bool>(WasPregnantWhenDeceased),
			};
		}
		public void FromModel(RecordMortality record)
		{
			AgeOfDeceased = record.AgeOfDeceased?.ToInt(_ => _);
			AnybodyDied = record.AnybodyDied?.ToInt();
			DateOfDeath  = record.DateOfDeath;
			Gender = record.Gender?.ToInt(_ => (int?)_);
			HowManyDied = record.HowManyDied?.ToInt(_ => _);
			ImputationFlags = record.ImputationFlags?.ToInt(_ => (int?)_);
			WasDeathFromViolence  = record.WasDeathFromViolence?.ToInt();
			WasPregnantWhenDeceased = record.WasPregnantWhenDeceased?.ToInt();
		}
	}
}