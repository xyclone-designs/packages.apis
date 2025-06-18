using XycloneDesigns.Apis.STATSSA.Enums;
using XycloneDesigns.Apis.STATSSA.Structs;

namespace XycloneDesigns.Apis.STATSSA.Models
{
    public class Metadata : _Model
	{
		public Uncertain<TypeInstitution>? TypeInstitution { get; set; }
		public Uncertain<TypeQuestionnaireHouseholds>? TypeQuestionnaire { get; set; }
	}
}