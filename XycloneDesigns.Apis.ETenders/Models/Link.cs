using System;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class Link : Model 
    {
        public Uri? Next { get; set; }
        public Uri? Prev { get; set; }
    }
}