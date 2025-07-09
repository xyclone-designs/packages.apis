
using System;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class TransactionInformation : Model
	{
		public DateTime? Date { get; set; }
		public string? Id { get; set; }
		public OrganisationReference? Payee { get; set; }
		public OrganisationReference? Payer { get; set; }
		public string? Source { get; set; }
		public Uri? Uri { get; set; }
		public Value? Value { get; set; }
	}
}