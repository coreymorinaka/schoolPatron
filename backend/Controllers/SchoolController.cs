using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("school")]
    public class SchoolController : Controller
    {
        private readonly SchoolPatronContext _context;
        public int schoolId = 3; 
        
        public SchoolController (SchoolPatronContext context)
        {
            _context = context;
            if(_context.schools.Count() == 0)
            {

              _context.schools.Add(new School() {Id = 1, Name = "EHS", Address = "21400 Magnolia St", City = "Huntington Beach", State = "CA", PhoneNumber ="714.962.1356"});
              _context.schools.Add(new School() {Id = 2, Name = "WHS", Address = "14325 Goldenwest St", City = "Westmsinter", State = "CA", PhoneNumber ="714 893 1381"});
              _context.SaveChanges();
               
            }
        }
        // GET
        [HttpGet]
        public List<School> Get ()
        {
            return _context.schools.ToList ();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public School Get(int id)
        {
            foreach (School s in _context.schools)
            {
                if (s.Id == id)
                {
                    return s;
                }
            }
            return null;
        }
        

        // POST api/values
        [HttpPost]
        public School Post([FromBody]School p)
        {
            p.Id = schoolId++;
            _context.schools.Add(p);
            _context.SaveChanges();

            return p;
        }

        // PUT api/values/5
        [HttpPut ("{id}")]
        public School Put (int id, [FromBody] School school)
        {
            foreach (School p in _context.schools)
            {
                if (p.Id == id)
                {
                    _context.schools.Remove (p);
                    _context.SaveChanges ();
                    _context.schools.Add (school);
                    _context.SaveChanges ();

                    return school;
                }
            }
            return null;
        }

        // DELETE api/values/5
        [HttpDelete ("{id}")]
        public string Delete (int id)
        {
            foreach(School s in _context.schools)
            {
                if(s.Id == id)
                {
                    _context.schools.Remove(s);
                    _context.SaveChanges();
                    return "deleted";
                }
            }
            return "not found";
        }
    }
}
