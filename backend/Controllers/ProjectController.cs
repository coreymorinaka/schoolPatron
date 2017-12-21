using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("project")]
    public class ProjectController : Controller
    {
        private readonly SchoolPatronContext _context;
        public int projectId = 3;
        
        public ProjectController (SchoolPatronContext context)
        {
            _context = context;
            if(_context.projects.Count() == 0)
            {
                _context.projects.Add(new Project(){Id = 1, Name="Science Fair", StartDate="12-25-2017", EndDate="12-26-2017", Subject="Science", GradeLevel="7", Description="Lorem Ipsum", TeacherId = 1, ProductId = 1});
                _context.projects.Add(new Project(){Id = 1, Name="Math Challenge", StartDate="02-02-2018", EndDate="2-26-2018", Subject="Math", GradeLevel="8", Description="Lorem Ipsum", TeacherId = 1, ProductId = 1});
                
                _context.SaveChanges();
            }
        }
        
        // GET
        [HttpGet]
        public List<Project> Get ()
        {
            return _context.projects.ToList ();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Project Get(int id)
        {
            foreach (Project p in _context.projects)
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
        public Project Post([FromBody]Project p)
        {
            p.Id = projectId++;
            _context.projects.Add(p);
            _context.SaveChanges();

            return p;
        }

        // PUT api/values/5
        [HttpPut ("{id}")]
        public Project Put (int id, [FromBody] Project project)
        {
            foreach (Project p in _context.projects)
            {
                if (p.Id == id)
                {
                    _context.projects.Remove (p);
                    _context.SaveChanges ();
                    _context.projects.Add (project);
                    _context.SaveChanges ();

                    return project;
                }
            }
            return null;
        }

        // DELETE api/values/5
        [HttpDelete ("{id}")]
        public string Delete (int id)
        {
            foreach(Project p in _context.projects)
            {
                if(p.Id == id)
                {
                    _context.projects.Remove(p);
                    _context.SaveChanges();
                    return "deleted";
                }
            }
            return "not found";
        }
    }
}
