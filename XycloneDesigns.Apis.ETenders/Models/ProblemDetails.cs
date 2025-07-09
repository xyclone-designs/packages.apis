
namespace XycloneDesigns.Apis.ETenders.Models
{
    public class ProblemDetails : Model 
    {
        public string? Detail { get; set; }
        public int? Instance { get; set; }
		public string? Status { get; set; }
		public string? Title { get; set; }
		public string? Type { get; set; }
    }
}