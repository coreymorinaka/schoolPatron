using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route ("walmart")]
    public class WalmartController : Controller
    {
        public WalmartController ()
        {

        }

        [HttpGet]
        public string Get (string query)
        {

            WebClient client = new WebClient ();

            string response = client.DownloadString ("http://api.walmartlabs.com/v1/search?query=" + query + "&format=json&apiKey=53dhpkus4f3y7wfzgncz9me5");

            return response;
        }
    }
}