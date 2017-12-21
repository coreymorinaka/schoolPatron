using System;
using backend.Controllers;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    public class SchoolPatronContext : DbContext
    {
        public SchoolPatronContext (DbContextOptions<SchoolPatronContext> options) : base (options)
        {

        }
        public DbSet<Patron> patrons { get; set; }
        public DbSet<School> schools { get; set; }
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Project> projects { get; set; }
    }

}