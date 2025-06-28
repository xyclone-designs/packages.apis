using System.Linq;
using System.Collections.Generic;

namespace XycloneDesigns.Apis.General.Http.Rest
{
	public partial class Provinces 
	{
		public class Request : GeneralRest.Request
		{
			public new class Parameters : GeneralRest.Request.Parameters
			{
				public const string Id = "id";

				public new static IEnumerable<string> AsEnumerable()
				{
					return GeneralRest.Request.Parameters.AsEnumerable()
						.Append(Id);
				}
			}

			public string[]? Id { get; set; }
		}
	}
}
