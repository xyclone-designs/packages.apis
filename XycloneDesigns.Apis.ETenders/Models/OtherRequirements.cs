using System.Collections.Generic;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class OtherRequirements : Model 
    {
        public List<string>? ReservedParticipation { get; set; }
        public bool? RequiresStaffNamesAndQualifications { get; set; }
    }
}