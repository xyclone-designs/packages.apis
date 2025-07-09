using System.Net.Http;

using XycloneDesigns.Apis.General.Http;

namespace XycloneDesigns.Apis.ETenders.Http.Rest
{
	public partial class ETendersRest
	{
		public class Response : ApiResponse 
		{
			public Response() : base() { }
			public Response(string response) : base(response) { }
			public Response(HttpResponseMessage response) : base(response) { }
		}
	}
}
