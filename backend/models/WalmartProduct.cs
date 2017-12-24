using System;

namespace backend.Controllers{
    
    public class WalmartProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public int ShortDescription { get; set; }
        public string Image { get; set; }
        public bool CustomerReviewRating { get; set; }
        public int? ProjectId { get; set; }
    }
}