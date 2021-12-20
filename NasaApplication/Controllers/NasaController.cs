using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NasaApplication.Models;

namespace NasaApplication.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class NasaController : ControllerBase
    {

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<NasaController> _logger;

        public NasaController(ILogger<NasaController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<ResponseNasa> Get()
        {
            
        }


    }
}



   
        
    

