using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Models;
using XycloneDesigns.Apis.General.Http;
using XycloneDesigns.Apis.IEC.Tables;

namespace XycloneDesigns.Apis.IEC.Http
{
	public static partial class Parties
	{
		public class Orders : GeneralBase.Orders
		{
			public const string Abbr = Party.SQL.Column_Abbr;
			public const string Name = Party.SQL.Column_Name;
			public const string DateEstablished = Party.SQL.Column_DateEstablished;
			public const string DateDisestablished = Party.SQL.Column_DateDisestablished;
			public const string Headquarters = Party.SQL.Column_Headquarters;
			public const string List_PkElectoralEvent = Party.SQL.Column_List_PkElectoralEvent;
			public const string UrlWebsite = Party.SQL.Column_UrlWebsite;
			public const string UrlLogo = Party.SQL.Column_UrlLogo;

			public new static IEnumerable<string> AsEnumerable()
			{
				return GeneralBase.Orders.AsEnumerable()
					.Append(Abbr)
					.Append(Name)
					.Append(DateEstablished)
					.Append(DateDisestablished)
					.Append(Headquarters)
					.Append(List_PkElectoralEvent)
					.Append(UrlWebsite)
					.Append(UrlLogo);
			}
		}

		public static IOrderedEnumerable<Party> Order(this IEnumerable<Party> queryable, params Order[] orders)
		{
			IOrderedEnumerable<Party>? orderedqueryable = null;

			foreach (Order order in orders)
				orderedqueryable = orderedqueryable is not null
					? orderedqueryable.Order(order)
					: (order.Key, order.Descending) switch
					{
						(Orders.Abbr, false) => queryable.OrderBy(_ => _.Abbr),
						(Orders.Abbr, true) => queryable.OrderByDescending(_ => _.Abbr),

						(Orders.Name, false) => queryable.OrderBy(_ => _.Name),
						(Orders.Name, true) => queryable.OrderByDescending(_ => _.Name),

						(Orders.DateEstablished, false) => queryable.OrderBy(_ => _.DateEstablished),
						(Orders.DateEstablished, true) => queryable.OrderByDescending(_ => _.DateEstablished),

						(Orders.DateDisestablished, false) => queryable.OrderBy(_ => _.DateDisestablished),
						(Orders.DateDisestablished, true) => queryable.OrderByDescending(_ => _.DateDisestablished),

						(Orders.Headquarters, false) => queryable.OrderBy(_ => _.Headquarters),
						(Orders.Headquarters, true) => queryable.OrderByDescending(_ => _.Headquarters),

						(Orders.List_PkElectoralEvent, false) => queryable.OrderBy(_ => _.List_PkElectoralEvent),
						(Orders.List_PkElectoralEvent, true) => queryable.OrderByDescending(_ => _.List_PkElectoralEvent),

						(Orders.UrlWebsite, false) => queryable.OrderBy(_ => _.UrlWebsite),
						(Orders.UrlWebsite, true) => queryable.OrderByDescending(_ => _.UrlWebsite),

						(Orders.UrlLogo, false) => queryable.OrderBy(_ => _.UrlLogo),
						(Orders.UrlLogo, true) => queryable.OrderByDescending(_ => _.UrlLogo),

						(_, _) => queryable.Order<Party>(order)
					};

			return orderedqueryable ?? queryable.Order<Party>(orders);
		}
		public static IOrderedEnumerable<Party> Order(this IOrderedEnumerable<Party> queryable, params Order[] orders)
		{
			IOrderedEnumerable<Party>? orderedqueryable = null;

			foreach (Order order in orders)
				orderedqueryable = (order.Key, order.Descending) switch
				{
					(Orders.Abbr, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.Abbr),
					(Orders.Abbr, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.Abbr),

					(Orders.Name, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.Name),
					(Orders.Name, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.Name),

					(Orders.DateEstablished, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.DateEstablished),
					(Orders.DateEstablished, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.DateEstablished),

					(Orders.DateDisestablished, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.DateDisestablished),
					(Orders.DateDisestablished, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.DateDisestablished),

					(Orders.Headquarters, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.Headquarters),
					(Orders.Headquarters, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.Headquarters),

					(Orders.List_PkElectoralEvent, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.List_PkElectoralEvent),
					(Orders.List_PkElectoralEvent, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.List_PkElectoralEvent),

					(Orders.UrlWebsite, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.UrlWebsite),
					(Orders.UrlWebsite, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.UrlWebsite),

					(Orders.UrlLogo, false) => (orderedqueryable ?? queryable).ThenBy(_ => _.UrlLogo),
					(Orders.UrlLogo, true) => (orderedqueryable ?? queryable).ThenByDescending(_ => _.UrlLogo),

					(_, _) => (orderedqueryable ?? queryable).Order<Party>(order)
				};

			return orderedqueryable ?? queryable;
		}
	}
}
