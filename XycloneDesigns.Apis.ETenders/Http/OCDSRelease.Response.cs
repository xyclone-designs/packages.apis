using XycloneDesigns.Apis.ETenders.Models;

namespace XycloneDesigns.Apis.ETenders.Http
{
	public static partial class OCDSRelease
	{
		public abstract class Response : ETenders.Response 
		{
			public class Json
			{
				public const string Model = "model";
				public const string Name = "name";
				public const string Status = "status";
			}

			public Release? Release { get; set; }
		}
	}
}
