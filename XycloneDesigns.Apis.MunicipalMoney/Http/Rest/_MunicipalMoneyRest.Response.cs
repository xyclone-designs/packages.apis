using XycloneDesigns.Apis.General.Http;

namespace XycloneDesigns.Apis.MunicipalMoney.Http.Rest
{
	public partial class MunicipalMoneyRest
	{
		public class Response : ApiResponse 
		{
			public Response() : base() { }
			public Response(string response) : base(response) { }
		}
	}
}
