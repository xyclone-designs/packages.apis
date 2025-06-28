using System.Linq;
using System.Collections.Generic;

namespace XycloneDesigns.Apis.Afrobarometer.Http.Rest
{
	public partial class Surveys 
	{
		public class Request : AfrobarometerRest.Request
		{
			public new class Parameters : AfrobarometerRest.Request.Parameters
			{
				public const string PkCountry = "PkCountry";
				public const string PkLanguage = "PkLanguage";
				public const string PkQuestion = "PkQuestion";
				public const string PkVariable = "PkVariable";
				public const string Round = "Round";

				public new static IEnumerable<string> AsEnumerable()
				{
					return AfrobarometerRest.Request.Parameters.AsEnumerable()
						.Append(PkCountry)
						.Append(PkLanguage)
						.Append(PkQuestion)
						.Append(PkVariable)
						.Append(Round);
				}
			}

			public int[]? PkCountry { get; set; }
			public int[]? PkLanguage { get; set; }
			public int[]? PkQuestion { get; set; }
			public int[]? PkVariable { get; set; }
			public string[]? Round { get; set; }
		}
	}
}
