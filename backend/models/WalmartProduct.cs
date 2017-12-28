using System;

namespace backend.Controllers{
    
    public class WalmartProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SalePrice { get; set; }
        public string ShortDescription { get; set; }
        public string MediumImage { get; set; }
        public string CustomerRatingImage { get; set; }
        public int? ProjectId { get; set; }
    }
}