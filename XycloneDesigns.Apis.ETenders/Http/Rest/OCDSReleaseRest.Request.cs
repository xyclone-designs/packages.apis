using System;
using System.Net.Http;

namespace XycloneDesigns.Apis.ETenders.Http.Rest
{
	public partial class OCDSReleaseRest
	{
		public const string Path = "OCDSReleases/release";

		public class Request(string ocid) : OCDSRelease.Request(ocid)
		{
			public override HttpRequestMessage ToHttpRequestMessage(string? pathbase = null, string? path = null)
			{
				return new HttpRequestMessage
				{
					Method = HttpMethod.Get,
					RequestUri = new Uri(string.Format("{0}/{1}/{2}", pathbase ?? ETendersRest.Path, path ?? Path, Ocid))
				};
			}
		}
	}
}
