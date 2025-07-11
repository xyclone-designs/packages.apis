using System.IO;

namespace XycloneDesigns.Apis._Tests
{
	public class Globals 
	{
		public static readonly string CurrentDirectory = Path.Combine(Directory.GetCurrentDirectory().Split('\\')[0..^3]);
	}
}