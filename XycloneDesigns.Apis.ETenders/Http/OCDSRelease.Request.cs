
namespace XycloneDesigns.Apis.ETenders.Http
{
	public static partial class OCDSRelease
	{
		public abstract class Request(string ocid) : ETenders.Request 
		{
			public string Ocid { get; set; } = ocid;
		}
	}
}
