using System;

namespace backend.Controllers{
    
    public class Product
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
        public bool InStock { get; set; }
        public string Description { get; set; }
        public int PatronId { get; set; }
        public int ProjectId { get; set; }
    }
}