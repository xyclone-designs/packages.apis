
namespace XycloneDesigns.Apis.General.Http
{
	public class ApiResponse 
	{
		public ApiResponse() { }
		public ApiResponse(string response) { }
	}
	public class ApiResponse<T>
	{
		public ApiResponse(T defaultValue) { }
		public ApiResponse(T defaultValue, string response) { }
	}
}
