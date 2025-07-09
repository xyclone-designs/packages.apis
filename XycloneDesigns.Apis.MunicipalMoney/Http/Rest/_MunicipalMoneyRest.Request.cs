using XycloneDesigns.Apis.General.Http;

namespace XycloneDesigns.Apis.MunicipalMoney.Http.Rest
{
	public partial class MunicipalMoneyRest
	{
		public class Request : ApiRequest 
		{
			public const string Path = "https://municipaldata.treasury.gov.za/api";
		}
	}
}
