using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SeriesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SeriesController : ControllerBase
    {
        private static readonly string[] Series = new[]
        {
            "Dark Tourist", "Love is Blind", "Dracula", "Troy", "Bandish Bandits"
        };

    
        [HttpGet]
        public ActionResult Get()
        {
            var rng = new Random();
            
            return Ok(Series[rng.Next(Series.Length)]);
        }
    }
}