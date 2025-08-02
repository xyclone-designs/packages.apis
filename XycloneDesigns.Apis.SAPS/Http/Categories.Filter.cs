using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Models;
using XycloneDesigns.Apis.General.Http;
using XycloneDesigns.Apis.SAPS.Tables;

namespace XycloneDesigns.Apis.SAPS.Http
{
	public static partial class Categories
	{
		public class Filters : Base.Filters
		{
			public const string Name = Category.SQL.Column_Name;
						
			public new static IEnumerable<string> AsEnumerable()
			{
				return Base.Filters.AsEnumerable()
					.Append(Name);
			}
		}

		public static bool Filter(this Filter filter, Category category)
		{
			return filter.Key switch
			{
				Filters.Name => filter.Passes(category.Name),

				_ => filter.Filter<Category>(category),
			};
		}
	}
}
