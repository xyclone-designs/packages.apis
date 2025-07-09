
namespace XycloneDesigns.Apis.ETenders.Models
{
    public class Techniques : Model
	{
		public ElectronicAuction? ElectronicAuction { get; set; }
		public FrameworkAgreement? FrameworkAgreement { get; set; }
		public bool HasElectronicAuction { get; set; }
		public bool HasFrameworkAgreement { get; set; }
	}
}