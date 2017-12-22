using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace backend.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        private readonly SchoolPatronContext _context;
        public int productId = 3;
        
        public ProductController (SchoolPatronContext context)
        {
            _context = context;
            if(_context.products.Count() == 0)
            {
                _context.products.Add(new Product(){Id = 1, BrandName = "Samesung", Name="Monitor", Price=123, Category="electronics", InStock = true, Description="lorem ipsum", PatronId = 1, ProjectId = 1});
                _context.products.Add(new Product(){Id = 2, BrandName = "Dell", Name="Monitor", Price=123, Category="electronics", InStock = true, Description="lorem ipsum", PatronId = 1, ProjectId = 1});
                _context.SaveChanges();
            }
        }

        // GET
        // [HttpGet]
        // public List<Product> Get ()
        // {
        //     return _context.products.ToList ();
        // }
        [HttpGet]
        public string Get(string query)
        {

            WebClient client = new WebClient();

            string response = client.DownloadString("http://api.walmartlabs.com/v1/search?query=" + query + "&format=json&apiKey=53dhpkus4f3y7wfzgncz9me5");

            return response;
        }

        // GET api/values/5
        // [HttpGet("{id}")]
        // public Product Get(int id)
        // {
        //     foreach (Product p in _context.products)
        //     {
        //         if (p.Id == id)
        //         {
        //             return p;
        //         }
        //     }
        //     return null;
        // }
        
        // POST api/values
        [HttpPost]
        public Product Post([FromBody]Product p)
        {
            p.Id = productId++;
            _context.products.Add(p);
            _context.SaveChanges();

            return p;
        }

        // PUT api/values/5
        [HttpPut ("{id}")]
        public Product Put (int id, [FromBody] Product product)
        {
            foreach (Product p in _context.products)
            {
                if (p.Id == id)
                {
                    _context.products.Remove (p);
                    _context.SaveChanges ();
                    _context.products.Add (product);
                    _context.SaveChanges ();

                    return product;
                }
            }
            return null;
        }

        // DELETE api/values/5
        [HttpDelete ("{id}")]
        public string Delete (int id)
        {
            foreach(Product p in _context.products)
            {
                if(p.Id == id)
                {
                    _context.products.Remove(p);
                    _context.SaveChanges();
                    return "deleted";
                }
            }
            return "not found";
        }
    }
}
