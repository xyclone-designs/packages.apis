using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Models;
using XycloneDesigns.Apis.General.Http;
using XycloneDesigns.Apis.Afrobarometer.Tables;

namespace XycloneDesigns.Apis.Afrobarometer.Http
{
	public static partial class Variables
	{
		public class Filters : GeneralBase.Filters
		{
			public const string Id = Variable.SQL.Column_Id;
			public const string Label = Variable.SQL.Column_Label;
			public const string ValueLabels = Variable.SQL.Column_ValueLabels;

			public new static IEnumerable<string> AsEnumerable()
			{
				return GeneralBase.Filters.AsEnumerable()
					.Append(Id)
					.Append(Label)
					.Append(ValueLabels);
			}
		}

		public static bool Filter(this Filter filter, Variable variable)
		{
			return filter.Key switch
			{
				Filters.Id => filter.Passes(variable.Id),
				Filters.Label => filter.Passes(variable.Label),
				Filters.ValueLabels => filter.Passes(variable.ValueLabels),

				_ => filter.Filter<Variable>(variable),
			};
		}
	}
}
