using System.IO;

using Xunit;

using Newtonsoft.Json.Linq;

using XycloneDesigns.Apis.ETenders.Http.Rest;

namespace XycloneDesigns.Apis._Tests.ETenders
{
	public partial class OCDSReleasesTest
	{
		[Theory]
		[InlineData("ocdsreleases_multiple.json")]
		public async void JsonMultiple(string file)
		{
			string filepath = Path.Combine(Globals.CurrentDirectory, "ETenders", "datas", file);

			using FileStream filestream = File.OpenRead(filepath);
			using StreamReader streamreader = new(filestream);

			string json = await streamreader.ReadToEndAsync();

			JObject.Parse(json).ToObject<OCDSReleases.ResponseMultiple>();
		}

		[Theory]
		[InlineData("ocdsreleases_single.json")]
		public async void JsonSingle(string file)
		{
			string filepath = Path.Combine(Globals.CurrentDirectory, "ETenders", "datas", file);

			using FileStream filestream = File.OpenRead(filepath);
			using StreamReader streamreader = new(filestream);

			string json = await streamreader.ReadToEndAsync();

			JObject.Parse(json).ToObject<OCDSReleases.ResponseSingle>();
		}
	}
}