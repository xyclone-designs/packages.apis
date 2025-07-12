using Newtonsoft.Json;

using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class Options : Model
	{
		public class Json
		{
			public const string Description = "description";
		}

		[JsonProperty(Json.Description), JsonPropertyName(Json.Description)] public string? Description { get; set; }
    }
}