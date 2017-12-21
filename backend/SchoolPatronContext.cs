using System;
using Microsoft.EntityFrameworkCore;
using backend.Controllers;

namespace backend.Controllers
{
  public class SchoolPatronContext : DbContext
  {
    public SchoolPatronContext(DbContextOptions<SchoolPatronContext> options) : base(options)
    {
<<<<<<< HEAD

=======
        public SchoolPatronContext(DbContextOptions<SchoolPatronContext> options) : base(options)
        {
            
        }
        public DbSet<Patron> patrons { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Project> projects { get; set; }
>>>>>>> 8edcb112b821556ff62343cd011cbf6c61bccfc5
    }
    public DbSet<Patron> patrons { get; set; }
    public DbSet<School> schools { get; set; }
    public DbSet<Teacher> teachers { get; set; }

  }
}