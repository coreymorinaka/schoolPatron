using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("teacher")]
    public class TeacherController : Controller
    {
        private readonly SchoolPatronContext _context;
        public int teacherId = 3; 
        
        public TeacherController (SchoolPatronContext context)
        {
            _context = context;
            if(_context.teachers.Count() == 0)
            {

              _context.teachers.Add(new Teacher() {Id = 1, FirstName = "Sarah", LastName = "John", Bio ="Been working as a teacher for 10 years and I love my job", Email="sp@basepod.com", GradeLevel="2"});
              _context.teachers.Add(new Teacher() {Id = 2, FirstName="Jill", LastName="Black", Bio="Love beaing a teacher!", Email="sp@basepod.com", GradeLevel="4"});
              _context.SaveChanges();
            
            }
        }
        // GET
        [HttpGet]
        public List<Teacher> Get ()
        {
            return _context.teachers.ToList ();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Teacher Get(int id)
        {
            foreach (Teacher t in _context.teachers)
            {
                if (t.Id == id)
                {
                    return t;
                }
            }
            return null;
        }
        

        // POST api/values
        [HttpPost]
        public Teacher Post([FromBody]Teacher t)
        {
            t.Id = teacherId++;
            _context.teachers.Add(t);
            _context.SaveChanges();

            return t;
        }

        // PUT api/values/5
        [HttpPut ("{id}")]
        public Teacher Put (int id, [FromBody] Teacher teacher)
        {
            foreach (Teacher t in _context.teachers)
            {
                if (t.Id == id)
                {
                    _context.teachers.Remove (t);
                    _context.SaveChanges ();
                    _context.teachers.Add (teacher);
                    _context.SaveChanges ();

                    return teacher;
                }
            }
            return null;
        }

        // DELETE api/values/5
        [HttpDelete ("{id}")]
        public string Delete (int id)
        {
            foreach(Teacher t in _context.teachers)
            {
                if(t.Id == id)
                {
                    _context.teachers.Remove(t);
                    _context.SaveChanges();
                    return "deleted";
                }
            }
            return "not found";
        }
    }
}
