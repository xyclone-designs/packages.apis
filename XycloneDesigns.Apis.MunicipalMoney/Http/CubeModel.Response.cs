using Newtonsoft.Json;

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.MunicipalMoney.Http
{
	public partial class CubeModel 
	{
		public class Response : MunicipalMoney.Response
		{
            public class Json
            {
				public const string Model = "model";
				public const string Name = "name";
				public const string Status = "status";
			}

			[JsonProperty(Json.Model), JsonPropertyName(Json.Model)] public ModelObject? Model { get; set; }
			[JsonProperty(Json.Name), JsonPropertyName(Json.Name)] public string? Name { get; set; }
            [JsonProperty(Json.Status), JsonPropertyName(Json.Status)] public string? Status { get; set; }

			public class ModelObject
			{
				public class Json
				{
					public const string Aggregates = "aggregates";
					public const string Description = "description";
					public const string Dimensions = "dimensions";
					public const string FactTable = "fact_table";
					public const string Hierarchies = "hierarchies";
					public const string Label = "label";
					public const string LastUpdated = "last_updated";
					public const string Measures = "measures";
					public const string ReturnForms = "return_forms";
					public const string UpdateCycle = "update_cycle";
				}

				[JsonProperty(Json.Aggregates), JsonPropertyName(Json.Aggregates)] public Dictionary<string, Aggregate>? Aggregates { get; set; }
				[JsonProperty(Json.Description), JsonPropertyName(Json.Description)] public string? Description { get; set; }
				[JsonProperty(Json.Dimensions), JsonPropertyName(Json.Dimensions)] public Dictionary<string, Dimension>? Dimensions { get; set; }
				[JsonProperty(Json.FactTable), JsonPropertyName(Json.FactTable)] public string? FactTable { get; set; }
				[JsonProperty(Json.Hierarchies), JsonPropertyName(Json.Hierarchies)] public Dictionary<string, object>? Hierarchies { get; set; }
				[JsonProperty(Json.Label), JsonPropertyName(Json.Label)] public string? Label { get; set; }
				[JsonProperty(Json.LastUpdated), JsonPropertyName(Json.LastUpdated)] public string? LastUpdated { get; set; }
				[JsonProperty(Json.Measures), JsonPropertyName(Json.Measures)] public Dictionary<string, Measure>? Measures { get; set; }
				[JsonProperty(Json.ReturnForms), JsonPropertyName(Json.ReturnForms)] public List<string>? ReturnForms { get; set; }
				[JsonProperty(Json.UpdateCycle), JsonPropertyName(Json.UpdateCycle)] public string? UpdateCycle { get; set; }

				public class Aggregate
				{
					public class Json
					{
						public const string Function = "function";
						public const string Label = "label";
						public const string Ref = "ref";
					}

					[JsonProperty(Json.Function), JsonPropertyName(Json.Function)] public string? Function { get; set; }
					[JsonProperty(Json.Label), JsonPropertyName(Json.Label)] public string? Label { get; set; }
					[JsonProperty(Json.Ref), JsonPropertyName(Json.Ref)] public string? Ref { get; set; }
				}
				public class Dimension
				{
					public class Json
					{
						public const string Attributes = "attributes";
						public const string KeyAttribute = "key_attribute";
						public const string LabelAttribute = "label_attribute";
						public const string Description = "description";
						public const string Label = "label";
						public const string JoinColumn = "join_column";
						public const string Ref = "ref";
						public const string LabelRef = "label_ref";
						public const string KeyRef = "key_ref";
						public const string CardinalityClass = "cardinality_class";
						public const string Hierarchy = "hierarchy";
					}
					
					[JsonProperty(Json.Attributes), JsonPropertyName(Json.Attributes)] public Attribute? Attributes { get; set; }
					[JsonProperty(Json.KeyAttribute), JsonPropertyName(Json.KeyAttribute)] public string? KeyAttribute { get; set; }
					[JsonProperty(Json.LabelAttribute), JsonPropertyName(Json.LabelAttribute)] public string? LabelAttribute { get; set; }
					[JsonProperty(Json.Description), JsonPropertyName(Json.Description)] public string? Description { get; set; }
					[JsonProperty(Json.Label), JsonPropertyName(Json.Label)] public string? Label { get; set; }
					// TODO [JsonProperty(Json.JoinColumn), JsonPropertyName(Json.JoinColumn), Newtonsoft.Json.JsonConverter(typeof(JsonForceStringListConverter))] public List<string>? JoinColumn { get; set; }
					[JsonProperty(Json.Ref), JsonPropertyName(Json.Ref)] public string? Ref { get; set; }
					[JsonProperty(Json.LabelRef), JsonPropertyName(Json.LabelRef)] public string? LabelRef { get; set; }
					[JsonProperty(Json.KeyRef), JsonPropertyName(Json.KeyRef)] public string? KeyRef { get; set; }
					[JsonProperty(Json.CardinalityClass), JsonPropertyName(Json.CardinalityClass)] public string? CardinalityClass { get; set; }
					[JsonProperty(Json.Hierarchy), JsonPropertyName(Json.Hierarchy)] public string? Hierarchy { get; set; }

					public class Attribute
					{
						public class Json
						{
							public const string Code = "code";
							public const string Label = "label";
						}

						[JsonProperty(Json.Code), JsonPropertyName(Json.Code)] public Item? Code { get; set; }
						[JsonProperty(Json.Label), JsonPropertyName(Json.Label)] public Item? Label { get; set; }

						public class Item
						{
							public class Json
							{
								public const string Description = "description";
								public const string Column = "column";
								public const string Label = "label";
								public const string Ref = "ref";
								public const string Type = "type";
							}

							[JsonProperty(Json.Description), JsonPropertyName(Json.Description)] public string? Description { get; set; }
							[JsonProperty(Json.Column), JsonPropertyName(Json.Column)] public string? Column { get; set; }
							[JsonProperty(Json.Label), JsonPropertyName(Json.Label)] public string? Label { get; set; }
							[JsonProperty(Json.Ref), JsonPropertyName(Json.Ref)] public string? Ref { get; set; }
							[JsonProperty(Json.Type), JsonPropertyName(Json.Type)] public string? Type { get; set; }
						}
					}
				}
				public class Measure
				{
					public class Json
					{
						public const string Column = "column";
						public const string Label = "label";
						public const string Ref = "ref";
					}

					[JsonProperty(Json.Column), JsonPropertyName(Json.Column)] public string? Column { get; set; }
					[JsonProperty(Json.Label), JsonPropertyName(Json.Label)] public string? Label { get; set; }
					[JsonProperty(Json.Ref), JsonPropertyName(Json.Ref)] public string? Ref { get; set; }
				}
			}
		}
	}
}
