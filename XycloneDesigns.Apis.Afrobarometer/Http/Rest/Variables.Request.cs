using System.Linq;
using System.Collections.Generic;

namespace XycloneDesigns.Apis.Afrobarometer.Http.Rest
{
	public partial class Variables 
	{
		public class Request : AfrobarometerRest.Request
		{
			public new class Parameters : AfrobarometerRest.Request.Parameters
			{
				public const string Id = "id";

				public new static IEnumerable<string> AsEnumerable()
				{
					return AfrobarometerRest.Request.Parameters.AsEnumerable()
						.Append(Id);
				}
			}

			public string[]? Id { get; set; }
		}
	}
}
