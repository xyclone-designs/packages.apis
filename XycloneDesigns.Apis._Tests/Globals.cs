using System.IO;
using System.Net.Http;

namespace XycloneDesigns.Apis._Tests
{
	public class Globals 
	{
		public static readonly string Directory = Path.Combine(System.IO.Directory.GetCurrentDirectory().Split('\\')[0..^3]);
		public static readonly HttpClient HttpClient = new();
	}
}