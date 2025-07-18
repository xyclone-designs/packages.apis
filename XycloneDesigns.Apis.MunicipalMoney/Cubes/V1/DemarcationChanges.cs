﻿using Newtonsoft.Json;

using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.MunicipalMoney.Cubes.V1
{
	public class DemarcationChanges : Cube
	{
		[JsonProperty(Keys.Dates.Date), JsonPropertyName(Keys.Dates.Date)] public string? DatesDate { get; set; }
		[JsonProperty(Keys.Demarcation.CodeNew), JsonPropertyName(Keys.Demarcation.CodeNew)] public string? DemarcationCodeNew { get; set; }
		[JsonProperty(Keys.Demarcation.CodeOld), JsonPropertyName(Keys.Demarcation.CodeOld)] public string? DemarcationCodeOld { get; set; }
		[JsonProperty(Keys.Demarcation.CodeTransitionNew), JsonPropertyName(Keys.Demarcation.CodeTransitionNew)] public string? DemarcationCodeTransitionNew { get; set; }
		[JsonProperty(Keys.Demarcation.CodeTransitionOld), JsonPropertyName(Keys.Demarcation.CodeTransitionOld)] public string? DemarcationCodeTransitionOld { get; set; }

		public static IEnumerable<string> KeysEnumerable
		{
			get => Enumerable.Empty<string>()
				.Append(Keys.Dates.Date)
				.Append(Keys.Demarcation.CodeNew)
				.Append(Keys.Demarcation.CodeOld)
				.Append(Keys.Demarcation.CodeTransitionNew)
				.Append(Keys.Demarcation.CodeTransitionOld);
		}
	}
}