using System;
using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Enums;
using XycloneDesigns.Apis.General.Http.Models;

namespace XycloneDesigns.Apis.General.Http.Rest
{
	public static class GeneralRest
	{
		public const string PathBase = "general/rest";

		public static IEnumerable<string> ToUriParameters(Base.Request request)
		{
			yield return string.Format("{0}={1}", Base.Request.Parameters.Page, request.Page);
			yield return string.Format("{0}={1}", Base.Request.Parameters.PageSize, request.PageSize);

			foreach (Filter filter in request.Filter)
				yield return string.Format("{0}={1}", Base.Request.Parameters.Filter, filter.AsString());

			foreach (Order orders in request.Order)
				yield return string.Format("{0}={1}", Base.Request.Parameters.Orders, orders.AsString());
		}

		public static IEnumerable<T> Filter<T>(this IEnumerable<T> enumerable, Func<T, Filter, bool> filter, params Filter[] filters)
		{
			if (filters.Length == 0)
				return enumerable;

			if (filters.All(__ => __.Operation == Operations.Equal))
				return enumerable.Where(_ => filters.Any(__ => filter(_, __)));

			return enumerable.Where(_ =>
			{
				return
					filters.Where(__ => __.Operation == Operations.Equal).Any(__ => filter(_, __)) ||
					filters.Where(__ => __.Operation != Operations.Equal).All(__ => filter(_, __));
			});
		}
	}
}
