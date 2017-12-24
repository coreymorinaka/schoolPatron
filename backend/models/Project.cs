using System;
using System.Collections.Generic;

namespace backend.Controllers
{

    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Subject { get; set; }
        public string GradeLevel { get; set; }
        public string Description { get; set; }
        public bool GoalReached { get; set; }
        public int? TeacherId { get; set; }
        public int? ProductId { get; set; }
        public int? SchoolId { get; set; }
        public List<WalmartProduct> walmartproducts { get; set; }

    }

}