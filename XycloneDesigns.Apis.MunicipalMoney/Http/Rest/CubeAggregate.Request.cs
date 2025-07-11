using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

using XycloneDesigns.Apis.MunicipalMoney.Http.Rest;

namespace XycloneDesigns.Apis.MunicipalMoney.Http.Rest
{
	public partial class CubeAggregate
	{
		public class Request : MunicipalMoneyRest.Request
		{
			public class Parameters
			{
				public const string Aggregates = "aggregates";
				public const string Cut = "cut";
				public const string Format = "format";
				public const string Page = "page";
				public const string PageSize = "pageSize";
				public const string Order = "order";

				public static IEnumerable<string> AsEnumerable()
				{
					return Enumerable.Empty<string>()
						.Append(Aggregates)
						.Append(Cut)
						.Append(Format)
						.Append(Page)
						.Append(PageSize)
						.Append(Order);
				}
			}

			public Request(string cubename)
			{
				CubeName = cubename;
			}

			public string CubeName { get; set; }
			public List<string>? Aggregates { get; set; }
			public Dictionary<string, object>? Cut { get; set; }
			public List<string>? Drilldown { get; set; }
			public string? Format { get; set; }
			public int? Page { get; set; }
			public int? PageSize { get; set; }
			public Dictionary<string, bool>? Order { get; set; }

			public override HttpRequestMessage ToHttpRequestMessage()
			{
				return new HttpRequestMessage
				{
					Method = HttpMethod.Get,
					RequestUri = new Uri(string.Format("{0}/{1}/aggregate?{2}", Path, CubeName, string.Join('&', new string?[]
					{
						Aggregates is null ? null : string.Format("aggregates={0}", string.Join('|', Aggregates.Select(_ =>
						{
							return string.Format("{0}.sum", _);
						}))),
						Cut is null ? null : string.Format("cut={0}", string.Join('|', Cut.Select(_ =>
						{
							return string.Format("{0}:\"{1}\"", _.Key, _.Value);
						}))),
						Drilldown is null ? null : string.Format("drilldown={0}", string.Join('|', Drilldown)),
						Format is not null ? string.Format("format={0}", Format) : null,
						Page.HasValue ? string.Format("page={0}", Page.Value) : null,
						PageSize.HasValue ? string.Format("pageSize={0}", PageSize.Value) : null,
						Order is null ? null : string.Format("order={0}", string.Join(',', Order.Select(_ =>
						{
							return string.Format("{0}:{1}", _.Key, _.Value ? "asc" : "desc");
						})))

					}.OfType<string>())))
				};
			}
		}
	}
}
