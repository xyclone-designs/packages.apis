using System.Net.Http;

namespace XycloneDesigns.Apis.General.Http
{
	public class ApiRequest 
	{
		public virtual HttpRequestMessage ToHttpRequestMessage()
		{
			return new HttpRequestMessage { };
		}
	}
	public class ApiRequest<T>
	{
		public ApiRequest(T defaultValue) { }

		public virtual HttpRequestMessage ToHttpRequestMessage()
		{
			return new HttpRequestMessage { };
		}
	}
}
