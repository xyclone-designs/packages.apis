using System.Collections.Generic;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class Planning : Model 
    {
        public string? Rationale { get; set; }
        public Budget? Budget { get; set; }
        public List<Document>? Documents { get; set; }
    }
}