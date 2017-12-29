using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route ("school")]
    public class SchoolController : Controller
    {
        private readonly SchoolPatronContext _context;
        public int schoolId = 3;

        public SchoolController (SchoolPatronContext context)
        {
            _context = context;
            if (_context.schools.Count () == 0)
            {

                _context.schools.Add (new School () { Id = 1, Name = "Benjamin Franklin Elementary School", Address = "1116 Jefferson Ave", City = "New Orleans", State = "LA", PhoneNumber = "504-304-3932" });
                _context.schools.Add (new School () { Id = 2, Name = "Arsenal Elementary School", Address = "215 39th St", City = "Pittsburgh", State = "PA", PhoneNumber = "412-622-7307" });
                _context.schools.Add (new School () { Id = 3, Name = "Park Slope Collegiate", Address = "237 7th Ave", City = "New York", State = "NY", PhoneNumber = "718-832-4300" });
                _context.schools.Add (new School () { Id = 4, Name = "Samuel Pennypacker Elementary School", Address = "1858 Washington Ln", City = "Philadelphia", State = "PA", PhoneNumber = "215-276-5271" });
                _context.schools.Add (new School () { Id = 5, Name = "James Campbell High School", Address = "91-980 N Rd,", City = "Ewa Beach", State = "HI", PhoneNumber = "808-305-3600" });
                _context.schools.Add (new School () { Id = 6, Name = "Roosevelt Elementary School", Address = "1026 10th St N", City = "Fargo", State = "ND", PhoneNumber = "701-446-5300" });
                _context.schools.Add (new School () { Id = 7, Name = "South Seminole Middle School", Address = "101 S Winter Park Dr", City = "Casselberry", State = "FL", PhoneNumber = "407-746-1350" });
                _context.schools.Add (new School () { Id = 8, Name = "East End Community School", Address = "195 North St", City = "Portland", State = "ME", PhoneNumber = "(207) 874-8228" });
                _context.schools.Add (new School () { Id = 9, Name = "Peninsula Elementary School", Address = "8125 N Emerald Ave", City = "Portland", State = "OR", PhoneNumber = "503-916-6275" });
                _context.schools.Add (new School () { Id = 10, Name = "Annie Webb Blanton Elementary School", Address = "8915 Greenmound Ave", City = "Dallas", State = "TX", PhoneNumber = "972-794-1700" });
                _context.schools.Add (new School () { Id = 11, Name = "Pinecrest Academy St. Rose", Address = "1385 E Cactus Ave", City = "Las Vegas", State = "NV", PhoneNumber = "702-750-9150" });
                _context.schools.Add (new School () { Id = 12, Name = "Bennett Elementary School", Address = "2111 Mullane St", City = "Detroit", State = "MI", PhoneNumber = "313-849-3585" });
                _context.schools.Add (new School () { Id = 13, Name = "C Y Middle School", Address = "2900 Cyclone Dr", City = "Casper", State = "WY ", PhoneNumber = "307-253-2700" });
                _context.schools.Add (new School () { Id = 14, Name = "Nuview Elementary School", Address = "29680 Lakeview Ave", City = "Nuevo", State = "CA", PhoneNumber = "951-928-0201" });
                _context.schools.Add (new School () { Id = 15, Name = "Monroe County High School", Address = "212 Tiger Dr.", City = "Monroeville", State = "AL", PhoneNumber = "251-575-3257" });
                _context.schools.Add (new School () { Id = 16, Name = "Toppenish High School", Address = "141 Ward Rd", City = "Toppenish", State = "WA", PhoneNumber = "(509) 865-3370" });
                _context.schools.Add (new School () { Id = 17, Name = "Jenkins High School", Address = "1800 DeRenne Ave", City = "Savannah", State = "GA", PhoneNumber = "912-395-6300" });
                _context.schools.Add (new School () { Id = 18, Name = "Chief Ivan Blunka School", Address = "General Delivery, New Stuyahok", City = "New Stuyahok", State = "AK", PhoneNumber = "907-693-3144" });
                _context.schools.Add (new School () { Id = 19, Name = "Whittier Elementary School", Address = "1110 Quincy St SE", City = "Albuquerque", State = "NM", PhoneNumber = "505-255-2008" });
                _context.schools.Add (new School () { Id = 20, Name = "Quincy Upper School", Address = "900 Washington St", City = "Boston", State = "MA", PhoneNumber = "617-635-1515" });
                _context.SaveChanges ();

            }
        }
        // GET
        [HttpGet]
        public List<School> Get ()
        {
            return _context.schools.ToList ();
        }

        // GET by Id
        [HttpGet ("{id}")]
        public School Get (int id)
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

        // POST
        [HttpPost]
        public School Post ([FromBody] School p)
        {
            p.Id = schoolId++;
            _context.schools.Add (p);
            _context.SaveChanges ();

            return p;
        }

        // PUT
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

        // DELETE
        [HttpDelete ("{id}")]
        public string Delete (int id)
        {
            foreach (School s in _context.schools)
            {
                if (s.Id == id)
                {
                    _context.schools.Remove (s);
                    _context.SaveChanges ();
                    return "deleted";
                }
            }
            return "not found";
        }
    }
}