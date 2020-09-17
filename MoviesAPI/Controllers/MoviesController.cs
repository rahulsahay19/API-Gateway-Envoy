using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MoviesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private static readonly string[] Movies = new[]
        {
            "Die Another Day", "Top Gun", "Grease", "Dil Bechara", "Jurassic Park"
        };

    
        [HttpGet]
        public ActionResult Get()
        {
            var rng = new Random();
            
            return Ok(Movies[rng.Next(Movies.Length)]);
        }
    }
}