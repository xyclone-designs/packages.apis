
namespace XycloneDesigns.Apis.General.Models
{
	public partial class District : Model
	{
		public Country? Country { get; set; }
		public string? Code { get; set; }
		public string? Name { get; set; }
		public Province? Province { get; set; }
	}
}