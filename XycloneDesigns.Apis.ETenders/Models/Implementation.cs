using System.Collections.Generic;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class Implementation : Model 
    {
        public List<TransactionInformation>? Transactions { get; set; }
        public List<Milestone>? Milestones { get; set; }
        public List<Document>? Documents { get; set; }
    }
}