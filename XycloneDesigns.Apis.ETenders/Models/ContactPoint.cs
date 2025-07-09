using System;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class ContactPoint : Model 
    {
        public string? Name { get; set; }
        public string? Telephone { get; set; }
        public string? Email { get; set; }
        public string? FaxNumber { get; set; }
        public Uri? Url { get; set; }
	}
}