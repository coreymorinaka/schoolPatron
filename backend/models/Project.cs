using System;

namespace backend.Controllers{
    
    public class Project
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Subject { get; set; }
        public string GradeLevel { get; set; }
        public string Description { get; set; }

        // public int TeacherId { get; set; }
    }
}