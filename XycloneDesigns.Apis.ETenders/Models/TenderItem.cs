using Newtonsoft.Json;

using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class TenderItem : Model
	{
		public class Json
		{
			public const string Description = "description";
			public const string Classification = "classification";
			public const string Classifications = "classifications";
			public const string Id = "id";
			public const string ItemId = "itemId";
			public const string Quantity = "quantity";
			public const string Unit = "unit";
		}

		[JsonProperty(Json.Description), JsonPropertyName(Json.Description)] public string? Description { get; set; }
		[JsonProperty(Json.Classification), JsonPropertyName(Json.Classification)] public string? Classification { get; set; }
		[JsonProperty(Json.Classifications), JsonPropertyName(Json.Classifications)] public Classification? Classifications { get; set; }
		[JsonProperty(Json.Id), JsonPropertyName(Json.Id)] public string? Id { get; set; }
		[JsonProperty(Json.ItemId), JsonPropertyName(Json.ItemId)] public string? ItemId { get; set; }
		[JsonProperty(Json.Quantity), JsonPropertyName(Json.Quantity)] public int Quantity { get; set; }
		[JsonProperty(Json.Unit), JsonPropertyName(Json.Unit)] public string? Unit { get; set; }
	}
}