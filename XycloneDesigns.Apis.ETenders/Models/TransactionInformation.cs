using Newtonsoft.Json;

using System;
using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class TransactionInformation : Model
	{
		public class Json
		{
			public const string Date = "date";
			public const string Id = "id";
			public const string Payee = "payee";
			public const string Payer = "payer";
			public const string Source = "source";
			public const string Uri = "uri";
			public const string Value = "value";
		}

		[JsonProperty(Json.Date), JsonPropertyName(Json.Date)] public DateTime? Date { get; set; }
		[JsonProperty(Json.Id), JsonPropertyName(Json.Id)] public string? Id { get; set; }
		[JsonProperty(Json.Payee), JsonPropertyName(Json.Payee)] public OrganisationReference? Payee { get; set; }
		[JsonProperty(Json.Payer), JsonPropertyName(Json.Payer)] public OrganisationReference? Payer { get; set; }
		[JsonProperty(Json.Source), JsonPropertyName(Json.Source)] public string? Source { get; set; }
		[JsonProperty(Json.Uri), JsonPropertyName(Json.Uri)] public Uri? Uri { get; set; }
		[JsonProperty(Json.Value), JsonPropertyName(Json.Value)] public Value? Value { get; set; }
	}
}