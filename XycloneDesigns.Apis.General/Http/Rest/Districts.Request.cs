using System.Linq;
using System.Collections.Generic;

namespace XycloneDesigns.Apis.General.Http.Rest
{
	public partial class Districts 
	{
		public class Request : GeneralRest.Request
		{
			public new class Parameters : GeneralRest.Request.Parameters
			{
				public const string Code = "code";

				public new static IEnumerable<string> AsEnumerable()
				{
					return GeneralRest.Request.Parameters.AsEnumerable()
						.Append(Code);
				}
			}

			public string[]? Code { get; set; }
		}
	}
}
