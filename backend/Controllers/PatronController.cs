using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("patron")]
    public class PatronController : Controller
    {
        private readonly SchoolPatronContext _context;
        public int patronId = 3;
        
        public PatronController (SchoolPatronContext context)
        {
            _context = context;
            if(_context.patrons.Count() == 0)
            {
                _context.patrons.Add(new Patron(){Id = 1, FirstName = "Amy", LastName="Smith", Email="sp@basepod.com", Passsword="school"});
                _context.patrons.Add(new Patron(){Id = 2, FirstName = "Corey", LastName="Smith", Email="sp@basepod.com", Passsword="school"});
                _context.SaveChanges();
            }
        }
        // GET
        [HttpGet]
        public List<Patron> Get ()
        {
            return _context.patrons.ToList ();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Patron Get(int id)
        {
            foreach (Patron p in _context.patrons)
            {
                if (p.Id == id)
                {
                    return p;
                }
            }
            return null;
        }
        

        // POST api/values
        [HttpPost]
        public Patron Post([FromBody]Patron p)
        {
            p.Id = patronId++;
            _context.patrons.Add(p);
            _context.SaveChanges();

            return p;
        }

        // PUT api/values/5
        [HttpPut ("{id}")]
        public Patron Put (int id, [FromBody] Patron patron)
        {
            foreach (Patron p in _context.patrons)
            {
                if (p.Id == id)
                {
                    _context.patrons.Remove (p);
                    _context.SaveChanges ();
                    _context.patrons.Add (patron);
                    _context.SaveChanges ();

                    return patron;
                }
            }
            return null;
        }

        // DELETE api/values/5
        [HttpDelete ("{id}")]
        public string Delete (int id)
        {
            foreach(Patron p in _context.patrons)
            {
                if(p.Id == id)
                {
                    _context.patrons.Remove(p);
                    _context.SaveChanges();
                    return "deleted";
                }
            }
            return "not found";
        }
    }
}
