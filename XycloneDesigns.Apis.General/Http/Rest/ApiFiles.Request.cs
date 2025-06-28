using System.Linq;
using System.Collections.Generic;
using System;

namespace XycloneDesigns.Apis.General.Http.Rest
{
	public partial class ApiFiles
	{
		public class Request : GeneralRest.Request
		{
			public new class Parameters : GeneralRest.Request.Parameters
			{
				public const string CreatedAfter = "CreatedAfter";
				public const string CreatedBefore = "CreatedBefore";

				public new static IEnumerable<string> AsEnumerable()
				{
					return GeneralRest.Request.Parameters.AsEnumerable()
						.Append(CreatedAfter)
						.Append(CreatedBefore);
				}
			}

			public DateTime? CreatedAfter { get; set; }
			public DateTime? CreatedBefore { get; set; }
		}
	}
}
