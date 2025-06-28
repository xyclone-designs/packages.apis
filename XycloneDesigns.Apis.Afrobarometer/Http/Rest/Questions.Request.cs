using System.Collections.Generic;
using System.Linq;

namespace XycloneDesigns.Apis.Afrobarometer.Http.Rest
{
	public partial class Questions 
	{
		public class Request : AfrobarometerRest.Request
		{
			public new class Parameters : AfrobarometerRest.Request.Parameters
			{
				public const string Id = "id";
				public const string PkSurvey = "PkSurvey";
				public const string PkLanguage = "pkLanguage";
				public const string PkVariable = "pkVariable";

				public new static IEnumerable<string> AsEnumerable()
				{
					return AfrobarometerRest.Request.Parameters.AsEnumerable()
						.Append(Id)
						.Append(PkSurvey)
						.Append(PkLanguage)
						.Append(PkVariable);
				}
			}

			public string[]? Id { get; set; }
			public int[]? PkSurvey { get; set; }
			public int[]? PkLanguage { get; set; }
			public int[]? PkVariable { get; set; }
		}
	}
}
