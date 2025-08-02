using System;
using System.Collections.Generic;
using System.Linq;

using Xunit;

using XycloneDesigns.Apis.General.Http.Enums;
using XycloneDesigns.Apis.General.Http.Models;
using XycloneDesigns.Apis.General.Http.Rest;
using XycloneDesigns.Apis.General.Tables;

namespace XycloneDesigns.Apis._Tests.General
{
	public partial class ModelsTest
	{
		public static readonly Country[] Countries =
		[
			new Country { Pk = 00 },
			new Country { Pk = 01 },
			new Country { Pk = 02 },
			new Country { Pk = 03 },
			new Country { Pk = 04 },
			new Country { Pk = 05 },
		];

		public static IEnumerable<object?[]> FilterDataDateTime()
		{
			yield return new object?[] { "pk|11-12-1999|equal", new Filter("pk", DateTime.Parse("11-12-1999"), Operations.Equal) };
			yield return new object?[] { "pk|11-12-1999|notequal", new Filter("pk", DateTime.Parse("11-12-1999"), Operations.NotEqual) };
			yield return new object?[] { "pk|11-12-1999|lessthan", new Filter("pk", DateTime.Parse("11-12-1999"), Operations.LessThan) };
			yield return new object?[] { "pk|11-12-1999|lessthanorequal", new Filter("pk", DateTime.Parse("11-12-1999"), Operations.LessThanOrEqual) };
			yield return new object?[] { "pk|11-12-1999|greaterthan", new Filter("pk", DateTime.Parse("11-12-1999"), Operations.GreaterThan) };
			yield return new object?[] { "pk|11-12-1999|greaterthanorequal", new Filter("pk", DateTime.Parse("11-12-1999"), Operations.GreaterThanOrEqual) };
		}
		public static IEnumerable<object?[]> FilterDataInt()
		{
			yield return new object?[] { "pk|5|equal", new Filter("pk", 3, Operations.Equal), null };
			yield return new object?[] { "pk|5|notequal", new Filter("pk", 3, Operations.NotEqual), null };
			yield return new object?[] { "pk|5|lessthan", new Filter("pk", 3, Operations.LessThan), null };
			yield return new object?[] { "pk|5|lessthanorequal", new Filter("pk", 3, Operations.LessThanOrEqual), null };
			yield return new object?[] { "pk|5|greaterthan", new Filter("pk", 3, Operations.GreaterThan), null };
			yield return new object?[] { "pk|5|greaterthanorequal", new Filter("pk", 3, Operations.GreaterThanOrEqual), null };
		}
		public static IEnumerable<object?[]> FilterRestData()
		{
			yield return new object?[] { Array.Empty<Filter>(), Countries };
			yield return new object?[] { new Filter[] { new ("pk", 3, Operations.Equal) }, (Country[])[Countries[3]] };
			yield return new object?[] { new Filter[] { new ("pk", 3, Operations.NotEqual) }, (Country[])[.. Countries[0..3], .. Countries[4..^0]] };
			yield return new object?[] { new Filter[] { new ("pk", 2, Operations.Equal), new ("pk", 4, Operations.Equal) }, (Country[])[ Countries[2], Countries[4] ] };
			yield return new object?[] { new Filter[] { new ("pk", 2, Operations.NotEqual), new ("pk", 4, Operations.NotEqual) }, (Country[])[..Countries[0..2], Countries[3], ..Countries[5..^0]] };
			yield return new object?[] { new Filter[] { new ("pk", 3, Operations.LessThan), }, (Country[])[.. Countries[0..3]] };
			yield return new object?[] { new Filter[] { new ("pk", 3, Operations.LessThanOrEqual), }, (Country[])[.. Countries[0..4]] };
			yield return new object?[] { new Filter[] { new ("pk", 3, Operations.LessThan), new ("pk", 5, Operations.Equal) }, (Country[])[.. Countries[0..3], Countries[5]] };
			yield return new object?[] { new Filter[] { new ("pk", 3, Operations.LessThan), new ("pk", 0, Operations.NotEqual) }, (Country[])[.. Countries[1..3]] };
			yield return new object?[] { new Filter[] { new ("pk", 3, Operations.GreaterThan), }, (Country[])[.. Countries[4..^0]] };
			yield return new object?[] { new Filter[] { new ("pk", 3, Operations.GreaterThanOrEqual), }, (Country[])[.. Countries[3..^0]] };
			yield return new object?[] { new Filter[] { new ("pk", 3, Operations.GreaterThan), new ("pk", 1, Operations.Equal) }, (Country[])[Countries[1], ..Countries[4..^0]] };
			yield return new object?[] { new Filter[] { new ("pk", 3, Operations.GreaterThan), new ("pk", 5, Operations.NotEqual) }, (Country[])[.. Countries[4..^1]] };
		}

		[MemberData(nameof(FilterDataDateTime))]
		[Theory] public void FiltersDateTime(string str, Filter expected)
		{
			Filter filter = Filter.Parse<DateTime>(str);

			Assert.True(filter.Equals<DateTime>(expected));
		}
		[MemberData(nameof(FilterDataInt))]
		[Theory] public void FiltersInt(string str, Filter expected)
		{
			Filter filter = Filter.Parse<int>(str);

			Assert.True(filter.Equals<int>(expected));
		}

		[MemberData(nameof(FilterRestData))]
		[Theory]
		public void FilterRest(Filter[] filters, Country[] countries)
		{
			CountriesRest.Request request = new() { Filter = [.. filters] };
			CountriesRest.Response response = new(request, Countries);

			Assert.Equal(countries.Select(_ => _.Pk), response.Items.Select(_ => _.Pk));
		}
	}
}