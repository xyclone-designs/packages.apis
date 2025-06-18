using System;

namespace XycloneDesigns.Apis.Afrobarometer.Enums
{
	[SQLite.StoreAsText]
	public enum Rounds
	{
		_default,

		One,
		OnePointFive,
		_One = One | OnePointFive,
		Two,
		Three,
		ThreePointFive,
		_Three = Three | ThreePointFive,
		Four,
		FourPointFive,
		FourPointFiveOne,
		FourPointFiveTwo,
		_Four = Four | FourPointFive | FourPointFiveOne | FourPointFiveTwo,
		Five,
		Six,
		Seven,
		Eight,
		Nine,
		Ten,
	}

	public static class RoundsExtensions
	{
		public static int ToInt(this Rounds round)
		{
			return round switch
			{
				Rounds._default => 0,

				Rounds.One or Rounds.OnePointFive or Rounds._One => 01,
				Rounds.Two => 02,
				Rounds.Three or Rounds.ThreePointFive or Rounds._Three => 03,
				Rounds.Four or Rounds.FourPointFive or Rounds.FourPointFiveOne or Rounds.FourPointFiveTwo or Rounds._Four => 04,
				Rounds.Five => 05,
				Rounds.Six => 06,
				Rounds.Seven => 07,
				Rounds.Eight => 08,
				Rounds.Nine => 09,
				Rounds.Ten => 10,

				_ => throw new ArgumentException(string.Format("Round '{0}' not found", round))
			};
		}
	}
}