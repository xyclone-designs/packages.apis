using Newtonsoft.Json;

using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class Buyer : Model
	{
		public class Json
		{
			public const string Id = "id";
			public const string Name = "name";
		}

		[JsonProperty(Json.Id), JsonPropertyName(Json.Id)] public string? Id { get; set; }
        [JsonProperty(Json.Name), JsonPropertyName(Json.Name)] public string? Name { get; set; }
    }
}