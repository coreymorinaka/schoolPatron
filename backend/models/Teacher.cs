using System;

namespace backend.Controllers
{
  public class Teacher
  {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Bio { get; set; }
    public string Email { get; set; }
    public string GradeLevel { get; set; }
    public string Password { get; set; }
    public int? SchoolId { get; set; }
  }
}