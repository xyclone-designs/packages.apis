using System.Linq;
using System.Collections.Generic;

namespace XycloneDesigns.Apis.Afrobarometer.Http.Rest
{
	public partial class Interviews 
	{
		public class Request : AfrobarometerRest.Request
		{
			public new class Parameters : AfrobarometerRest.Request.Parameters
			{
				public const string PkLanguage = "pkLanguage";
				public const string PkSurvey = "pkSurvey";
				public const string PkVariable = "pkVariable";
				public const string Round = "round";

				public new static IEnumerable<string> AsEnumerable()
				{
					return AfrobarometerRest.Request.Parameters.AsEnumerable()
						.Append(PkLanguage)
						.Append(PkSurvey)
						.Append(PkVariable)
						.Append(Round);
				}
			}

			public int[]? PkLanguage { get; set; }
			public int[]? PkSurvey { get; set; }
			public int[]? PkVariable { get; set; }
			public string[]? Round { get; set; }
		}
	}
}
