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
        public int patronId = 21; 
        
        public PatronController (SchoolPatronContext context)
        {
            _context = context;
            if(_context.patrons.Count() == 0)
            {
                _context.patrons.Add(new Patron(){Id = 1, FirstName = "David", LastName="Kayo", Email="sp@basepod.com", Passsword="Kayo"});
                _context.patrons.Add(new Patron(){Id = 2, FirstName = "Corey", LastName="Morinaka", Email="sp@basepod.com", Passsword="Morinaka"});
                 _context.patrons.Add(new Patron(){Id = 4, FirstName = "Amancio", LastName="Ortega", Email="83.2billion@zara.com", Passsword="Ortega"});
                _context.patrons.Add(new Patron(){Id = 3, FirstName = "Warren", LastName="Buffett", Email="75.6billion@berkshirehathaway.com", Passsword="Buffett"});
                _context.patrons.Add(new Patron(){Id = 5, FirstName = "Mark", LastName="Zuckerberg", Email="56billion@facebook.com", Passsword="Zuckerberg"});
                _context.patrons.Add(new Patron(){Id = 6, FirstName = "Carlos", LastName="Slim Helu", Email="54.5@americamovil.com", Passsword="Helu"});
                _context.patrons.Add(new Patron(){Id = 7, FirstName = "Larry", LastName="Ellison", Email="52.2billion@oracle.com", Passsword="Ellison"});
                _context.patrons.Add(new Patron(){Id = 8, FirstName = "Charles", LastName="Koch", Email="48.3billion@kochindustries.com", Passsword="Koch"});
                _context.patrons.Add(new Patron(){Id = 9, FirstName = "David", LastName="Koch", Email="48.3billion@kochindustries.com", Passsword="Koch"});
                _context.patrons.Add(new Patron(){Id = 10, FirstName = "Michael", LastName="Bloomberg", Email="47.5billion@bloomberg.com", Passsword="Bloomberg"});
                _context.patrons.Add(new Patron(){Id = 11, FirstName = "Bernard", LastName="Arnault", Email="41.5billion@louisvuitton.com", Passsword="Arnault"});
                _context.patrons.Add(new Patron(){Id = 12, FirstName = "Larry", LastName="Page", Email="39.8billion@gmail.com", Passsword="Page"});
                _context.patrons.Add(new Patron(){Id = 13, FirstName = "Sergey", LastName="Brin", Email="39.8billion@gmail.com", Passsword="Brin"});
                _context.patrons.Add(new Patron(){Id = 14, FirstName = "Liliane", LastName="Bettencourt", Email="39.5billion@loreal.com", Passsword="Bettencourt"});
                _context.patrons.Add(new Patron(){Id = 15, FirstName = "Rob", LastName="Walton", Email="34.1billion@walmart.com", Passsword="Walton"});
                _context.patrons.Add(new Patron(){Id = 16, FirstName = "Jim", LastName="Walton", Email="34billion@walmart.com", Passsword="Walton"});
                _context.patrons.Add(new Patron(){Id = 17, FirstName = "Alice", LastName="Walton", Email="33.8billion@walmart.com", Passsword="Walton"});
                _context.patrons.Add(new Patron(){Id = 18, FirstName = "Wang", LastName="Jianlin", Email="31.3billion@wandagroup.com", Passsword="Jianlin"});
                _context.patrons.Add(new Patron(){Id = 19, FirstName = "Li", LastName="Ka-Shing", Email="31.2billion@hutchisonholdings.com", Passsword="Ka-Shing"});
                _context.patrons.Add(new Patron(){Id = 20, FirstName = "Sheldon", LastName="Adelson", Email="30.4billion@lvsands.com", Passsword="Adelson"});
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
