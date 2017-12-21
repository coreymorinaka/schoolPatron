using System;
using Microsoft.EntityFrameworkCore;
using backend.Controllers;

namespace backend.Controllers
{
  public class SchoolPatronContext : DbContext
  {
    public SchoolPatronContext(DbContextOptions<SchoolPatronContext> options) : base(options)
    {

    }
    public DbSet<Patron> patrons { get; set; }
    public DbSet<School> schools { get; set; }
    public DbSet<Teacher> teachers { get; set; }

  }
}