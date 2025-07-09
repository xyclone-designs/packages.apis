using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using XycloneDesigns.Apis.General.Http;

namespace XycloneDesigns.Apis.ETenders.Http.Rest
{
	public partial class OCDSReleases
	{
		public class RequestMultiple : ETendersRest.Request
		{
			public new const string Path = ETendersRest.Request.Path + "/OCDSReleases";

			public class Parameters
			{
				public const string DateFrom = "dateFrom";
				public const string DateTo = "dateTo";
				public const string PageNumber = "pageNumber";
				public const string PageSize = "pageSize";

				public static IEnumerable<string> AsEnumerable()
				{
					return Enumerable.Empty<string>()
						.Append(DateFrom)
						.Append(DateTo)
						.Append(PageNumber)
						.Append(PageSize);
				}
			}

			public DateTime? DateFrom { get; set; }
			public DateTime? DateTo { get; set; }
			public int? PageNumber { get; set; }
			public int? PageSize { get; set; }

			public override HttpRequestMessage ToHttpRequestMessage()
			{
				return new HttpRequestMessage
				{
					Method = HttpMethod.Get,
					RequestUri = new Uri(string.Format("{0}?{1}", Path, string.Join('&', new string?[]
					{
						DateFrom.HasValue ? string.Format("DateFrom={0:yyyy-MM-dd}", DateFrom.Value) : null,
						DateTo.HasValue ? string.Format("DateTo={0:yyyy-MM-dd}", DateTo.Value) : null,
						PageNumber.HasValue ? string.Format("PageNumber={0}", PageNumber.Value) : null,
						PageSize.HasValue ? string.Format("PageSize={0}", PageSize.Value) : null,

					}.OfType<string>())))
				};
			}
		}
		public class RequestSingle : ETendersRest.Request
		{
			public new const string Path = ETendersRest.Request.Path + "/OCDSReleases/release";

			public RequestSingle(string ocid)
			{
				Ocid = ocid;
			}

			public string Ocid { get; set; }

			public override HttpRequestMessage ToHttpRequestMessage()
			{
				return new HttpRequestMessage
				{
					Method = HttpMethod.Get,
					RequestUri = new Uri(string.Format("{0}/{1}", Path, Ocid))
				};
			}
		}
	}
}
