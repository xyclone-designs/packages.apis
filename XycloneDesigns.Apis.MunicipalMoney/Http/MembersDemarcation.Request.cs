using System.Collections.Generic;
using System.Linq;

namespace XycloneDesigns.Apis.MunicipalMoney.Http
{
	public partial class MembersDemarcation
	{
		public abstract class Request(string cubename, string cubemembername) : MunicipalMoney.Request
		{
			public new class Parameters : MunicipalMoney.Request.Parameters
			{
				public const string Cut = "cut";
				public const string Format = "format";
				public const string Page = "page";
				public const string PageSize = "pageSize";
				public const string Order = "order";

				public new static IEnumerable<string> AsEnumerable()
				{
					return MunicipalMoney.Request.Parameters.AsEnumerable()
						.Append(Cut)
						.Append(Format)
						.Append(Page)
						.Append(PageSize)
						.Append(Order);
				}
			}

			public string CubeName { get; set; } = cubename;
			public string CubeMemberName { get; set; }= cubemembername;
			public List<Models.Cut> Cut { get; set; } = [];
			public string? Format { get; set; }
			public int? Page { get; set; }
			public int? PageSize { get; set; }
			public List<Models.Order> Order { get; set; } = [];
		}
	}
}
